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
            this.SuspendLayout();
            // 
            // etGradosC
            // 
            this.etGradosC.AutoSize = true;
            this.etGradosC.Location = new System.Drawing.Point(12, 51);
            this.etGradosC.Name = "etGradosC";
            this.etGradosC.Size = new System.Drawing.Size(104, 13);
            this.etGradosC.TabIndex = 3;
            this.etGradosC.Text = "Grados centígrados:";
            // 
            // etGradosF
            // 
            this.etGradosF.AutoSize = true;
            this.etGradosF.Location = new System.Drawing.Point(12, 103);
            this.etGradosF.Name = "etGradosF";
            this.etGradosF.Size = new System.Drawing.Size(97, 13);
            this.etGradosF.TabIndex = 4;
            this.etGradosF.Text = "Grados Fahrenheit:";
            // 
            // ctGradosC
            // 
            this.ctGradosC.Location = new System.Drawing.Point(122, 48);
            this.ctGradosC.Name = "ctGradosC";
            this.ctGradosC.Size = new System.Drawing.Size(170, 20);
            this.ctGradosC.TabIndex = 0;
            this.ctGradosC.Text = "0.0";
            this.ctGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
            this.ctGradosC.Enter += new System.EventHandler(this.CajaTexto_Enter);
            this.ctGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
            // 
            // ctGradosF
            // 
            this.ctGradosF.Location = new System.Drawing.Point(122, 100);
            this.ctGradosF.Name = "ctGradosF";
            this.ctGradosF.Size = new System.Drawing.Size(170, 20);
            this.ctGradosF.TabIndex = 1;
            this.ctGradosF.Text = "32.0";
            this.ctGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
            this.ctGradosF.Enter += new System.EventHandler(this.CajaTexto_Enter);
            this.ctGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
            // 
            // converterTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
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
    }
}

