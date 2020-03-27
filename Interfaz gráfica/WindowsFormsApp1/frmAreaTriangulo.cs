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
    public partial class frmAreaTriangulo : Form
    {
        public frmAreaTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(txtBase.Text);
            double a = Convert.ToDouble(txtAltura.Text);

            double area = (b * a) / 2;

            MessageBox.Show("El area del triangulo es: " + area);

            lblArea.Text = area.ToString();

        }
    }
}
