namespace BotonesDeOpcion
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
            this.ctDato = new System.Windows.Forms.TextBox();
            this.gbGrupoBotones1 = new System.Windows.Forms.GroupBox();
            this.bnOpDecimal = new System.Windows.Forms.RadioButton();
            this.bnOpOctal = new System.Windows.Forms.RadioButton();
            this.bnOpHex = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbGrupoBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctDato
            // 
            this.ctDato.Location = new System.Drawing.Point(30, 23);
            this.ctDato.Name = "ctDato";
            this.ctDato.Size = new System.Drawing.Size(204, 20);
            this.ctDato.TabIndex = 0;
            this.ctDato.TextChanged += new System.EventHandler(this.ctDato_TextChanged);
            // 
            // gbGrupoBotones1
            // 
            this.gbGrupoBotones1.Controls.Add(this.bnOpHex);
            this.gbGrupoBotones1.Controls.Add(this.bnOpOctal);
            this.gbGrupoBotones1.Controls.Add(this.bnOpDecimal);
            this.gbGrupoBotones1.Location = new System.Drawing.Point(30, 49);
            this.gbGrupoBotones1.Name = "gbGrupoBotones1";
            this.gbGrupoBotones1.Size = new System.Drawing.Size(200, 100);
            this.gbGrupoBotones1.TabIndex = 1;
            this.gbGrupoBotones1.TabStop = false;
            this.gbGrupoBotones1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bnOpDecimal
            // 
            this.bnOpDecimal.AutoSize = true;
            this.bnOpDecimal.Checked = true;
            this.bnOpDecimal.Location = new System.Drawing.Point(15, 19);
            this.bnOpDecimal.Name = "bnOpDecimal";
            this.bnOpDecimal.Size = new System.Drawing.Size(63, 17);
            this.bnOpDecimal.TabIndex = 0;
            this.bnOpDecimal.TabStop = true;
            this.bnOpDecimal.Text = "&Decimal";
            this.bnOpDecimal.UseVisualStyleBackColor = true;
            this.bnOpDecimal.CheckedChanged += new System.EventHandler(this.btOpCecOctHex_CheckedChanged);
            // 
            // bnOpOctal
            // 
            this.bnOpOctal.AutoSize = true;
            this.bnOpOctal.Location = new System.Drawing.Point(15, 43);
            this.bnOpOctal.Name = "bnOpOctal";
            this.bnOpOctal.Size = new System.Drawing.Size(50, 17);
            this.bnOpOctal.TabIndex = 1;
            this.bnOpOctal.TabStop = true;
            this.bnOpOctal.Text = "&Octal";
            this.bnOpOctal.UseVisualStyleBackColor = true;
            this.bnOpOctal.CheckedChanged += new System.EventHandler(this.btOpCecOctHex_CheckedChanged);
            // 
            // bnOpHex
            // 
            this.bnOpHex.AutoSize = true;
            this.bnOpHex.Location = new System.Drawing.Point(15, 67);
            this.bnOpHex.Name = "bnOpHex";
            this.bnOpHex.Size = new System.Drawing.Size(86, 17);
            this.bnOpHex.TabIndex = 2;
            this.bnOpHex.TabStop = true;
            this.bnOpHex.Text = "&Hexadecimal";
            this.bnOpHex.UseVisualStyleBackColor = true;
            this.bnOpHex.CheckedChanged += new System.EventHandler(this.btOpCecOctHex_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(155, 155);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Salir";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 191);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbGrupoBotones1);
            this.Controls.Add(this.ctDato);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGrupoBotones1.ResumeLayout(false);
            this.gbGrupoBotones1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctDato;
        private System.Windows.Forms.GroupBox gbGrupoBotones1;
        private System.Windows.Forms.RadioButton bnOpDecimal;
        private System.Windows.Forms.RadioButton bnOpHex;
        private System.Windows.Forms.RadioButton bnOpOctal;
        private System.Windows.Forms.Button btnAceptar;
    }
}

