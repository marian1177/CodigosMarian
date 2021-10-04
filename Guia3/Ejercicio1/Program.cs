using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una función llamada "Signo", que reciba un número real, y devuelva un
            número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/
            
            float n;
            Console.WriteLine("escriba un numero real");
            n = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("************************");
            signo(n);
        }
        public static void signo(float n)
        {
            if (n < 1 && n != 0)
                Console.Write("-1");
            else if (n > 1)
                Console.Write("1");
            else
                Console.Write("0");
        }
    }
}
