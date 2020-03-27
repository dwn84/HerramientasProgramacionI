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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void rdbNegro_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbNegro.Checked)
            {
                this.BackColor = Color.Black;
                gpbColores.ForeColor = Color.White;
            }

        }
        private void rdbFucsia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFucsia.Checked == true)
            {
                this.BackColor = Color.Fuchsia;
                gpbColores.ForeColor = Color.Black;
            }

        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void rdbRojo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRojo.Checked == true)
            {
                this.BackColor = Color.Red;
                gpbColores.ForeColor = Color.Black;
            }
        }

        private void rdbAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAzul.Checked == true)
            {
                this.BackColor = Color.Blue;
                gpbColores.ForeColor = Color.Black;
            }
        }
    }
}
