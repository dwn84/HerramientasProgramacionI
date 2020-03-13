using System;

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


        }
    }
}
