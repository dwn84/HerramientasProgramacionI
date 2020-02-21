using System;

namespace Motos
{
    class Program
    {
        static void Main(string[] args)
        {
            //se venden motos
            //valor por tipo
            //tipo1=100cc $2900000 por moto
            //tipo2=110cc $3650000 por moto
            //tipo3=125cc $4000000 por moto
            //tipo4=250cc $6000000 por moto

            //unidades > 3 15% descuento

            //nombre, codigo, tipo moto
            //preguntar la cantidad

            string nombre;
            int tipoM;
            string codigo;
            int cantidadMotos;
            double valorMoto;
            double totalPago;

            Console.WriteLine("Concecionario de motos");
            Console.WriteLine("1. Moto de 100cc");
            Console.WriteLine("2. Moto de 110cc");
            Console.WriteLine("3. Moto de 125cc");
            Console.WriteLine("4. Moto de 250cc");
            Console.WriteLine("Ingrese un número de 1 a 4 para seleccionar el tipo de moto");
            tipoM = Convert.ToInt32(Console.ReadLine());
            if (tipoM >= 1 && tipoM <= 4)
            {
                Console.WriteLine("Ingrese un la cantidad de motos que va a comprar");
                cantidadMotos = Convert.ToInt32(Console.ReadLine());

                switch (tipoM) 
                {
                    case 1:
                        valorMoto = 2900000;
                        break;
                    case 2:
                        valorMoto = 3650000;
                        break;
                    case 3:
                        valorMoto = 4000000;
                        break;
                    case 4:
                        valorMoto = 6000000;
                        break;
                    default:
                        valorMoto = 0;
                        break;
                }

                if (cantidadMotos >= 3) {
                    valorMoto = valorMoto - (valorMoto * 0.15);
                }

                totalPago = valorMoto * cantidadMotos;

                Console.WriteLine("El total a pagar es: " + totalPago);

            }
            else 
            {
                Console.WriteLine("Error, opcion invalida");
            }
            


        }
    }
}
