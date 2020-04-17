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

        private int SumaTotalExistencias;
        private int SumaTotalPedido;
        private int SumaTotalCompras;

        public Form2()
        {
            InitializeComponent();
            SumaTotalExistencias = 0;
            SumaTotalPedido = 0;
            SumaTotalCompras = 0;
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
                int C;
                lstExistentes.Items.Add(A);
                lstPedidos.Items.Add(B);

                if (A == B)
                {
                    lstComprar.Items.Add(A);
                }
                else if (B > A)
                {
                    C = (B - A) * 2;
                    lstComprar.Items.Add(C);
                }
                else
                {
                    lstComprar.Items.Add(B);

                }


                C =Convert.ToInt32(lstComprar.Items[lstComprar.Items.Count-1].ToString());
                //calcular sumatorias

                SumaTotalExistencias += A;
                SumaTotalPedido += B;
                SumaTotalCompras += C ;
                lblSumaProductos.Text = SumaTotalExistencias.ToString();
                lblSumaPedidos.Text = SumaTotalPedido.ToString();
                lblSumaCompras.Text = SumaTotalCompras.ToString();
                //calcular promedios
                    //utilizando las variables existente
                double promProductos = Convert.ToDouble(SumaTotalExistencias) / lstComprar.Items.Count;
                lblPromProductos.Text = promProductos.ToString();
                //recorriendo todos los datos de la lista
                double s = 0;
                for (int i = 0; i < lstComprar.Items.Count; i++) {
                    //s += Convert.ToDouble(lstExistentes.Items[i].ToString());
                    s += Double.Parse(lstExistentes.Items[i].ToString());
                    //s += (double)lstExistentes.Items[i];
                }
                //MessageBox.Show("Promedio calculado"+(s / lstExistentes.Items.Count));

                s = 0;
                int x = 0;
                while (x < lstComprar.Items.Count) {
                    s += Double.Parse(lstPedidos.Items[x].ToString());
                    x++;
                }
                lblPromPedidos.Text = (s / lstPedidos.Items.Count).ToString();

                //el foreach se utiliza para leer datos de una colección: array-list
                s = 0;
                foreach(var elemento in lstComprar.Items) 
                {
                    s += Double.Parse(elemento.ToString());
                }
                lblPromCompras.Text = (s / lstComprar.Items.Count).ToString();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstComprar.SelectedIndex == -1)
            {
                MessageBox.Show("No existe un elemento seleccionado...");
            }
            else 
            {
                //actualizar las sumatorias y los promedios
                SumaTotalCompras -= Convert.ToInt32(lstComprar.Items[lstComprar.SelectedIndex].ToString());
                lblSumaCompras.Text = SumaTotalCompras.ToString();
                SumaTotalExistencias -= Convert.ToInt32(lstExistentes.Items[lstComprar.SelectedIndex].ToString());
                MessageBox.Show("variable:" + SumaTotalExistencias);
                lblSumaProductos.Text = SumaTotalExistencias.ToString();
                SumaTotalPedido -= Convert.ToInt32(lstPedidos.Items[lstComprar.SelectedIndex].ToString());
                lblSumaPedidos.Text = SumaTotalPedido.ToString();
                borrarFilas(lstComprar.SelectedIndex);
                

            }

        }


        private void borrarFilas(int x) {
            lstExistentes.Items.RemoveAt(x);
            lstPedidos.Items.RemoveAt(x);
            lstComprar.Items.RemoveAt(x);
        }
        private void lstExistentes_Click(object sender, EventArgs e)
        {
            seleccionarListas(lstExistentes, lstComprar, lstPedidos);
        }

        private void seleccionarListas(ListBox listaReferente,ListBox lista1, ListBox lista2) 
        {
            int posicionActual = listaReferente.SelectedIndex;
            lista1.SelectedIndex = posicionActual;
            lista2.SelectedIndex = posicionActual;
        }


        private void lstPedidos_Click(object sender, EventArgs e)
        {
            seleccionarListas(lstPedidos,lstExistentes,lstComprar);

        }

        private void lstComprar_Click(object sender, EventArgs e)
        {
            seleccionarListas(lstComprar, lstExistentes, lstPedidos);
        }
    }
}
