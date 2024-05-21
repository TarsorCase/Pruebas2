// See https://aka.ms/new-console-template for more information
using TestDemo;

Console.WriteLine("Calculadora");
Console.Write("Ingrese un valor a sumar: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo valor a sumar: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Mathematics.Addition(a, b));
