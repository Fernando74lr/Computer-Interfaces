namespace SerialPortTXRXbytes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbValueToSend = new System.Windows.Forms.TextBox();
            this.tbReceivedValue = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbValueByte1 = new System.Windows.Forms.Label();
            this.lbValueByte2 = new System.Windows.Forms.Label();
            this.lbValueByte4 = new System.Windows.Forms.Label();
            this.lbValueByte3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(148, 17);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 0;
            this.tbPort.Text = "COM60";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbValueToSend
            // 
            this.tbValueToSend.Enabled = false;
            this.tbValueToSend.Location = new System.Drawing.Point(148, 96);
            this.tbValueToSend.Name = "tbValueToSend";
            this.tbValueToSend.Size = new System.Drawing.Size(100, 20);
            this.tbValueToSend.TabIndex = 1;
            this.tbValueToSend.Text = "0";
            this.tbValueToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbReceivedValue
            // 
            this.tbReceivedValue.Enabled = false;
            this.tbReceivedValue.Location = new System.Drawing.Point(148, 179);
            this.tbReceivedValue.Name = "tbReceivedValue";
            this.tbReceivedValue.Size = new System.Drawing.Size(100, 20);
            this.tbReceivedValue.TabIndex = 2;
            this.tbReceivedValue.Text = "0";
            this.tbReceivedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(148, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(148, 122);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Value to send;:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Received Value";
            // 
            // spSerialPort
            // 
            this.spSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spSerialPort_DataReceived);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(289, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(138, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(289, 145);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(138, 23);
            this.progressBar3.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(289, 90);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(138, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(289, 202);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(138, 23);
            this.progressBar4.TabIndex = 12;
            this.progressBar4.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Byte 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Byte 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Byte 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Byte 4";
            // 
            // lbValueByte1
            // 
            this.lbValueByte1.AutoSize = true;
            this.lbValueByte1.BackColor = System.Drawing.Color.Transparent;
            this.lbValueByte1.Location = new System.Drawing.Point(350, 40);
            this.lbValueByte1.Name = "lbValueByte1";
            this.lbValueByte1.Size = new System.Drawing.Size(13, 13);
            this.lbValueByte1.TabIndex = 17;
            this.lbValueByte1.Text = "0";
            // 
            // lbValueByte2
            // 
            this.lbValueByte2.AutoSize = true;
            this.lbValueByte2.BackColor = System.Drawing.Color.Transparent;
            this.lbValueByte2.Location = new System.Drawing.Point(350, 95);
            this.lbValueByte2.Name = "lbValueByte2";
            this.lbValueByte2.Size = new System.Drawing.Size(13, 13);
            this.lbValueByte2.TabIndex = 18;
            this.lbValueByte2.Text = "0";
            // 
            // lbValueByte4
            // 
            this.lbValueByte4.AutoSize = true;
            this.lbValueByte4.BackColor = System.Drawing.Color.Transparent;
            this.lbValueByte4.Location = new System.Drawing.Point(350, 207);
            this.lbValueByte4.Name = "lbValueByte4";
            this.lbValueByte4.Size = new System.Drawing.Size(13, 13);
            this.lbValueByte4.TabIndex = 20;
            this.lbValueByte4.Text = "0";
            // 
            // lbValueByte3
            // 
            this.lbValueByte3.AutoSize = true;
            this.lbValueByte3.BackColor = System.Drawing.Color.Transparent;
            this.lbValueByte3.Location = new System.Drawing.Point(350, 149);
            this.lbValueByte3.Name = "lbValueByte3";
            this.lbValueByte3.Size = new System.Drawing.Size(13, 13);
            this.lbValueByte3.TabIndex = 19;
            this.lbValueByte3.Text = "0";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 237);
            this.Controls.Add(this.lbValueByte4);
            this.Controls.Add(this.lbValueByte3);
            this.Controls.Add(this.lbValueByte2);
            this.Controls.Add(this.lbValueByte1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbReceivedValue);
            this.Controls.Add(this.tbValueToSend);
            this.Controls.Add(this.tbPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port TX/RX (bytes)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbValueToSend;
        private System.Windows.Forms.TextBox tbReceivedValue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort spSerialPort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbValueByte1;
        private System.Windows.Forms.Label lbValueByte2;
        private System.Windows.Forms.Label lbValueByte4;
        private System.Windows.Forms.Label lbValueByte3;
    }
}

