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
    public partial class frmImagen : Form
    {
        public frmImagen()
        {
            InitializeComponent();
        }

        private void rdbArriba_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbArriba.Checked == true) 
            {
                pictureBox1.Location = new Point(259, 0);
            }
        }

        private void rdbCentro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCentro.Checked == true)
            {
                pictureBox1.Location = new Point(259, 51);
            }
        }

        private void rdbAbajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAbajo.Checked == true)
            {
                pictureBox1.Location = new Point(259, 100);
            }
        }
    }
}
