namespace ModbusMasterInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInputStatus = new System.Windows.Forms.Label();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInputRegister = new System.Windows.Forms.Label();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Status:";
            // 
            // lblInputStatus
            // 
            this.lblInputStatus.AutoSize = true;
            this.lblInputStatus.Location = new System.Drawing.Point(184, 51);
            this.lblInputStatus.Name = "lblInputStatus";
            this.lblInputStatus.Size = new System.Drawing.Size(27, 13);
            this.lblInputStatus.TabIndex = 1;
            this.lblInputStatus.Text = "OFF";
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(313, 46);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(134, 23);
            this.btnReadInput.TabIndex = 2;
            this.btnReadInput.Text = "Read Discrete Input";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Register:";
            // 
            // lblInputRegister
            // 
            this.lblInputRegister.AutoSize = true;
            this.lblInputRegister.Location = new System.Drawing.Point(184, 119);
            this.lblInputRegister.Name = "lblInputRegister";
            this.lblInputRegister.Size = new System.Drawing.Size(13, 13);
            this.lblInputRegister.TabIndex = 4;
            this.lblInputRegister.Text = "0";
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Location = new System.Drawing.Point(313, 114);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(134, 23);
            this.btnReadRegister.TabIndex = 5;
            this.btnReadRegister.Text = "Read Register Input";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 364);
            this.Controls.Add(this.btnReadRegister);
            this.Controls.Add(this.lblInputRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReadInput);
            this.Controls.Add(this.lblInputStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputStatus;
        private System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInputRegister;
        private System.Windows.Forms.Button btnReadRegister;
    }
}

