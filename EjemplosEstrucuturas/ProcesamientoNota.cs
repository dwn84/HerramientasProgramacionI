using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosEstrucuturas
{
    class ProcesamientoNota
    {

        public static List<int> calcularNota(List<int> notas)
        {
            List<int> notaFinal = new List<int>();


            int comp;
            int notadefinitiva;

            foreach (int n in notas) 
            {

                comp = 0;
                notadefinitiva = 0;

                if (n >= 38)
                {
                    //validacion y calculo
                    if (n % 5 != 0)
                    {
                        comp = n / 5;
                        comp = (comp * 5) + 5;
                        if ((comp - n) < 3)
                        {
                            notadefinitiva = comp;
                        }
                        else
                        {
                            notadefinitiva = n;
                        }
                    }
                    else
                    {
                        notadefinitiva = n;
                    }

                }
                else
                {
                    notadefinitiva = n;
                }


                notaFinal.Add(notadefinitiva);

            }


            return notaFinal;

        }
    }
}
