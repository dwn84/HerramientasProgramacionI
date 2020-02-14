using System;

namespace EjemploCodigo
{
    class Program
    {
        static void Main(string[] args)
        {

            //definir variables primitivas
            //valores enteros
            Byte edad=19;//entero sin signo de 8 bits
            SByte deuda;//entero con signo de 8 bits
            short saldoCuenta;//entero con signo  de 16 bits
            int sumaCuentasBancarias;//entero con signo de 32 bits
            long deudaExteriorPais;//entero con signo de 64 bits
            //valores reales
            float pesoCorporal;//real de 32 bits
            double centimetros;//real de 64 bits
            //lógicos - Boolean
            bool encontrado;//solo recibe False - True
            //caracter
            char sexo;//recibe un único caracter ´F´ ´M´
            //Cadena
            string nombre;//Objeto de texto

        
            //Definir A,B,C como Reales;
            double A, B, C;
            //Escribir "Ingrese el primer numero:";
            Console.WriteLine("Ingrese el primer numero:");
            //Leer A;
            A=Convert.ToDouble(Console.ReadLine());
            //Escribir "Ingrese el segundo numero:";
            Console.WriteLine("Ingrese el segundo numero:");
            //Leer B;
            B = Convert.ToDouble(Console.ReadLine());
            //C <- A+B
            C = A + B;
            //Escribir "El resultado es: ",C;
            Console.WriteLine("El resultado es: "+C);
            A++;//incremento en uno
            B--;//decremento en uno
            Console.WriteLine("El resultado de A es: " + A);
            Console.WriteLine("El resultado de B es: " + B);
            A += 2;//A = A + 2 //incremento de 2 en 2
            Console.WriteLine("El resultado de A es: " + A);
            B -= 2;//B = B - 2 //decremento de 2 en 2
            Console.WriteLine("El resultado de B es: " + B);
            A *= 2;//A = A * 2 //multiplica el valor de A por 2
            Console.WriteLine("El resultado de A es: " + A);
            B /= 2;//B = B / 2 //dividir el valor de B por 2
            Console.WriteLine("El resultado de B es: " + B);
            //negar o invertir una expresión lógica
            encontrado = true;
            Console.WriteLine("El resultado de encontrado es: " + !encontrado);
            encontrado = !encontrado;//altera la variable
            Console.WriteLine("El final de encontrado es: " + encontrado);

            //    Lee los tres lados de un triangulo rectangulo, determina 
            // si corresponden (por Pitargoras) y en caso afirmativo 
            // calcula el area

            //Definir l1, l2, l3 Como Real;

            double l1, l2, l3;
            //Escribir "Ingrese el lado 1:";
            Console.WriteLine("Ingrese el lado 1:");
            //Leer l1;
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2:");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3:");
            l3 = Convert.ToDouble(Console.ReadLine());

            //Definir cat1,cat2,hip Como Real;
            double cat1, cat2, hip;
            //Si l1>l2 Entonces

            if (l1 > l2)
            {
                // cat1 < -l2;
                cat1 = l2;
                //Si l1>l3 Entonces
                if (l1 > l3)
                {
                    //hip<-l1;
                    //cat2 < -l3;
                    hip = l1;
                    cat2 = l3;
                }
                else
                {
                    //hip<-l3;
                    //cat2 < -l1;
                    hip = l3;
                    cat2 = l1;
                }
            }
            else 
            {
                cat1 = l1;
                if(l2 > l3)
                {

                    hip = l2;
                    cat2 = l3;
                }
                else
                {
                    hip = l3;
                    cat2 = l2;
                }
            }
            // validar una expresion con otra requiere doble igual
            // si a=b
            // if (a==b)
            if(Math.Pow(hip,2) == Math.Pow(cat1, 2) + Math.Pow(cat2, 2))
            {
                double area;
                area= (cat1 * cat2) / 2;
                Console.WriteLine("El area es: " + area);
            }
            else 
            {
                Console.WriteLine("No es un triangulo rectangulo.");
            }


        }
    }
}
