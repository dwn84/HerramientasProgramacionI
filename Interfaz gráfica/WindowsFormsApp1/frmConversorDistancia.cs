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
    public partial class frmConversorDistancia : Form
    {
        public frmConversorDistancia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double millas = Convert.ToDouble(txtMillas.Text);
            double metros = millas* 1609.34;
            lblMetros.Text = metros.ToString();
        }
    }
}
