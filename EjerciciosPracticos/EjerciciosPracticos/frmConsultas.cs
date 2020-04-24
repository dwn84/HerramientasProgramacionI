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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        public void validarLlenarLista(TextBox cuadrotexto, ListBox lista)
        {
            //limpiar el texto: pasar todo a minúsculas y eliminar espacios en blanco al inicio y al final
            //ToLower Trim
            cuadrotexto.Text = cuadrotexto.Text.ToLower();
            cuadrotexto.Text = cuadrotexto.Text.Trim();
            // validar si el texto no es mayor que cero: esta vacia
            if (!(cuadrotexto.TextLength > 0))
            {
                MessageBox.Show("NO se puede trabajar con un texto vacio, ingrese información");
                cuadrotexto.Select();
            }
            else
            {
                lista.Items.Add(cuadrotexto.Text);
                cuadrotexto.Clear();
                cuadrotexto.Select();
            }
        }

        public void llenarResultados()
        {
            lstResults.Items.Clear();
            int contadorRepeticion;
            double x = Convert.ToDouble(txtQuery.Text);

            //recorrer los items de consulta
            foreach (var query in lstQueries.Items)
            {
                contadorRepeticion = 0;
                //recorrer los items de String
                for (int i = 0; i < lstStrings.Items.Count; i++)
                {
                    var it = lstStrings.Items[i];
                    if (query.Equals(it))
                    {
                        contadorRepeticion++;
                    }
                }
                lstResults.Items.Add(contadorRepeticion);
            }
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            validarLlenarLista(txtString, lstStrings);
            if (lstQueries.Items.Count > 0) {
                llenarResultados();
            }
            
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            //verificar si esta repetido
            if ((lstQueries.Items.IndexOf(txtQuery.Text)) == -1)
            {
                validarLlenarLista(txtQuery, lstQueries);
                llenarResultados();
            }
            else
            {
                MessageBox.Show("Dato duplicado, no se puede repetir una búsqueda");
                txtQuery.Clear();
                txtQuery.Select();
            }


        }



    }
}
