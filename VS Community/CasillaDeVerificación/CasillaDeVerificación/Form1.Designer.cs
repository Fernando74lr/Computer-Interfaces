namespace CasillaDeVerificación
{
    partial class DlgCasillaVerificacion
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
            this.ctTexto = new System.Windows.Forms.TextBox();
            this.cvConverMayus = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctTexto
            // 
            this.ctTexto.Location = new System.Drawing.Point(37, 33);
            this.ctTexto.Name = "ctTexto";
            this.ctTexto.Size = new System.Drawing.Size(223, 20);
            this.ctTexto.TabIndex = 0;
            this.ctTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctTexto_KeyPress);
            // 
            // cvConverMayus
            // 
            this.cvConverMayus.AutoSize = true;
            this.cvConverMayus.Location = new System.Drawing.Point(37, 71);
            this.cvConverMayus.Name = "cvConverMayus";
            this.cvConverMayus.Size = new System.Drawing.Size(135, 17);
            this.cvConverMayus.TabIndex = 1;
            this.cvConverMayus.Text = "&Convertir a mayúsculas";
            this.cvConverMayus.UseVisualStyleBackColor = true;
            this.cvConverMayus.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.cvConverMayus.Click += new System.EventHandler(this.cvConverMayus_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(184, 114);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // DlgCasillaVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cvConverMayus);
            this.Controls.Add(this.ctTexto);
            this.Name = "DlgCasillaVerificacion";
            this.Text = "Casilla de Verificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctTexto;
        private System.Windows.Forms.CheckBox cvConverMayus;
        private System.Windows.Forms.Button btAceptar;
    }
}

