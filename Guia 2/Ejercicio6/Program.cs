using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5;
            a=a*2; Crea un programa que lo resuelva.*/
            int a = 5;
            int b = ++a;
            int c = a++;

            Console.WriteLine(c);

            Console.WriteLine(" A= {0} B= {1} y C= {2}. Nueva asignacion a B: b = b * 5 = {3}. Nueva asignacion a A: A * 2 = {4}", a, b, c, b * 5, a * 2);

        }
    }
}
