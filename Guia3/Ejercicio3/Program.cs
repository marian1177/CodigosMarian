using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una función "EsPrimo", que reciba un número y devuelva el valor
            booleano "true" si es un número primo o "false" en caso contrario.*/
            int n1;
            Console.WriteLine("escriba un numero para saber si es primo ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("************************");
            Console.WriteLine(EsPrimo(n1));

        }

        public static Boolean EsPrimo(int x)
        {

            for (int i = 2; i < x; i++)
            {

                if ((x % i) == 0)

                    return false;

            }
            return true;
        }
    }
    
}
