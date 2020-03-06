using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploClases
{//definir la clase 
    class BankAccount
    {
        //definir las variables
        private string nombre;
        private int numeroCuenta;
        private double saldo;
        //definir atributos: click derecho en el nombre de la variable
        //Acciones rápidas y refactorización
        //encapsular campo y usar propiedad.
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        //definir los métodos o acciones
        //escribir la firma del método
        // modificar de acceso: private - public
        // tipo de retorno: void - int -string -...
        // nombre del método: verbo
        // parentesis para los parámetros de entrada.
        public void Depositar(double dinero) {
            //implementación del método
            saldo += dinero;
        }

        public void Retirar(double dinero)
        {
            //validación de un error en el método
            if (saldo < dinero) {
                //generamos una nueva excepción
                throw new Exception("Saldo insuficiente");
            }
            saldo -= dinero;
        }

        public string MostrarDetalles() 
        {
            string mensaje = "La cuenta #" + numeroCuenta
                + " pertenece a " + nombre
                + " tiene un saldo de: " + saldo;
            
            //al final o en los condicionales retornamos el resultado
            return mensaje;
        }

    }
}
