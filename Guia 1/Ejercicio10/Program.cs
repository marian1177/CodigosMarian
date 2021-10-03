using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida al usuario un numero entero y diga si es par
            int n1;
            Console.WriteLine("Introduzca un numero entero");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 2 == 0)
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero no es par");
        }
    }
}
