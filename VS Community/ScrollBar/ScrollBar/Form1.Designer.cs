namespace ScrollBar
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
            this.bdhIntervalio = new System.Windows.Forms.HScrollBar();
            this.ctContador = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bdhIntervalio
            // 
            this.bdhIntervalio.Location = new System.Drawing.Point(40, 40);
            this.bdhIntervalio.Maximum = 150;
            this.bdhIntervalio.Minimum = 1;
            this.bdhIntervalio.Name = "bdhIntervalio";
            this.bdhIntervalio.Size = new System.Drawing.Size(214, 20);
            this.bdhIntervalio.TabIndex = 0;
            this.bdhIntervalio.Value = 76;
            // 
            // ctContador
            // 
            this.ctContador.AutoSize = true;
            this.ctContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctContador.Location = new System.Drawing.Point(136, 104);
            this.ctContador.Name = "ctContador";
            this.ctContador.Size = new System.Drawing.Size(15, 15);
            this.ctContador.TabIndex = 1;
            this.ctContador.Text = "0";
            this.ctContador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ctContador.Click += new System.EventHandler(this.ctContador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.ctContador);
            this.Controls.Add(this.bdhIntervalio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar bdhIntervalio;
        private System.Windows.Forms.Label ctContador;
        private System.Windows.Forms.Timer Temporizador;
    }
}

