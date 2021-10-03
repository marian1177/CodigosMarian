using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que escriba los numeros del 1 al 10 usando do while
            int n = 0;
            do
            {
                n = n + 1;
                Console.WriteLine(n);
            }
            while (n < 10);
        }
    }
}
