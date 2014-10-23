namespace ArgusLED
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonResetConnection = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxMe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDiscUsedPercent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonResetStatus = new System.Windows.Forms.Button();
            this.labelActiveRecordingNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonTestDiscNotFull = new System.Windows.Forms.Button();
            this.buttonTestDiscFull = new System.Windows.Forms.Button();
            this.buttonTestNotRecording = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCommandFilename = new System.Windows.Forms.TextBox();
            this.textBoxCommandDiscNotFull = new System.Windows.Forms.TextBox();
            this.buttonTestRecording = new System.Windows.Forms.Button();
            this.textBoxCommandDiscFull = new System.Windows.Forms.TextBox();
            this.textBoxCommandNotRecording = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCommandRecording = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(533, 332);
            this.textBox1.TabIndex = 0;
            // 
            // buttonResetConnection
            // 
            this.buttonResetConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetConnection.Location = new System.Drawing.Point(452, 49);
            this.buttonResetConnection.Name = "buttonResetConnection";
            this.buttonResetConnection.Size = new System.Drawing.Size(75, 23);
            this.buttonResetConnection.TabIndex = 1;
            this.buttonResetConnection.Text = "Reset";
            this.buttonResetConnection.UseVisualStyleBackColor = true;
            this.buttonResetConnection.Click += new System.EventHandler(this.buttonResetConnection_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServer.Location = new System.Drawing.Point(95, 21);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(184, 22);
            this.textBoxServer.TabIndex = 2;
            this.textBoxServer.Text = "127.0.0.1";
            // 
            // textBoxMe
            // 
            this.textBoxMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMe.Location = new System.Drawing.Point(137, 50);
            this.textBoxMe.Name = "textBoxMe";
            this.textBoxMe.Size = new System.Drawing.Size(309, 22);
            this.textBoxMe.TabIndex = 3;
            this.textBoxMe.Text = "net.tcp://localhost:49822/Testing/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Argus Server:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerPort.Location = new System.Drawing.Point(340, 21);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(69, 22);
            this.textBoxServerPort.TabIndex = 6;
            this.textBoxServerPort.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Argus LED listener:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelDiscUsedPercent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonResetStatus);
            this.groupBox1.Controls.Add(this.labelActiveRecordingNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(5, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // labelDiscUsedPercent
            // 
            this.labelDiscUsedPercent.AutoSize = true;
            this.labelDiscUsedPercent.Location = new System.Drawing.Point(133, 45);
            this.labelDiscUsedPercent.Name = "labelDiscUsedPercent";
            this.labelDiscUsedPercent.Size = new System.Drawing.Size(13, 17);
            this.labelDiscUsedPercent.TabIndex = 12;
            this.labelDiscUsedPercent.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Disc used:";
            // 
            // buttonResetStatus
            // 
            this.buttonResetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetStatus.Location = new System.Drawing.Point(453, 21);
            this.buttonResetStatus.Name = "buttonResetStatus";
            this.buttonResetStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonResetStatus.TabIndex = 10;
            this.buttonResetStatus.Text = "Refresh";
            this.buttonResetStatus.UseVisualStyleBackColor = true;
            this.buttonResetStatus.Click += new System.EventHandler(this.buttonResetStatus_Click);
            // 
            // labelActiveRecordingNum
            // 
            this.labelActiveRecordingNum.AutoSize = true;
            this.labelActiveRecordingNum.Location = new System.Drawing.Point(133, 18);
            this.labelActiveRecordingNum.Name = "labelActiveRecordingNum";
            this.labelActiveRecordingNum.Size = new System.Drawing.Size(13, 17);
            this.labelActiveRecordingNum.TabIndex = 9;
            this.labelActiveRecordingNum.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Active recordings:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelConnectionStatus);
            this.groupBox3.Controls.Add(this.buttonResetConnection);
            this.groupBox3.Controls.Add(this.textBoxServer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxMe);
            this.groupBox3.Controls.Add(this.textBoxServerPort);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 82);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionStatus.Location = new System.Drawing.Point(414, 24);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(113, 17);
            this.labelConnectionStatus.TabIndex = 8;
            this.labelConnectionStatus.Text = "Not connected";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonTestDiscNotFull);
            this.groupBox4.Controls.Add(this.buttonTestDiscFull);
            this.groupBox4.Controls.Add(this.buttonTestNotRecording);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxCommandFilename);
            this.groupBox4.Controls.Add(this.textBoxCommandDiscNotFull);
            this.groupBox4.Controls.Add(this.buttonTestRecording);
            this.groupBox4.Controls.Add(this.textBoxCommandDiscFull);
            this.groupBox4.Controls.Add(this.textBoxCommandNotRecording);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxCommandRecording);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 158);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commands";
            // 
            // buttonTestDiscNotFull
            // 
            this.buttonTestDiscNotFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestDiscNotFull.Location = new System.Drawing.Point(482, 131);
            this.buttonTestDiscNotFull.Name = "buttonTestDiscNotFull";
            this.buttonTestDiscNotFull.Size = new System.Drawing.Size(45, 23);
            this.buttonTestDiscNotFull.TabIndex = 16;
            this.buttonTestDiscNotFull.Text = "Test";
            this.buttonTestDiscNotFull.UseVisualStyleBackColor = true;
            this.buttonTestDiscNotFull.Click += new System.EventHandler(this.buttonTestDiscNotFull_Click);
            // 
            // buttonTestDiscFull
            // 
            this.buttonTestDiscFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestDiscFull.Location = new System.Drawing.Point(482, 102);
            this.buttonTestDiscFull.Name = "buttonTestDiscFull";
            this.buttonTestDiscFull.Size = new System.Drawing.Size(45, 23);
            this.buttonTestDiscFull.TabIndex = 15;
            this.buttonTestDiscFull.Text = "Test";
            this.buttonTestDiscFull.UseVisualStyleBackColor = true;
            this.buttonTestDiscFull.Click += new System.EventHandler(this.buttonTestDiscFull_Click);
            // 
            // buttonTestNotRecording
            // 
            this.buttonTestNotRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestNotRecording.Location = new System.Drawing.Point(482, 73);
            this.buttonTestNotRecording.Name = "buttonTestNotRecording";
            this.buttonTestNotRecording.Size = new System.Drawing.Size(45, 23);
            this.buttonTestNotRecording.TabIndex = 12;
            this.buttonTestNotRecording.Text = "Test";
            this.buttonTestNotRecording.UseVisualStyleBackColor = true;
            this.buttonTestNotRecording.Click += new System.EventHandler(this.buttonTestNotRecording_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Path and filename:";
            // 
            // textBoxCommandFilename
            // 
            this.textBoxCommandFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandFilename.Location = new System.Drawing.Point(161, 18);
            this.textBoxCommandFilename.Name = "textBoxCommandFilename";
            this.textBoxCommandFilename.Size = new System.Drawing.Size(366, 22);
            this.textBoxCommandFilename.TabIndex = 13;
            this.textBoxCommandFilename.Text = "C:\\Program Files (x86)\\LEDSdriver\\LEDSdriver.exe";
            // 
            // textBoxCommandDiscNotFull
            // 
            this.textBoxCommandDiscNotFull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandDiscNotFull.Location = new System.Drawing.Point(161, 130);
            this.textBoxCommandDiscNotFull.Name = "textBoxCommandDiscNotFull";
            this.textBoxCommandDiscNotFull.Size = new System.Drawing.Size(315, 22);
            this.textBoxCommandDiscNotFull.TabIndex = 8;
            this.textBoxCommandDiscNotFull.Text = "USEREVENT1=0";
            // 
            // buttonTestRecording
            // 
            this.buttonTestRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestRecording.Location = new System.Drawing.Point(482, 43);
            this.buttonTestRecording.Name = "buttonTestRecording";
            this.buttonTestRecording.Size = new System.Drawing.Size(45, 23);
            this.buttonTestRecording.TabIndex = 11;
            this.buttonTestRecording.Text = "Test";
            this.buttonTestRecording.UseVisualStyleBackColor = true;
            this.buttonTestRecording.Click += new System.EventHandler(this.buttonTestRecording_Click);
            // 
            // textBoxCommandDiscFull
            // 
            this.textBoxCommandDiscFull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandDiscFull.Location = new System.Drawing.Point(161, 102);
            this.textBoxCommandDiscFull.Name = "textBoxCommandDiscFull";
            this.textBoxCommandDiscFull.Size = new System.Drawing.Size(315, 22);
            this.textBoxCommandDiscFull.TabIndex = 7;
            this.textBoxCommandDiscFull.Text = "USEREVENT1=1";
            // 
            // textBoxCommandNotRecording
            // 
            this.textBoxCommandNotRecording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandNotRecording.Location = new System.Drawing.Point(161, 74);
            this.textBoxCommandNotRecording.Name = "textBoxCommandNotRecording";
            this.textBoxCommandNotRecording.Size = new System.Drawing.Size(315, 22);
            this.textBoxCommandNotRecording.TabIndex = 6;
            this.textBoxCommandNotRecording.Text = "USEREVENT0=0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Disc used <80%:";
            // 
            // textBoxCommandRecording
            // 
            this.textBoxCommandRecording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandRecording.Location = new System.Drawing.Point(161, 46);
            this.textBoxCommandRecording.Name = "textBoxCommandRecording";
            this.textBoxCommandRecording.Size = new System.Drawing.Size(315, 22);
            this.textBoxCommandRecording.TabIndex = 5;
            this.textBoxCommandRecording.Text = "USEREVENT0=1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Disc used >=80%:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Active recordings >=1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Active recordings =0:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 374);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.labelVersion);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(546, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(9, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(530, 298);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(6, 324);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(69, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 378);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ArgusLED";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonResetConnection;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDiscUsedPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonResetStatus;
        private System.Windows.Forms.Label labelActiveRecordingNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCommandDiscNotFull;
        private System.Windows.Forms.TextBox textBoxCommandDiscFull;
        private System.Windows.Forms.TextBox textBoxCommandNotRecording;
        private System.Windows.Forms.TextBox textBoxCommandRecording;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTestNotRecording;
        private System.Windows.Forms.Button buttonTestRecording;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCommandFilename;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonTestDiscNotFull;
        private System.Windows.Forms.Button buttonTestDiscFull;
    }
}

