using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProcductos
{
    public partial class frmProductos : Form
    {
        List<string> categorias;

        public frmProductos()
        {
           InitializeComponent();
            categorias = new List<string>();
            categorias.Add("Mercado");
            categorias.Add("Papeleria");
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.Rows.Add("A001", "Lapiz", "700", "Papeleria");
            dgvProductos.Rows.Add("A002", "Borrador de nata", "1200", "Psdfapeleria");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoProducto ventana = new frmNuevoProducto(categorias, dgvProductos);
            //abrir un formulario como un modal(única ventana activa)
            ventana.ShowDialog();
        }
    }
}
