namespace SerialPortTX
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
            this.btnSearchPorts = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtDataTX = new System.Windows.Forms.TextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSearchPorts
            // 
            this.btnSearchPorts.Location = new System.Drawing.Point(38, 28);
            this.btnSearchPorts.Name = "btnSearchPorts";
            this.btnSearchPorts.Size = new System.Drawing.Size(90, 23);
            this.btnSearchPorts.TabIndex = 0;
            this.btnSearchPorts.Text = "Buscar puertos";
            this.btnSearchPorts.UseVisualStyleBackColor = true;
            this.btnSearchPorts.Click += new System.EventHandler(this.btnSearchPorts_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(345, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(38, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(359, 233);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "&Salir";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtDataTX
            // 
            this.txtDataTX.Location = new System.Drawing.Point(119, 183);
            this.txtDataTX.Name = "txtDataTX";
            this.txtDataTX.Size = new System.Drawing.Size(315, 20);
            this.txtDataTX.TabIndex = 4;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(134, 28);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Baud Rate";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "4800",
            "9600",
            "28800",
            "38400",
            "57600"});
            this.cboBaudrate.Location = new System.Drawing.Point(134, 58);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudrate.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(359, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 278);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cboBaudrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.txtDataTX);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSearchPorts);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Puerto Serie TX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtDataTX;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort spSerialPort;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

