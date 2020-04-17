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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //validar si el cuadro de texto se encuentra vacio o en blanco
            if (txtDato.Text == "")
            {
                //mostrar una advertencia
                MessageBox.Show("Falta ingresar información...");
            }
            else 
            {
                //guardar el dato en la lista
                lstDatos.Items.Add(txtDato.Text);
                //se borra el dato en el cuadreo de texto
                txtDato.Clear();
                //ubicar el cursor en el cuadreo de texto
                txtDato.Select();
            }
           
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {

            int n = lstDatos.Items.Count - 1;
            foreach (var x in lstDatos.Items)
            {
                MessageBox.Show("data:"+x.ToString());
            }
            for (int i = n; i >= 0; i--)
            {

                lstInvertidos.Items.Add(lstDatos.Items[i]);
            
            }

        }

        private void btnCapicua_Click(object sender, EventArgs e)
        {
            int mitadDatos = lstDatos.Items.Count/2;
            int n = lstDatos.Items.Count - 1;
            int conteoParejas = 0;
            for (int i = 0; i < mitadDatos; i++) 
            {

                //MessageBox.Show("Dato: " + i+ ": "+ lstDatos.Items[i].ToString());
                //MessageBox.Show("Dato: " + n + ": " + lstDatos.Items[n].ToString());

                if (Convert.ToInt32(lstDatos.Items[i]) == Convert.ToInt32(lstDatos.Items[n])) 
                {
                    conteoParejas++;
                }

                //MessageBox.Show("Contador:" + conteoParejas);
                n--;

            }

            //MessageBox.Show("Mitad de datos:" + mitadDatos);


            if (conteoParejas == mitadDatos)
            {
                MessageBox.Show("Es capicua!!!!");
            }
            else 
            {
                MessageBox.Show("No es capicua :(");
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            lstInvertidos.Items.Clear();
        }
    }
}
