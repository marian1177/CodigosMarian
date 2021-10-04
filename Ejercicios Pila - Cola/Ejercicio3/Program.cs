using System;
using System.Collections;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida frases al usuario, hasta que introduzca una frase vacía. En ese
            momento, mostrará todas las frases que se habían introducido.*/

            /*
            Stack mipila = new Stack();
            string frases;
            int contador = 0;
            
            do
            {
                Console.WriteLine("ingrese una frase");
                frases = Convert.ToString(Console.ReadLine());

                mipila.Push(frases);
                contador++;

            } while (frases != "");

            for (int i = 0; i < contador; i++)
            {
                frases = (string)mipila.Pop();
                Console.WriteLine(frases);

            }

            */
            Queue micola = new Queue();
            string frases;
            int contador = 0;

            do
            {
                Console.WriteLine("ingrese una frase");
                frases = Convert.ToString(Console.ReadLine());

                micola.Enqueue(frases);
                contador++;

            } while (frases != "");

            for (int i = 0; i < contador; i++)
            {
                frases = (string)micola.Dequeue();
                Console.WriteLine(frases);

            }






        }
    }
}
