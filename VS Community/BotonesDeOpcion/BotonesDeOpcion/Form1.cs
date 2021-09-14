using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonesDeOpcion
{
    public partial class Form1 : Form
    {

        private int numeroActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctDato_TextChanged(object sender, EventArgs e)
        {
            if (ctDato.Text.Length == 0) return;

            string texto = ctDato.Text;
            int baseNum = 0;

            if (bnOpDecimal.Checked)
                baseNum = 10;
            else if (bnOpOctal.Checked)
                baseNum = 8;
            else if (bnOpHex.Checked)
                baseNum = 16;

            try
            {
                numeroActual = Convert.ToInt32(texto, baseNum);
            }
            catch (FormatException ex)
            {
                if (texto == "-" || texto == "+") return;
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btOpCecOctHex_CheckedChanged(object sender, EventArgs e)
        {
            if (bnOpDecimal.Checked)
                ctDato.Text = Convert.ToString(numeroActual, 10);
            else if (bnOpOctal.Checked)
                ctDato.Text = Convert.ToString(numeroActual, 8);
            else if (bnOpHex.Checked)
                ctDato.Text = Convert.ToString(numeroActual, 16).ToUpper();
            ctDato.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
