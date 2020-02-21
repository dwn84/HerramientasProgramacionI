using System;

namespace CasosCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {

            int diaSemana;

            Principio:

            Console.WriteLine("Ingrese el día de la semana. 1 = Lunes, 2 = martes...");
            diaSemana = Convert.ToInt32(Console.ReadLine());
            byte x;
            x = Convert.ToByte(diaSemana);
            //otra forma de convertir tipos de datos
            x = (byte)diaSemana;//casting
            string resultado;
            //if (diaSemana == 6 || diaSemana == 7)
            //{
            //    resultado = "A pasear se dijo!!!";
            //}
            //else 
            //{
            //    resultado = "A estudiar juicioso";
            //}

            resultado = (diaSemana == 6 || diaSemana == 7) ? "A pasear se dijo!!!" : "A estudiar juicioso";

            switch (diaSemana) 
            {
                case 1:
                    resultado = "Lunes";                    
                    break;
                case 2:
                    resultado = "Martes";
                    break;
                case 3:
                    resultado = "Miercoles";
                    break;
                case 4:
                    resultado = "Jueves";
                    break;
                case 5:
                    resultado = "Viernes";
                    break;
                case 6:
                    resultado = "Sábado";
                    break;
                case 7:
                    resultado = "Domingo";
                    break;
                default:
                    resultado = "Dia incorrecto";
                    break;

            }



            Console.WriteLine(resultado);


            Console.WriteLine("Tamaño del café: 1=pequeño 2=medio 3=grande");
            Console.Write("Ingrese su elección: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "pequeño":
                    cost += 25;
                    break;
                case "2":
                case "medio":
                    cost += 15;
                    goto Principio;
                case "3":
                case "grande":
                    cost += 27;
                    goto EsternocleidoMastoideo;
                default:
                    Console.WriteLine("Valor incorrecto. Debe escribir 1, 2, o 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Valor del café: " + cost);
            }

        EsternocleidoMastoideo:
            Console.WriteLine("Vuelva pronto.");

            try
            {
                Console.Write("Ingrese un valor:");
                string dato = Console.ReadLine();
                var num = int.Parse(dato);
                var cuadrado = num * num;
                Console.WriteLine("El cuadraro es: " + cuadrado);
            }
            catch (Exception m)
            {
                Console.WriteLine("Ha ocurrido un error inesperado");
                Console.WriteLine(m.Message);
                Console.WriteLine(m.StackTrace);
                Console.WriteLine(m.GetType());
            }

            try
            { 
                string linea;
                Console.Write("Ingrese el primer valor:");
                linea = Console.ReadLine();
                int num1 = Convert.ToInt32(linea);
                Console.Write("Ingrese el segundo valor:");
                linea = Console.ReadLine();
                int num2 = Convert.ToInt32(linea); ;
                int result = num1 / num2;
                Console.WriteLine("La división de los números es: " + result);
           }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Imposible dividir por cero.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar obligatoriamente un número entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error genérico o desconocido" + e.Message);
            }
            finally
            {
                Console.WriteLine("Fin del proceso");
            }
            

        }
    }
}
