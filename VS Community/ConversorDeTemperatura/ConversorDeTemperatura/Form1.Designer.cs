namespace ConversorDeTemperatura
{
    partial class converterTemp
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
            this.etGradosC = new System.Windows.Forms.Label();
            this.etGradosF = new System.Windows.Forms.Label();
            this.ctGradosC = new System.Windows.Forms.TextBox();
            this.ctGradosF = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etGradosC
            // 
            this.etGradosC.AutoSize = true;
            this.etGradosC.Location = new System.Drawing.Point(12, 33);
            this.etGradosC.Name = "etGradosC";
            this.etGradosC.Size = new System.Drawing.Size(104, 13);
            this.etGradosC.TabIndex = 3;
            this.etGradosC.Text = "Grados centígrados:";
            // 
            // etGradosF
            // 
            this.etGradosF.AutoSize = true;
            this.etGradosF.Location = new System.Drawing.Point(12, 76);
            this.etGradosF.Name = "etGradosF";
            this.etGradosF.Size = new System.Drawing.Size(97, 13);
            this.etGradosF.TabIndex = 4;
            this.etGradosF.Text = "Grados Fahrenheit:";
            // 
            // ctGradosC
            // 
            this.ctGradosC.Location = new System.Drawing.Point(122, 30);
            this.ctGradosC.Name = "ctGradosC";
            this.ctGradosC.Size = new System.Drawing.Size(170, 20);
            this.ctGradosC.TabIndex = 0;
            this.ctGradosC.Text = "0.0";
            this.ctGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
            this.ctGradosC.Enter += new System.EventHandler(this.CajaTexto_Enter);
            this.ctGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctGradosF_KeyPress);
            // 
            // ctGradosF
            // 
            this.ctGradosF.Location = new System.Drawing.Point(122, 73);
            this.ctGradosF.Name = "ctGradosF";
            this.ctGradosF.Size = new System.Drawing.Size(170, 20);
            this.ctGradosF.TabIndex = 1;
            this.ctGradosF.Text = "32.0";
            this.ctGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
            this.ctGradosF.Enter += new System.EventHandler(this.CajaTexto_Enter);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnConvertir.Location = new System.Drawing.Point(122, 113);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(170, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "&Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.UseWaitCursor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // converterTemp
            // 
            this.AcceptButton = this.btnConvertir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.ctGradosF);
            this.Controls.Add(this.ctGradosC);
            this.Controls.Add(this.etGradosF);
            this.Controls.Add(this.etGradosC);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 200);
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "converterTemp";
            this.Text = "Conversor de temperaturas";
            this.Load += new System.EventHandler(this.converterTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label etGradosC;
        private System.Windows.Forms.Label etGradosF;
        private System.Windows.Forms.TextBox ctGradosC;
        private System.Windows.Forms.TextBox ctGradosF;
        private System.Windows.Forms.Button btnConvertir;
    }
}

