using System;
//agregar nuevas características a los objetos
using System.Linq;
using System.Collections.Generic;



namespace EjemplosEstrucuturas
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizar una matriz de M(estudiantes) por 6(materias)
            //encontrar:
            //la nota promedio de cada estudiante
            //el número de estudiantes que aprobaron y perdieron cada materia
            //la nota promedio de cada materia
            int M;
            Console.Write("Ingrese la cantidad total estudiantes: ");
            M = int.Parse(Console.ReadLine());
            double[,] notas = new double[M, 6];
            //recibir las notas
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("Ingrese las notas del estudiante #" + (i + 1));
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Ingrese la nota de la materia #" + (j + 1) + ":");
                    notas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //calcular procesos
            //la nota promedio de cada estudiante
            double[] promedioE = new double[M];
            //el número de estudiantes que aprobaron cada materia
            int[] aprobaron = new int[6];
            //el número de estudiantes que reprobaron cada materia
            int[] reprobaron = new int[6];
            //la nota promedio de cada materia
            double[] promediosM = new double[6];

            //la nota promedio de cada estudiante
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    promedioE[i] = promedioE[i] + notas[i, j];
                }
                promedioE[i] = promedioE[i] / 6;
            }

            //el número de estudiantes que aprobaron cada materia
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    promediosM[j] = promediosM[j] + notas[i, j];
                    if (notas[i, j] >= 3)
                    {
                        aprobaron[j]++;
                    }
                    else
                    {
                        reprobaron[j]++;
                    }
                }
                promediosM[j] = promediosM[j] / M;
            }

            Console.WriteLine("Promedios de cada estudiante");
            int e = 1;
            foreach(double p in promedioE) 
            {
                Console.WriteLine("Promedio estudiante #" + e  +" :"+  p);
                e++;
            }

            Console.WriteLine("Cantidad de los que ganaron cada materia");
            e = 1;
            foreach (int g in aprobaron)
            {
                Console.WriteLine("Materia #" + e + " :" + g);
                e++;
            }

            Console.WriteLine("Cantidad de los que perdieron cada materia");
            e = 1;
            foreach (int per in reprobaron)
            {
                Console.WriteLine("Materia #" + e + " :" + per);
                e++;
            }

            Console.WriteLine("Promedio de cada materia");
            e = 1;
            foreach (int prom in promediosM)
            {
                Console.WriteLine("Materia #" + e + " :" + prom);
                e++;
            }

            //sumar dos matrices

            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];
            //lenar la matriz a
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //lenar la matriz b
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //lenar la matriz c
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            //mostrar la matriz de suma
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine("");
            }
            /*
             Given five positive integers, 
             find the minimum and maximum values that can be 
             calculated by summing exactly four of the five 
             integers. Then print the respective minimum and 
             maximum values as a single line of two 
             space-separated long integers.
             */

            int[] datos = {256741038,623958417,467905213,714532089,938071625};
            long[] nuevosDatos = new long[5];
            for (int i = 0; i < 5; i++)
            {
                nuevosDatos[i] = datos[i];
            }
            long min = nuevosDatos.Min();
            long max = nuevosDatos.Max();
            long sum = nuevosDatos.Sum();
            Console.WriteLine("El mínimo es: " + min);
            Console.WriteLine("El máximo es: " + max);
            Console.WriteLine("La suma es: " + sum);
            //mostrar datos originales
            foreach (int d in datos) 
            {
                Console.WriteLine(d);
            }
            //ordenar los datos
            Array.Sort(datos);
            Console.WriteLine("---------");
            //mostrar el resultado

            foreach (int d in datos)
            {
                Console.WriteLine(d);
            }
            long sumaMaxima = sum - min;
            long sumaMinima = sum - max;
            Console.WriteLine("La suma mínima: " + sumaMinima);
            Console.WriteLine("La suma máxima: " + sumaMaxima);


            //manejo de listas
            //crear una nueva lista de enteros
            List<int> noticas = new List<int>();
            //crear una nueva lista de reales
            List<double> calificaciones = new List<double>();
            //crear una nueva lista de jugadores (una nueva clase)
            List<Jugador> equipo = new List<Jugador>();

            //agregar datos a la lista

            noticas.Add(5);
            noticas.Add(4);
            noticas.Add(3);
            noticas.Add(5);

            calificaciones.Add(3.3);
            calificaciones.Add(4.4);
            calificaciones.Add(2.3);

            equipo.Add(new Jugador("Falcao",35));
            equipo.Add(new Jugador("James", 27));

            //agregar un dato en un lugar especifico
            noticas.Insert(1, 9);

            //mostrar todas las noticas

            foreach (int n in noticas)
            {
                Console.WriteLine(n);
            }

        }
    }
}
