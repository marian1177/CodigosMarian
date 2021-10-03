using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
            puede hacer dividiendo varias veces entre 10).*/
            int numero;
            int contador = 0;

            Console.WriteLine("Introduzca un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                numero = numero / 10;
                contador++;

            }
            Console.WriteLine("el numero ingresado tiene: {0} cifras ", contador);
        }
    }
}
