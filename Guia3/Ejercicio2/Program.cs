using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("escriba un numero ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba un segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************");
            menor(n1, n2);

        }

        public static void menor(int n1, int n2)
        {
            if (n1 < n2)
                Console.WriteLine("{0} es menor a {1}", n1, n2);
            else
                Console.WriteLine("{0} es menor a {1}", n2, n1);
        }
    }
    
}
