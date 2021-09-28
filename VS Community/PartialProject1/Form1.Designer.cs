
namespace PartialProject1
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
            this.components = new System.ComponentModel.Container();
            this.gbDigitalData = new System.Windows.Forms.GroupBox();
            this.btnSetAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cbDigitalData6 = new System.Windows.Forms.CheckBox();
            this.cbDigitalData5 = new System.Windows.Forms.CheckBox();
            this.cbDigitalData4 = new System.Windows.Forms.CheckBox();
            this.cbDigitalData3 = new System.Windows.Forms.CheckBox();
            this.cbDigitalData2 = new System.Windows.Forms.CheckBox();
            this.cbDigitalData1 = new System.Windows.Forms.CheckBox();
            this.cbDigitalData0 = new System.Windows.Forms.CheckBox();
            this.gbAnalogData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAnalogDataDisplay = new System.Windows.Forms.Label();
            this.tbAnalogData = new System.Windows.Forms.TrackBar();
            this.gbCounter = new System.Windows.Forms.GroupBox();
            this.sbCounter = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCounterDisplay = new System.Windows.Forms.Label();
            this.btnPauseCounter = new System.Windows.Forms.Button();
            this.btnPlayCounter = new System.Windows.Forms.Button();
            this.btnResetCounter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDigitalDataSent = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDisplay1 = new System.Windows.Forms.Button();
            this.btnDisplay0 = new System.Windows.Forms.Button();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.btnDisplay3 = new System.Windows.Forms.Button();
            this.btnDisplay4 = new System.Windows.Forms.Button();
            this.btnDisplay5 = new System.Windows.Forms.Button();
            this.btnDisplay6 = new System.Windows.Forms.Button();
            this.gbDataSent = new System.Windows.Forms.GroupBox();
            this.lbDataSentDisplay = new System.Windows.Forms.Label();
            this.pbDataSentDisplay = new System.Windows.Forms.ProgressBar();
            this.gpSerialPortSettings = new System.Windows.Forms.GroupBox();
            this.cbPortsList = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnScanPorts = new System.Windows.Forms.Button();
            this.gbSendingOptions = new System.Windows.Forms.GroupBox();
            this.rbCounter = new System.Windows.Forms.RadioButton();
            this.rbAnalog = new System.Windows.Forms.RadioButton();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.gbDigitalData.SuspendLayout();
            this.gbAnalogData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnalogData)).BeginInit();
            this.gbCounter.SuspendLayout();
            this.gbDigitalDataSent.SuspendLayout();
            this.gbDataSent.SuspendLayout();
            this.gpSerialPortSettings.SuspendLayout();
            this.gbSendingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDigitalData
            // 
            this.gbDigitalData.Controls.Add(this.btnSetAll);
            this.gbDigitalData.Controls.Add(this.btnClearAll);
            this.gbDigitalData.Controls.Add(this.cbDigitalData6);
            this.gbDigitalData.Controls.Add(this.cbDigitalData5);
            this.gbDigitalData.Controls.Add(this.cbDigitalData4);
            this.gbDigitalData.Controls.Add(this.cbDigitalData3);
            this.gbDigitalData.Controls.Add(this.cbDigitalData2);
            this.gbDigitalData.Controls.Add(this.cbDigitalData1);
            this.gbDigitalData.Controls.Add(this.cbDigitalData0);
            this.gbDigitalData.Location = new System.Drawing.Point(12, 12);
            this.gbDigitalData.Name = "gbDigitalData";
            this.gbDigitalData.Size = new System.Drawing.Size(200, 93);
            this.gbDigitalData.TabIndex = 0;
            this.gbDigitalData.TabStop = false;
            this.gbDigitalData.Text = "Digital data";
            // 
            // btnSetAll
            // 
            this.btnSetAll.Location = new System.Drawing.Point(119, 60);
            this.btnSetAll.Name = "btnSetAll";
            this.btnSetAll.Size = new System.Drawing.Size(75, 23);
            this.btnSetAll.TabIndex = 12;
            this.btnSetAll.Text = "&Set all";
            this.btnSetAll.UseVisualStyleBackColor = true;
            this.btnSetAll.Click += new System.EventHandler(this.btnSetAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(6, 60);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "&Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // cbDigitalData6
            // 
            this.cbDigitalData6.AutoSize = true;
            this.cbDigitalData6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData6.Location = new System.Drawing.Point(20, 21);
            this.cbDigitalData6.Name = "cbDigitalData6";
            this.cbDigitalData6.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData6.TabIndex = 6;
            this.cbDigitalData6.Text = "&6";
            this.cbDigitalData6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData6.UseVisualStyleBackColor = true;
            // 
            // cbDigitalData5
            // 
            this.cbDigitalData5.AutoSize = true;
            this.cbDigitalData5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData5.Location = new System.Drawing.Point(43, 21);
            this.cbDigitalData5.Name = "cbDigitalData5";
            this.cbDigitalData5.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData5.TabIndex = 5;
            this.cbDigitalData5.Text = "&5";
            this.cbDigitalData5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData5.UseVisualStyleBackColor = true;
            // 
            // cbDigitalData4
            // 
            this.cbDigitalData4.AutoSize = true;
            this.cbDigitalData4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData4.Location = new System.Drawing.Point(66, 21);
            this.cbDigitalData4.Name = "cbDigitalData4";
            this.cbDigitalData4.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData4.TabIndex = 4;
            this.cbDigitalData4.Text = "&4";
            this.cbDigitalData4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData4.UseVisualStyleBackColor = true;
            // 
            // cbDigitalData3
            // 
            this.cbDigitalData3.AutoSize = true;
            this.cbDigitalData3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData3.Location = new System.Drawing.Point(89, 21);
            this.cbDigitalData3.Name = "cbDigitalData3";
            this.cbDigitalData3.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData3.TabIndex = 3;
            this.cbDigitalData3.Text = "&3";
            this.cbDigitalData3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData3.UseVisualStyleBackColor = true;
            this.cbDigitalData3.CheckedChanged += new System.EventHandler(this.cbDigitalData3_CheckedChanged);
            // 
            // cbDigitalData2
            // 
            this.cbDigitalData2.AutoSize = true;
            this.cbDigitalData2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData2.Location = new System.Drawing.Point(112, 21);
            this.cbDigitalData2.Name = "cbDigitalData2";
            this.cbDigitalData2.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData2.TabIndex = 2;
            this.cbDigitalData2.Text = "&2";
            this.cbDigitalData2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData2.UseVisualStyleBackColor = true;
            // 
            // cbDigitalData1
            // 
            this.cbDigitalData1.AutoSize = true;
            this.cbDigitalData1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData1.Location = new System.Drawing.Point(135, 21);
            this.cbDigitalData1.Name = "cbDigitalData1";
            this.cbDigitalData1.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData1.TabIndex = 1;
            this.cbDigitalData1.Text = "&1";
            this.cbDigitalData1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData1.UseVisualStyleBackColor = true;
            // 
            // cbDigitalData0
            // 
            this.cbDigitalData0.AutoSize = true;
            this.cbDigitalData0.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDigitalData0.Location = new System.Drawing.Point(158, 21);
            this.cbDigitalData0.Name = "cbDigitalData0";
            this.cbDigitalData0.Size = new System.Drawing.Size(17, 31);
            this.cbDigitalData0.TabIndex = 0;
            this.cbDigitalData0.Text = "&0";
            this.cbDigitalData0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDigitalData0.UseVisualStyleBackColor = true;
            // 
            // gbAnalogData
            // 
            this.gbAnalogData.Controls.Add(this.label5);
            this.gbAnalogData.Controls.Add(this.label1);
            this.gbAnalogData.Controls.Add(this.lbAnalogDataDisplay);
            this.gbAnalogData.Controls.Add(this.tbAnalogData);
            this.gbAnalogData.Location = new System.Drawing.Point(12, 111);
            this.gbAnalogData.Name = "gbAnalogData";
            this.gbAnalogData.Size = new System.Drawing.Size(200, 81);
            this.gbAnalogData.TabIndex = 1;
            this.gbAnalogData.TabStop = false;
            this.gbAnalogData.Text = "Analog data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "127";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // lbAnalogDataDisplay
            // 
            this.lbAnalogDataDisplay.AutoSize = true;
            this.lbAnalogDataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAnalogDataDisplay.Location = new System.Drawing.Point(86, 53);
            this.lbAnalogDataDisplay.Name = "lbAnalogDataDisplay";
            this.lbAnalogDataDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbAnalogDataDisplay.TabIndex = 1;
            this.lbAnalogDataDisplay.Text = "0";
            // 
            // tbAnalogData
            // 
            this.tbAnalogData.LargeChange = 1;
            this.tbAnalogData.Location = new System.Drawing.Point(1, 22);
            this.tbAnalogData.Maximum = 127;
            this.tbAnalogData.Name = "tbAnalogData";
            this.tbAnalogData.Size = new System.Drawing.Size(196, 45);
            this.tbAnalogData.TabIndex = 0;
            this.tbAnalogData.TickFrequency = 16;
            this.tbAnalogData.Scroll += new System.EventHandler(this.tbAnalogData_Scroll);
            // 
            // gbCounter
            // 
            this.gbCounter.Controls.Add(this.sbCounter);
            this.gbCounter.Controls.Add(this.label6);
            this.gbCounter.Controls.Add(this.label3);
            this.gbCounter.Controls.Add(this.lbCounterDisplay);
            this.gbCounter.Controls.Add(this.btnPauseCounter);
            this.gbCounter.Controls.Add(this.btnPlayCounter);
            this.gbCounter.Controls.Add(this.btnResetCounter);
            this.gbCounter.Controls.Add(this.label2);
            this.gbCounter.Location = new System.Drawing.Point(12, 198);
            this.gbCounter.Name = "gbCounter";
            this.gbCounter.Size = new System.Drawing.Size(200, 150);
            this.gbCounter.TabIndex = 2;
            this.gbCounter.TabStop = false;
            this.gbCounter.Text = "Counter";
            // 
            // sbCounter
            // 
            this.sbCounter.LargeChange = 1;
            this.sbCounter.Location = new System.Drawing.Point(5, 20);
            this.sbCounter.Maximum = 255;
            this.sbCounter.Minimum = 1;
            this.sbCounter.Name = "sbCounter";
            this.sbCounter.Size = new System.Drawing.Size(192, 17);
            this.sbCounter.TabIndex = 15;
            this.sbCounter.Value = 1;
            this.sbCounter.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbCounter_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Interval (ms):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "2550 ms";
            // 
            // lbCounterDisplay
            // 
            this.lbCounterDisplay.AutoSize = true;
            this.lbCounterDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCounterDisplay.Location = new System.Drawing.Point(86, 64);
            this.lbCounterDisplay.Name = "lbCounterDisplay";
            this.lbCounterDisplay.Size = new System.Drawing.Size(21, 15);
            this.lbCounterDisplay.TabIndex = 12;
            this.lbCounterDisplay.Text = "10";
            // 
            // btnPauseCounter
            // 
            this.btnPauseCounter.Location = new System.Drawing.Point(142, 107);
            this.btnPauseCounter.Name = "btnPauseCounter";
            this.btnPauseCounter.Size = new System.Drawing.Size(53, 23);
            this.btnPauseCounter.TabIndex = 9;
            this.btnPauseCounter.Text = "Pa&use";
            this.btnPauseCounter.UseVisualStyleBackColor = true;
            this.btnPauseCounter.Click += new System.EventHandler(this.btnPauseCounter_Click);
            // 
            // btnPlayCounter
            // 
            this.btnPlayCounter.Location = new System.Drawing.Point(76, 107);
            this.btnPlayCounter.Name = "btnPlayCounter";
            this.btnPlayCounter.Size = new System.Drawing.Size(53, 23);
            this.btnPlayCounter.TabIndex = 8;
            this.btnPlayCounter.Text = "&Play";
            this.btnPlayCounter.UseVisualStyleBackColor = true;
            this.btnPlayCounter.Click += new System.EventHandler(this.btnPlayCounter_Click);
            // 
            // btnResetCounter
            // 
            this.btnResetCounter.Location = new System.Drawing.Point(5, 107);
            this.btnResetCounter.Name = "btnResetCounter";
            this.btnResetCounter.Size = new System.Drawing.Size(54, 23);
            this.btnResetCounter.TabIndex = 7;
            this.btnResetCounter.Text = "&Reset";
            this.btnResetCounter.UseVisualStyleBackColor = true;
            this.btnResetCounter.Click += new System.EventHandler(this.btnResetCounter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "10 ms";
            // 
            // gbDigitalDataSent
            // 
            this.gbDigitalDataSent.Controls.Add(this.label14);
            this.gbDigitalDataSent.Controls.Add(this.label13);
            this.gbDigitalDataSent.Controls.Add(this.label12);
            this.gbDigitalDataSent.Controls.Add(this.label11);
            this.gbDigitalDataSent.Controls.Add(this.label10);
            this.gbDigitalDataSent.Controls.Add(this.label9);
            this.gbDigitalDataSent.Controls.Add(this.label8);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay1);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay0);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay2);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay3);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay4);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay5);
            this.gbDigitalDataSent.Controls.Add(this.btnDisplay6);
            this.gbDigitalDataSent.Location = new System.Drawing.Point(218, 12);
            this.gbDigitalDataSent.Name = "gbDigitalDataSent";
            this.gbDigitalDataSent.Size = new System.Drawing.Size(200, 69);
            this.gbDigitalDataSent.TabIndex = 2;
            this.gbDigitalDataSent.TabStop = false;
            this.gbDigitalDataSent.Text = "Digital data sent";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(142, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "5";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "6";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisplay1
            // 
            this.btnDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay1.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay1.Enabled = false;
            this.btnDisplay1.Location = new System.Drawing.Point(139, 21);
            this.btnDisplay1.Name = "btnDisplay1";
            this.btnDisplay1.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay1.TabIndex = 20;
            this.btnDisplay1.UseVisualStyleBackColor = false;
            // 
            // btnDisplay0
            // 
            this.btnDisplay0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay0.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay0.Enabled = false;
            this.btnDisplay0.Location = new System.Drawing.Point(163, 21);
            this.btnDisplay0.Name = "btnDisplay0";
            this.btnDisplay0.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay0.TabIndex = 19;
            this.btnDisplay0.UseVisualStyleBackColor = false;
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay2.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay2.Enabled = false;
            this.btnDisplay2.Location = new System.Drawing.Point(115, 21);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay2.TabIndex = 18;
            this.btnDisplay2.UseVisualStyleBackColor = false;
            // 
            // btnDisplay3
            // 
            this.btnDisplay3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay3.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay3.Enabled = false;
            this.btnDisplay3.Location = new System.Drawing.Point(91, 21);
            this.btnDisplay3.Name = "btnDisplay3";
            this.btnDisplay3.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay3.TabIndex = 17;
            this.btnDisplay3.UseVisualStyleBackColor = false;
            // 
            // btnDisplay4
            // 
            this.btnDisplay4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay4.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay4.Enabled = false;
            this.btnDisplay4.Location = new System.Drawing.Point(67, 21);
            this.btnDisplay4.Name = "btnDisplay4";
            this.btnDisplay4.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay4.TabIndex = 16;
            this.btnDisplay4.UseVisualStyleBackColor = false;
            // 
            // btnDisplay5
            // 
            this.btnDisplay5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay5.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay5.Enabled = false;
            this.btnDisplay5.Location = new System.Drawing.Point(43, 21);
            this.btnDisplay5.Name = "btnDisplay5";
            this.btnDisplay5.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay5.TabIndex = 15;
            this.btnDisplay5.UseVisualStyleBackColor = false;
            // 
            // btnDisplay6
            // 
            this.btnDisplay6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay6.BackColor = System.Drawing.Color.Blue;
            this.btnDisplay6.Enabled = false;
            this.btnDisplay6.Location = new System.Drawing.Point(19, 21);
            this.btnDisplay6.Name = "btnDisplay6";
            this.btnDisplay6.Size = new System.Drawing.Size(18, 18);
            this.btnDisplay6.TabIndex = 14;
            this.btnDisplay6.UseVisualStyleBackColor = false;
            // 
            // gbDataSent
            // 
            this.gbDataSent.Controls.Add(this.lbDataSentDisplay);
            this.gbDataSent.Controls.Add(this.pbDataSentDisplay);
            this.gbDataSent.Location = new System.Drawing.Point(218, 87);
            this.gbDataSent.Name = "gbDataSent";
            this.gbDataSent.Size = new System.Drawing.Size(200, 56);
            this.gbDataSent.TabIndex = 3;
            this.gbDataSent.TabStop = false;
            this.gbDataSent.Text = "Data Sent";
            // 
            // lbDataSentDisplay
            // 
            this.lbDataSentDisplay.BackColor = System.Drawing.Color.Black;
            this.lbDataSentDisplay.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataSentDisplay.ForeColor = System.Drawing.Color.Lime;
            this.lbDataSentDisplay.Location = new System.Drawing.Point(116, 19);
            this.lbDataSentDisplay.Name = "lbDataSentDisplay";
            this.lbDataSentDisplay.Padding = new System.Windows.Forms.Padding(1);
            this.lbDataSentDisplay.Size = new System.Drawing.Size(73, 23);
            this.lbDataSentDisplay.TabIndex = 15;
            this.lbDataSentDisplay.Text = "000";
            this.lbDataSentDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDataSentDisplay
            // 
            this.pbDataSentDisplay.Location = new System.Drawing.Point(6, 19);
            this.pbDataSentDisplay.Maximum = 127;
            this.pbDataSentDisplay.Name = "pbDataSentDisplay";
            this.pbDataSentDisplay.Size = new System.Drawing.Size(100, 23);
            this.pbDataSentDisplay.TabIndex = 0;
            // 
            // gpSerialPortSettings
            // 
            this.gpSerialPortSettings.Controls.Add(this.cbPortsList);
            this.gpSerialPortSettings.Controls.Add(this.btnConnect);
            this.gpSerialPortSettings.Controls.Add(this.btnScanPorts);
            this.gpSerialPortSettings.Location = new System.Drawing.Point(218, 149);
            this.gpSerialPortSettings.Name = "gpSerialPortSettings";
            this.gpSerialPortSettings.Size = new System.Drawing.Size(200, 88);
            this.gpSerialPortSettings.TabIndex = 3;
            this.gpSerialPortSettings.TabStop = false;
            this.gpSerialPortSettings.Text = "Serial port settings";
            // 
            // cbPortsList
            // 
            this.cbPortsList.FormattingEnabled = true;
            this.cbPortsList.Location = new System.Drawing.Point(92, 26);
            this.cbPortsList.Name = "cbPortsList";
            this.cbPortsList.Size = new System.Drawing.Size(102, 21);
            this.cbPortsList.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(63, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connec&t";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnScanPorts
            // 
            this.btnScanPorts.Location = new System.Drawing.Point(6, 24);
            this.btnScanPorts.Name = "btnScanPorts";
            this.btnScanPorts.Size = new System.Drawing.Size(75, 23);
            this.btnScanPorts.TabIndex = 11;
            this.btnScanPorts.Text = "Scan &ports";
            this.btnScanPorts.UseVisualStyleBackColor = true;
            this.btnScanPorts.Click += new System.EventHandler(this.btnScanPorts_Click);
            // 
            // gbSendingOptions
            // 
            this.gbSendingOptions.Controls.Add(this.rbCounter);
            this.gbSendingOptions.Controls.Add(this.rbAnalog);
            this.gbSendingOptions.Controls.Add(this.rbDigital);
            this.gbSendingOptions.Location = new System.Drawing.Point(218, 243);
            this.gbSendingOptions.Name = "gbSendingOptions";
            this.gbSendingOptions.Size = new System.Drawing.Size(200, 53);
            this.gbSendingOptions.TabIndex = 4;
            this.gbSendingOptions.TabStop = false;
            this.gbSendingOptions.Text = "Sending options";
            // 
            // rbCounter
            // 
            this.rbCounter.AutoSize = true;
            this.rbCounter.Location = new System.Drawing.Point(127, 21);
            this.rbCounter.Name = "rbCounter";
            this.rbCounter.Size = new System.Drawing.Size(62, 17);
            this.rbCounter.TabIndex = 2;
            this.rbCounter.Text = "Coun&ter";
            this.rbCounter.UseVisualStyleBackColor = true;
            this.rbCounter.CheckedChanged += new System.EventHandler(this.btOpDiAnCo_CheckedChanged);
            // 
            // rbAnalog
            // 
            this.rbAnalog.AutoSize = true;
            this.rbAnalog.Location = new System.Drawing.Point(64, 21);
            this.rbAnalog.Name = "rbAnalog";
            this.rbAnalog.Size = new System.Drawing.Size(58, 17);
            this.rbAnalog.TabIndex = 1;
            this.rbAnalog.Text = "&Analog";
            this.rbAnalog.UseVisualStyleBackColor = true;
            this.rbAnalog.CheckedChanged += new System.EventHandler(this.btOpDiAnCo_CheckedChanged);
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Checked = true;
            this.rbDigital.Location = new System.Drawing.Point(7, 21);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(51, 17);
            this.rbDigital.TabIndex = 0;
            this.rbDigital.TabStop = true;
            this.rbDigital.Text = "&Digial";
            this.rbDigital.UseVisualStyleBackColor = true;
            this.rbDigital.CheckedChanged += new System.EventHandler(this.btOpDiAnCo_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(224, 305);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "S&end";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tecnologico de Monterrey, Puebla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Alan Suarez, Fernando Lopez, Kaleb Antonio";
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 10;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbSendingOptions);
            this.Controls.Add(this.gpSerialPortSettings);
            this.Controls.Add(this.gbDataSent);
            this.Controls.Add(this.gbDigitalDataSent);
            this.Controls.Add(this.gbCounter);
            this.Controls.Add(this.gbAnalogData);
            this.Controls.Add(this.gbDigitalData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial port controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDigitalData.ResumeLayout(false);
            this.gbDigitalData.PerformLayout();
            this.gbAnalogData.ResumeLayout(false);
            this.gbAnalogData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnalogData)).EndInit();
            this.gbCounter.ResumeLayout(false);
            this.gbCounter.PerformLayout();
            this.gbDigitalDataSent.ResumeLayout(false);
            this.gbDigitalDataSent.PerformLayout();
            this.gbDataSent.ResumeLayout(false);
            this.gpSerialPortSettings.ResumeLayout(false);
            this.gbSendingOptions.ResumeLayout(false);
            this.gbSendingOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDigitalData;
        private System.Windows.Forms.GroupBox gbAnalogData;
        private System.Windows.Forms.GroupBox gbCounter;
        private System.Windows.Forms.GroupBox gbDigitalDataSent;
        private System.Windows.Forms.GroupBox gbDataSent;
        private System.Windows.Forms.GroupBox gpSerialPortSettings;
        private System.Windows.Forms.GroupBox gbSendingOptions;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbAnalogDataDisplay;
        private System.Windows.Forms.TrackBar tbAnalogData;
        private System.Windows.Forms.Button btnPauseCounter;
        private System.Windows.Forms.Button btnPlayCounter;
        private System.Windows.Forms.Button btnResetCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbDigitalData0;
        private System.Windows.Forms.CheckBox cbDigitalData6;
        private System.Windows.Forms.CheckBox cbDigitalData5;
        private System.Windows.Forms.CheckBox cbDigitalData4;
        private System.Windows.Forms.CheckBox cbDigitalData3;
        private System.Windows.Forms.CheckBox cbDigitalData2;
        private System.Windows.Forms.CheckBox cbDigitalData1;
        private System.Windows.Forms.Button btnSetAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCounterDisplay;
        private System.Windows.Forms.ProgressBar pbDataSentDisplay;
        private System.Windows.Forms.Label lbDataSentDisplay;
        private System.Windows.Forms.ComboBox cbPortsList;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnScanPorts;
        private System.Windows.Forms.RadioButton rbCounter;
        private System.Windows.Forms.RadioButton rbAnalog;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDisplay6;
        private System.Windows.Forms.Button btnDisplay1;
        private System.Windows.Forms.Button btnDisplay0;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.Button btnDisplay3;
        private System.Windows.Forms.Button btnDisplay4;
        private System.Windows.Forms.Button btnDisplay5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.IO.Ports.SerialPort spSerialPort;
        private System.Windows.Forms.HScrollBar sbCounter;
        private System.Windows.Forms.Timer tmrCounter;
    }
}

