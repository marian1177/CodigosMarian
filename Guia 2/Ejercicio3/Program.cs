using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que muestre la tabla de multiplicar del 9.*/
            for (int i = 1; i <= 10; i++)

                for (int j = 9; j < 10; j++)

                    Console.WriteLine("{0} x {1} = {2} ", j, i, i * j);
        }
    }
}
