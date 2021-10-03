using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida al usuario 2 numeros enteros y diga cual es el mayor de ellos
            int n1, n2, mayor;
            Console.WriteLine("Introduzca el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            mayor = n1 > n2 ? n1 : n2;
            Console.WriteLine("el numero mayor es: {0}", mayor);
        }
    }
}
