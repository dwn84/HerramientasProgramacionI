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

