using System;

namespace Ejecicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
            debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le
            volverán a pedir las dos contraseñas.*/
            int identificador;
            int contraseña = 1111;

            do
            {

                Console.WriteLine("Introduzca Identificador y Contraseña");
                identificador = Convert.ToInt32(Console.ReadLine());



                if (identificador == 1234)
                {
                    Console.WriteLine(" Usuario correcto, ingrese la Contraseña");
                    contraseña = Convert.ToInt32(Console.ReadLine());
                    if (contraseña == 1111)
                    {

                        Console.WriteLine(" Vuelva a introducir la Contraseña");
                        contraseña = Convert.ToInt32(Console.ReadLine());

                        if (contraseña == 1111)
                            Console.WriteLine("Bienvenido");
                        else
                        {
                            Console.WriteLine("contraseña incorrecta");
                        }

                    }
                    else
                    {
                        Console.WriteLine("contraseña incorrecta");
                    }
                }
                else
                    Console.WriteLine("Usuario incorrecto");



            }
            while ((contraseña != 1111) || (identificador != 1111));

        }
    }
}
