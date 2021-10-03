using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida al usuario su identificador y su contraseña (ambos
            numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
            contraseña "1111".*/
            int user, password;

            do
            {
                Console.WriteLine("Ingrese su número de usuario:");
                user = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su contraseña:");
                password = Convert.ToInt32(Console.ReadLine());

                if (user != 1234 || password != 1111)
                    Console.WriteLine("El usuario/contraseña es incorrecto. Vuelva  Intentarlo");

            }
            while (user != 1234 || password != 1111);
            Console.WriteLine("¡Bienvenido! {0}", user);
        }
    }
}
