using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2;
            ++c; a*=b; Crea un programa que te lo muestre.*/
            int a = 5;
            int b = a + 2;
            b = b - 3;
            int c = -3;
            c = c * 2;
            ++c;
            a = a * b;

            Console.WriteLine(c);

            Console.WriteLine(" A= {0} B= {1} y C= {2}.", a, b, c);
        }
    }
}
