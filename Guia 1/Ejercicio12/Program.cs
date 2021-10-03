using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida al usuario 2 numeros enteros.Si el segundo no es cero, mostrara
            el resutlado de dividir el primero y el segundo. Por el contrario si el segundo numero es cero,
            ecribira "Error". No se puede dividir entre cero."*/

            int n1, n2;
            Console.WriteLine("Introduzca el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 != 0)
                Console.WriteLine("El resultado de la division de n1 {0} y n2 {1} es: {2}", n1, n2, n1 / n2);
            else
                Console.WriteLine("Error no se puede dividir por 0");
        }
    }
}
