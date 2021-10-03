using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama
            "Martín", o bien le diga "No te conozco" si teclea otro nombre.*/
            Console.WriteLine("Introduzca su nombre");
            string nombre = Convert.ToString(Console.ReadLine());

            if (nombre == "Mariano")
                Console.WriteLine("Hola");
            else
                Console.WriteLine("No te conozco");
        }
    }
}
