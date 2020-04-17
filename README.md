# Herramientas de programación I
Programación en C#

# Definición de variables
```C#
//tipo de dato acompañado del nombre de la variable
int sumaCuentasBancarias;//entero con signo de 32 bits
```

# Recibir un dato del usuario
```C#
double A;
A=Convert.ToDouble(Console.ReadLine());
```
# Condicionales
```C#
if(a>b)
{
  Console.WriteLine("a es mayor que b");
}
else
{
  Console.WriteLine("b es mayor que a");
}
```

# Operador ternario
```
expresión boleana ? valor si cierto : valor si falso
```
```
is this condition true ? yes : no
```
```C#
int input = new Random().Next(-5, 5);

string classify;
if (input >= 0)
{
    classify = "nonnegative";
}
else
{
    classify = "negative";
}

classify = (input >= 0) ? "nonnegative" : "negative";
Console.Write(classify);

}
```
# switch 
```C#

int caseSwitch = 1;
      
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break;
    case 2:
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}
```
```C#

Color c = (Color) (new Random()).Next(0, 3);
if (c == Color.Red)
   Console.WriteLine("The color is red");
else if (c == Color.Green)
   Console.WriteLine("The color is green");
else if (c == Color.Blue)
   Console.WriteLine("The color is blue");   
else
   Console.WriteLine("The color is unknown.");
```
el anterior código es equivalente a:
```C#

Color c = (Color) (new Random()).Next(0, 3);
switch (c)
{
   case Color.Red:
      Console.WriteLine("The color is red");
      break;
   case Color.Green:
      Console.WriteLine("The color is green");
      break;
   case Color.Blue:
      Console.WriteLine("The color is blue");   
      break;
   default:
      Console.WriteLine("The color is unknown.");
      break;   
}
```
Ejemplo switch
```C#
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
      goto case "1";
  case "3":
  case "grande":
      cost += 27;
      goto case "1";
  default:
      Console.WriteLine("Valor incorrecto. Debe escribir 1, 2, o 3.");
      break;
}
if (cost != 0)
{
    Console.WriteLine("Valor del café: "+  cost);
}
Console.WriteLine("Vuelva pronto.");
```
¿Cuánto cuesta cada tipo de café?

¿goto?

# try-catch
La declaración ```try``` consiste en un bloque ```try``` que contiene una o más sentencias (se debe usar siempre {} incluso para una sola sentencia) y al menos una cláusula ```catch``` o una cláusula ```finally```, o bien ambas. Esto nos da tres formas posibles para la declaración ```try```:
- ```try...catch```
- ```try...finally```
- ```try...catch...finally```
Ejemplos en C#
```C#
try
{
    Console.Write("Ingrese un valor:");
    string dato = Console.ReadLine();
    var num = int.Parse(dato);
    var cuadrado = num * num;
    Console.WriteLine("El cuadraro es: " + cuadrado);
}
catch(Exception e)
{
    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");
}

try 
{
    string linea;
    Console.Write("Ingrese el primer valor:");
    linea = Console.ReadLine();
    int num1 = System.Convert.ToInt32(linea);
    Console.Write("Ingrese el segundo valor:");
    linea = Console.ReadLine();
    int num2 = System.Convert.ToInt32(linea);;
    int result = num1/num2;
    Console.WriteLine("La división de los números es: " + result);
}catch(ArithmeticException e)
{
    Console.WriteLine("Imposible dividir por cero.");
}
catch(FormatException e)
{
    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");
}
catch(Exception e)
{
    Console.WriteLine("Error genérico o desconocido" + e.Message);
}
finally
{
    Console.WriteLine("Fin del proceso");
}
```

# Arreglos

[Definición de arreglos](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)

# Listas

[Manejo de listas](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8)

# Programación Orientada a Objetos

[Creación de clases](https://dwn84.github.io/diapositivas/POO.html)


[Herencia](https://dwn84.github.io/diapositivas/herencia.html)


# Página de estudio

[tutorialesprogramacionya](https://www.tutorialesprogramacionya.com/csharpya/)


# Ejercicios

[1](https://www.hackerrank.com/challenges/mini-max-sum/problem)
[2](https://www.hackerrank.com/challenges/compare-the-triplets/problem)
[3](https://www.hackerrank.com/challenges/grading/problem)
[4](https://www.hackerrank.com/challenges/sparse-arrays/problem)

