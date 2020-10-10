using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorDeCambios
{
    public partial class FormCot : Form
    {
        public FormCot()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double money, change;
            money = Convert.ToDouble(tbxLocal.Text);
            if (rbMXNtoUSD.Checked)
            {
                change = money / 21.13;
                tbxExtranjera.Text = change.ToString();
            } else if (rbUSDtoMXN.Checked)
            {
                change = money * 21.13;
                tbxExtranjera.Text = change.ToString();
            }
        }

        private void tbxLocal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxLocal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbxLocal.Text = tbxLocal.Text.Remove(tbxLocal.Text.Length - 1);
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraBasica.FormC frmCotador = new CalculadoraBasica.FormC();
            frmCotador.Show();
        }
    }
}
