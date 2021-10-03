using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida una letra al usuario y diga si se trata de una vocal.*/
            string letra;
            Console.WriteLine("Introduzca una letra");
            letra = Convert.ToString(Console.ReadLine());

            if ((letra == "a") || (letra == "e") || ((letra == "i") || (letra == "o") || (letra == "u")))
                Console.WriteLine("usted ingreso una vocal");
            else
                Console.WriteLine("no es vocal");
        }
    }
}
