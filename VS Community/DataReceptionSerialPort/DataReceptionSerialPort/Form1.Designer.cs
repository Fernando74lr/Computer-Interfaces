namespace DataReceptionSerialPort
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbTX = new System.Windows.Forms.RichTextBox();
            this.tbRX = new System.Windows.Forms.RichTextBox();
            this.cbIM = new System.Windows.Forms.CheckBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(522, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbTX
            // 
            this.tbTX.Location = new System.Drawing.Point(13, 13);
            this.tbTX.Name = "tbTX";
            this.tbTX.Size = new System.Drawing.Size(503, 46);
            this.tbTX.TabIndex = 2;
            this.tbTX.Text = "";
            this.tbTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTX_KeyPress);
            // 
            // tbRX
            // 
            this.tbRX.Location = new System.Drawing.Point(12, 65);
            this.tbRX.Name = "tbRX";
            this.tbRX.Size = new System.Drawing.Size(504, 169);
            this.tbRX.TabIndex = 3;
            this.tbRX.Text = "";
            // 
            // cbIM
            // 
            this.cbIM.AutoSize = true;
            this.cbIM.Location = new System.Drawing.Point(522, 42);
            this.cbIM.Name = "cbIM";
            this.cbIM.Size = new System.Drawing.Size(38, 17);
            this.cbIM.TabIndex = 4;
            this.cbIM.Text = "IM";
            this.cbIM.UseVisualStyleBackColor = true;
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM6";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 246);
            this.Controls.Add(this.cbIM);
            this.Controls.Add(this.tbRX);
            this.Controls.Add(this.tbTX);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox tbTX;
        private System.Windows.Forms.RichTextBox tbRX;
        private System.Windows.Forms.CheckBox cbIM;
        private System.IO.Ports.SerialPort serialPort;
    }
}

