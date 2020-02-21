using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //exiten 3 areas: gine, pedi, trauma
            //presupuesto     40%,   30%, 30%
            //solo el director varia porcentajes..
            //asigando por el estado
            //definir en pesos el valor de cada area

            double gine=40, pedi=30, trauma=30;
            string usuario;
            double presupuesto;

            Console.WriteLine("Sistema de asignación de presupuesto");
            Console.WriteLine("Ingrese el usuario: ");
            usuario = Console.ReadLine();

            if (usuario == "Director")
            {
                Console.WriteLine("¿Cuál es el valor porcentual del presupuesto para ginecología");
                gine = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("¿Cuál es el valor porcentual del presupuesto para pediatría");
                pedi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("¿Cuál es el valor porcentual del presupuesto para traumatología");
                trauma = Convert.ToDouble(Console.ReadLine());
                if ((gine + pedi + trauma) > 100)
                {
                    Console.WriteLine("Asignación incorrecta");
                }
                
            }
            Console.WriteLine("Cual es el presupuesto que asigna el estado");
            presupuesto = Convert.ToDouble(Console.ReadLine());
            gine = presupuesto * (gine/100);
            pedi = presupuesto * (pedi / 100);
            trauma = presupuesto * (trauma / 100);
            Console.WriteLine("El presupuesto de ginecología es: " + gine);
            Console.WriteLine("El presupuesto de pediatría es: " + pedi);
            Console.WriteLine("El presupuesto de traumatología es: " + trauma);
            }



        }
    }

