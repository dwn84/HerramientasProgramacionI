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
