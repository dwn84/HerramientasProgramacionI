using System;

namespace EjemploClases
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear o instanciar el objeto
            BankAccount Annie = new BankAccount();
            //modifican las propiedades
            Annie.Nombre = "Annie Dickinson";
            Annie.NumeroCuenta = 100010002;
            Annie.Saldo = 350000;
            //llamar o invocar las acciones/métodos
            Console.WriteLine(Annie.MostrarDetalles());
            Console.WriteLine("Ingrese el dinero a depositar");
            double dinerito = Convert.ToDouble(Console.ReadLine());
            Annie.Depositar(dinerito);
            Console.WriteLine(Annie.MostrarDetalles());
            Console.WriteLine("Ingrese el dinero a retirar");
            double money = Convert.ToDouble(Console.ReadLine());
            try
            {
                Annie.Retirar(money);
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);            
            }
            Console.WriteLine(Annie.MostrarDetalles());
        }
    }
}
