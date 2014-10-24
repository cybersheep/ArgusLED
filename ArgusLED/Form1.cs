using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using ArgusTV.ServiceContracts.Events;
using ArgusTV.ServiceAgents;
using ArgusTV.ServiceContracts;
using ArgusTV.Recorder.Entities;
using ArgusTV.Client.Common;
using System.Diagnostics;

// 23-Oct 2014: minor change for GitHub testing v0.7

namespace ArgusLED
{
    public partial class Form1 : Form
    {

        //     private NotifyIcon  trayIcon;
        //    private ContextMenu trayMenu;

        private ServerSettings serverSettings;

        private int activeRecordingsCurrent = -1;
        private int activeRecordingsPrev = 0;
        private int activeRecordingsBreakpoint = 1;
        private double discPercentUsedCurrent = -1;
        private double discPercentUsedPrev = 0;
        private double discPercentUsedBreakpoint = 80;

        private int timerTicks = 0;
        private int timerIntervalInSecs = 30;


        private bool connected = false;


        private System.Windows.Forms.Timer TimerClickNext = new System.Windows.Forms.Timer();


        //        private Threshold prevDiscPercentUsedThreshold = Threshold.Lower;



        public Form1()
        {


            InitializeComponent();

            labelVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;


            TimerClickNext.Tick += new EventHandler(TimerClickNext_Tick);


            //init serversettings, and grab the default port to populate the UI.
            serverSettings = new ServerSettings();
            serverSettings.Transport = ServiceTransport.NetTcp;
            textBoxServerPort.Text = Convert.ToString(ServerSettings.DefaultTcpPort);


            const int defaultport = 49822;
            const int portrange = 100;

            int port = GetFreeTcpPort(defaultport, defaultport - portrange);
            if (port < 0)
            {
                textBoxMe.Text = "net.tcp://localhost:49822/Testing/";
                msgOut("No free port found in range");
            }
            else
            {
                textBoxMe.Text = "net.tcp://localhost:" + port + "/Testing/";
            }



            buttonResetConnection_Click(this, null);



        }



        public void msgOut(string text)
        {
            textBox1.Text += DateTime.Now.ToString("yyyy-mm-dd H:mm:ss.fff") + " - " + text + Environment.NewLine;
        }

        private void buttonResetConnection_Click(object sender, EventArgs e)
        {
            try
            {


                StopAllListenerServices();

                serverSettings.ServerName = textBoxServer.Text; // e.g. localhost
                serverSettings.Port = Convert.ToInt32(textBoxServerPort.Text);

                if (!ServiceChannelFactories.Initialize(serverSettings, false))
                {
                    msgOut("Cannot connect to ForTheRecordService - is the server and port correct?");
                    updateConnectionStatus(false);
                }
                else
                {

                    StartAllListenerServices(textBoxMe.Text);



                    using (CoreServiceAgent agent = new CoreServiceAgent())
                    {

                        //ArgusTV.DataContracts.EventGroup.RecordingEvents

                        ArgusTV.DataContracts.EventGroup eventGroupsToListenTo = ArgusTV.DataContracts.EventGroup.GuideEvents;
                        eventGroupsToListenTo |= ArgusTV.DataContracts.EventGroup.RecordingEvents;
                        eventGroupsToListenTo |= ArgusTV.DataContracts.EventGroup.ScheduleEvents;
                        eventGroupsToListenTo |= ArgusTV.DataContracts.EventGroup.SystemEvents;
                        agent.EnsureEventListener(eventGroupsToListenTo, textBoxMe.Text, ArgusTV.DataContracts.Constants.EventListenerApiVersion);
                    }


                    updateStatus();


                    updateConnectionStatus(true);

                }
            }
            catch (Exception ex)
            {
                updateConnectionStatus(false);
                msgOut(ex.ToString());
            }


            //  msgOut("DONE!");


        }


        private void updateConnectionStatus(bool temp)
        {
            connected = temp;
            msgOut("Is Connected? " + connected.ToString());
            if (connected == true)
            {
                labelConnectionStatus.ForeColor = Color.Green;
                labelConnectionStatus.Text = "Connected";
                TimerClickNext.Stop();
                timerTicks = 0;
            }
            else
            {
                labelConnectionStatus.ForeColor = Color.Red;
                labelConnectionStatus.Text = "Not connected";
                if (timerTicks >= 10)
                {
                    timerIntervalInSecs = 300;
                }
                else
                {
                    timerIntervalInSecs = 30;
                }
                TimerClickNext.Interval = (timerIntervalInSecs * 1000); // mins
                msgOut("cannot connect right now. Trying again in " + timerIntervalInSecs + " seconds");
                TimerClickNext.Start();

            }
        }




        private void TimerClickNext_Tick(object sender, EventArgs e)
        {
            msgOut(timerIntervalInSecs + " seconds is up, attempting to reconnect again!");
            buttonResetConnection_Click(this, null);
            timerTicks++;

            //   if (timerTicks >= 10)
            //  {
            //      timerIntervalInSecs = 300;
            //  }
        }



        public void updateStatus()
        {
            //do nothing
            using (ControlServiceAgent agent = new ControlServiceAgent())
            {
                ArgusTV.DataContracts.ActiveRecording[] currentRecordings = agent.GetActiveRecordings();
                // msgOut("LEN= " + currentRecordings.Length);

                activeRecordingsCurrent = currentRecordings.Length;
                discPercentUsedCurrent = agent.GetRecordingDisksInfo().PercentageUsed;

                msgOut("Active recordings changed from " + activeRecordingsPrev + " to " + activeRecordingsCurrent);
                labelActiveRecordingNum.Text = Convert.ToString(activeRecordingsCurrent);


                if (activeRecordingsCurrent != activeRecordingsPrev)
                {
                    if (activeRecordingsCurrent >= activeRecordingsBreakpoint)
                    {
                        //above or equal to
                        executeCommand(textBoxCommandFilename.Text, textBoxCommandRecording.Text);
                    }
                    else
                    {
                        //below
                        executeCommand(textBoxCommandFilename.Text, textBoxCommandNotRecording.Text);
                    }
                    activeRecordingsPrev = activeRecordingsCurrent;
                }


                msgOut("Disc used changed from " + discPercentUsedPrev + "% to " + discPercentUsedCurrent + "%");
                labelDiscUsedPercent.Text = Convert.ToString(discPercentUsedCurrent) + "%";

                if (discPercentUsedCurrent != discPercentUsedPrev)
                {
                    if (discPercentUsedCurrent >= discPercentUsedBreakpoint)
                    {
                        executeCommand(textBoxCommandFilename.Text, textBoxCommandDiscFull.Text);
                    }
                    else
                    {
                        executeCommand(textBoxCommandFilename.Text, textBoxCommandDiscNotFull.Text);
                    }
                    discPercentUsedPrev = discPercentUsedCurrent;
                }
            }
        }

        private void executeCommand(string file, string arguments)
        {
            try
            {
                msgOut("Executing: " + file + " " + arguments);

                Process p = new Process();
                // Redirect the output stream of the child process.
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = file;
                p.StartInfo.Arguments = arguments;

                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.StandardOutput.Close();
                p.WaitForExit(1000); //give it 1s.

                msgOut("Output" + output);
            }
            catch (Exception ex)
            {
                msgOut(ex.ToString());
            }
        }



        private List<ServiceHost> _serviceHosts = new List<ServiceHost>();

        private void StartAllListenerServices(string serviceUrl)
        {
            ServiceHost serviceHost = EventsListenerService.CreateServiceHost(serviceUrl);
            EventsListenerService.MainForm = this;
            serviceHost.Open();
            _serviceHosts.Add(serviceHost);
        }


        private void StopAllListenerServices()
        {
            foreach (ServiceHost serviceHost in _serviceHosts)
            {
                serviceHost.Close();
            }
            _serviceHosts.Clear();
        }

        private void buttonResetStatus_Click(object sender, EventArgs e)
        {
            updateStatus();
        }

        private void labelActiveRecordingNum_TextChanged(object sender, EventArgs e)
        {

        }



        //taken from jayrock's post - http://www.4therecord.eu/forum/viewtopic.php?f=30&t=1092&p=9824&hilit=tcp#p9824
        private int GetFreeTcpPort(int defaultport, int minport)
        {
            int port = -1;
            while (defaultport >= minport)
            {
                try
                {
                    msgOut("checking if port " + defaultport + " is free");
                    System.Net.Sockets.TcpListener tcpListener = new System.Net.Sockets.TcpListener(System.Net.IPAddress.Any, defaultport);
                    tcpListener.Start();
                    tcpListener.Stop();
                    port = defaultport;
                    msgOut("Success! using port " + port);
                    break;
                }
                catch (System.Net.Sockets.SocketException)
                {
                    msgOut("In use");
                    defaultport--;
                }
            }
            return port;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTestNotRecording_Click(object sender, EventArgs e)
        {
            executeCommand(textBoxCommandFilename.Text, textBoxCommandNotRecording.Text);
        }

        private void buttonTestRecording_Click(object sender, EventArgs e)
        {
            executeCommand(textBoxCommandFilename.Text, textBoxCommandRecording.Text);
        }

        private void buttonTestDiscFull_Click(object sender, EventArgs e)
        {
            executeCommand(textBoxCommandFilename.Text, textBoxCommandDiscFull.Text);
        }

        private void buttonTestDiscNotFull_Click(object sender, EventArgs e)
        {
            executeCommand(textBoxCommandFilename.Text, textBoxCommandDiscNotFull.Text);
        }






    }

    public class EventsListenerService : EventsListenerServiceBase
    {

        private static Form1 _mainForm;

        public static Form1 MainForm
        {
            set { _mainForm = value; }
        }


        public static ServiceHost CreateServiceHost(string eventsServiceBaseUrl)
        {
            return CreateServiceHost(typeof(EventsListenerService), eventsServiceBaseUrl, typeof(IGuideEventsListener),
                typeof(IRecordingEventsListener), typeof(IScheduleEventsListener), typeof(ISystemEventsListener));
        }

        /*
                public override void NewGuideData()
                {
                    _mainForm.msgOut("NewGuideData");
                }

                public override void UpcomingRecordingsChanged()
                {
                    _mainForm.msgOut("UpcomingRecordingsChanged");
                }

         
                public override void UpcomingAlertsChanged()
                {
                    _mainForm.msgOut("UpcomingAlertsChanged");
                }

                public override void UpcomingSuggestionsChanged()
                {
                    _mainForm.msgOut("UpcomingSuggestionsChanged");
                }

                public override void ScheduleChanged(Guid scheduleId)
                {
                    _mainForm.msgOut("ScheduleChanged");
                }

                public override void EnteringStandby()
                {
                    _mainForm.msgOut("EnteringStandby");
                }

         * * */

        public override void ActiveRecordingsChanged()
        {
            _mainForm.msgOut("ActiveRecordingsChanged");
            _mainForm.updateStatus();
        }

        public override void RecordingStarted(ArgusTV.DataContracts.Recording recording)
        {
            _mainForm.msgOut("RecordingStarted");
            _mainForm.updateStatus();
        }

        public override void RecordingEnded(ArgusTV.DataContracts.Recording recording)
        {
            _mainForm.msgOut("RecordingEnded");
            _mainForm.updateStatus();

        }

        public override void SystemResumed()
        {
            _mainForm.msgOut("SystemResumed");
            _mainForm.updateStatus();
        }


    }
}
