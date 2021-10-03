using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida al usuario un numero del 1 al 5 y escriba el nombre de ese numero. Usar switch.
            int n1;
            Console.WriteLine("Introduzca un numero del 1 al 5");
            n1 = Convert.ToInt32(Console.ReadLine());

            switch (n1)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
            }
        }
    }
}
