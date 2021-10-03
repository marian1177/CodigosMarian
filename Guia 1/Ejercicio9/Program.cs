using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que calcule el producto de 2 numeros introducidos por el usuario
            int n1, n2;
            Console.WriteLine("Introduzca el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            int resultado = n1 * n2;
            Console.WriteLine("El producto es: {0} ", resultado);
        }
    }
}
