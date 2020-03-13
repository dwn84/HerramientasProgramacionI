using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosEstrucuturas
{
    class Jugador
    {
        String nombre;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        //constructor
        public Jugador(string n, int e)
        {
            nombre = n;
            edad = e;
        
        }
    }
}
