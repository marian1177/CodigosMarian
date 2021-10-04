using System;
using System.Collections;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida al usuario 6 números reales de doble precisión, los guarde en una cola
            y luego los muestre en pantalla.*/

            double numeros; 
            Console.WriteLine("Ingrese 6 numeros reales de doble precision\n"+
                              "Ingrese el primer numero");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            double n4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            double n5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el sexto numero");
            double n6 = Convert.ToDouble(Console.ReadLine());


            Queue micola = new Queue();
            micola.Enqueue(n1);
            micola.Enqueue(n2);
            micola.Enqueue(n3);
            micola.Enqueue(n4);
            micola.Enqueue(n5);
            micola.Enqueue(n6);

            for (int i = 0; i < 6; i++)
            {
                numeros = (double)micola.Dequeue();
                Console.WriteLine(numeros);
            }


        }
    }
}
