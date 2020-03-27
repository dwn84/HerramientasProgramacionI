using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmVentaCafe : Form
    {
        public frmVentaCafe()
        {
            InitializeComponent();
        }

        private void frmVentaCafe_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dolar = Convert.ToDouble(txtValorDolar.Text);
            double valorMercado = Convert.ToDouble(txtValorMercado.Text);
            double kilos = Convert.ToDouble(txtKilos.Text);

            double pago = (kilos * valorMercado) / 125;
            pago = pago * dolar;

            lblTotal.Text = pago.ToString();
        }
    }
}
