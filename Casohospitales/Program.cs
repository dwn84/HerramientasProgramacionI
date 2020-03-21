using System;

namespace Casohospitales
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mapa = new string[20, 20];
            //generar mapa vacio
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mapa[i, j] = "O";
                }
            }

            //generar los hospitales
            int[,] hospitales = new int[5, 3];
            //cada fila representa un hospital
            //la primera columna representa la posicion en x
            //la segunda columna representa la posicion en y
            //la tercera columna representa la distancia a la llamada de emergencia

            //generar aleatoriamente 5 hospitalees y ubicarlos en el mapa

            for (int h = 0; h < 5; h++)
            {
                Random random = new Random();
                int x = random.Next(0, 20);
                int y = random.Next(0, 20);

                mapa[x, y] = "H";

                hospitales[h, 0] = x;
                hospitales[h, 1] = y;

            }

            //generar aleatoriamente la llamada de emergencia y ubicarla en el mapa

            //dibujar el mapa
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j <| 20; j++)
                {
                    Console.Write(mapa[i, j] + " ");
                }
                Console.WriteLine();
            }
            //mostrar la posicion de cada hospital
            //mostrar la distancia de cada hospital con la llamada de emergencia
            //mostrar cual es el hospital mas cercano

        }
    }
}
