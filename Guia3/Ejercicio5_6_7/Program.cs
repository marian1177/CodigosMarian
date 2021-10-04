using System;

namespace Ejercicio5_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una calculadora básica, llamada "calcula", que deberá sumar, restar,
            multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de
            su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones).
            Ejercicio 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que
            devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la
            suma sería 6.
            Ejercicio 7: Crea una función "Triángulo" que reciba una letra y un número, y
            escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se
            ha indicado*/

            Console.WriteLine("Bienvenido a la Super Calculadora");
            Console.WriteLine("Elige una de las opciones");
            Console.WriteLine(".Opción 1 - Suma/Resta/Multiplicacion/Division");
            Console.WriteLine(".Opción 2 Suma de cifras");
            Console.WriteLine(".Opción 3 Dibuje el triangulo");
            Console.WriteLine(".Opción 4 Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("ingrese el primer numero");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el tipo de ecuacion");
                string simbolo = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero");
                int n2 = Convert.ToInt32(Console.ReadLine());

                CalculadoraBasica(n1, simbolo, n2);
            }

            else if (opcion == 2)
            {
                Console.WriteLine("ingrese un numero para sumarle las cifras");
                int n = Convert.ToInt32(Console.ReadLine());

                sumacifras(n);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("ingrese un numero para dar tamaño a la figura");
                int n = Convert.ToInt32(Console.ReadLine());

                figuras(n);
            }

        }


        public static void CalculadoraBasica(int n1, string simbolo, int n2)
        {
            switch (simbolo)
            {
                case "+":
                    Console.WriteLine("El resultado es {0}", n1 + n2);
                    break;

                case "-":
                    Console.WriteLine("El resultado es {0}", n1 - n2);
                    break;

                case "*":
                    Console.WriteLine("El resultado es {0}", n1 * n2);
                    break;

                case "/":
                    Console.WriteLine("El resultado es {0}", n1 / n2);
                    break;
            }
        }

        public static void sumacifras(int n)
        {
            if (n >= 10 && n <= 99)
            {
                int primercifra = n / 10;
                int segundacifra = n % 10;
                int resultado = primercifra + segundacifra;

                Console.WriteLine("La suma de la primer cifra: {0} y la segunda: {1} es : {2}", primercifra, segundacifra, resultado);
            }
            else if (n >= 100 && n <= 999)
            {
                int primercifra = n / 100;
                int segundacifra = (n % 100) / 10;
                int tercercifra = n % 10;

                Console.WriteLine("La primer cifra: {0} ", primercifra);
                Console.WriteLine("La segunda cifra: {0} ", segundacifra);
                Console.WriteLine("La tercer cifra: {0} ", tercercifra);
                Console.WriteLine("La suma de la primer de las cifras es: {0}", primercifra + segundacifra + tercercifra);
            }
            else if (n >= 1000 && n <= 9999)
            {
                int primercifra = n / 1000;
                int segundacifra = (n / 100) % 10;
                int tercercifra = (n % 100) / 10;
                int cuartacifra = n % 10;
                Console.WriteLine("La primer cifra: {0} ", primercifra);
                Console.WriteLine("La segunda cifra: {0} ", segundacifra);
                Console.WriteLine("La tercer cifra: {0} ", tercercifra);
                Console.WriteLine("La tercer cifra: {0} ", cuartacifra);
                Console.WriteLine("La suma de la primer de las cifras es: {0}", primercifra + segundacifra + tercercifra + cuartacifra);
            }

        }
        public static void figuras(int n)
        {
            Console.WriteLine("Escriba una letra para dar a la figura");
            string letra = Convert.ToString(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(letra);
                }
                Console.WriteLine("");
            }

        }
    
    }
}
