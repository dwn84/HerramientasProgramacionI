using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPracticos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtPedidos.Text == "") || (txtExistentes.Text == ""))
            {
                MessageBox.Show("Faltan datos...");
            }
            else
            {
                /*si los valores correspondientes de las listas A y B son iguales se almacena este mismo valor
                  si el valor de B es mayor que el de A se almacena el doble de la diferencia entre B y A
                  si se da el caso de que A es mayor que B, se almacena B, que indica lo que se requiere comprar para mantener el stock de inventario. 
                */

                int A = Convert.ToInt32(txtExistentes.Text);
                int B = Convert.ToInt32(txtPedidos.Text);

                lstExistentes.Items.Add(A);
                lstPedidos.Items.Add(B);

                if (A == B)
                {
                    lstComprar.Items.Add(A);
                }
                else if (B > A)
                {
                    int C = (B - A) * 2;
                    lstComprar.Items.Add(C);
                }
                else
                {
                    lstComprar.Items.Add(B);

                }
            }
        }
    }
}
