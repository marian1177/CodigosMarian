using System;
using System.Text.RegularExpressions;

namespace _4_funciones_en_1_programa
{
    class Program
    {
        static float Saldo = 5000;
        static float Nuevosaldo; //Declaramos un saldo float por fuera del main y funciones para que
                                 // sea un valor "globlal" que se tome en todo el codigo.
        public static string valores;   //Declaramos la variable "valores"(ingresado por usuario en el main) por fuera del main para llamarlo
                                        // desde la funcion "transferencia". 

        public static void Main(string[] args)
        {
            int clavenueva;
            int opcion;
            Console.WriteLine("************************************************\n" +
                             "*                                               *\n" +
                             "* Bienvenido al Cajero Automatico CAR-LE-LU-MAR *\n" +
                             "*                                               *\n" +
                             "*************************************************\n" +
                             "                                                  ");

            Console.WriteLine(" Por favor Ingrese Su Dni");

            int Dni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Su Clave");
            int clave = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su saldo es de: $ {0}", Saldo);


            Console.WriteLine("Elige una de las opciones\n" +
                              ".Opción 1 Extraer Dinero\n" +
                              ".Opción 2 Depositar\n" +
                              ".Opción 3 Transferir\n" +
                              ".Opción 4 Generar nueva clave \n" +
                              ".Opción 5 Salir");

            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Indique la cantidad a extraer");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    funcionextraer(cantidad);

                    break;

                case 2:
                    Console.WriteLine("Indique la cantidad a depositar");
                    float deposito = Convert.ToUInt32(Console.ReadLine());
                    funciondeposito(deposito);
                    break;

                case 3:
                    float Transferencia;
                    Console.WriteLine("Ingrese el monto que desea transferir");
                    Transferencia = float.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese un Alias o un CBU");
                    Console.WriteLine("(Recuerde el Alias debe ser alfanumerico de 20 caracteres, y si ingresa un\n" +
                                      " CBU, debe ser de 22 digitos)");

                    valores = Console.ReadLine();

                    ValidarAliasoCbu(ref valores);//aca faltaria poner un if por si la funcion da false, que salga y
                                                  // si da true procede a transferir
                    funciontransferencia(Transferencia);

                    break;

                case 4:

                    Console.WriteLine("Ingrese su anterior clave actual:");
                    int claveantigua = Convert.ToInt32(Console.ReadLine());
                    if (claveantigua != clave)
                        Console.WriteLine("La clave no es la misma");
                    else
                        Console.WriteLine("El sistema le generara su nueva contraseña");
                    Console.WriteLine("************Procesando*****************\n" +
                                  "************Procesando*****************\n" +
                                  "************Procesando*****************\n" +
                                  "************Procesando*****************");
                    Random r = new Random(); //Funcion de numeros aleatorios sacado de los apuntes
                    clavenueva = r.Next(1000, 9999);
                    Console.WriteLine("Su nueva clave es: {0}", clavenueva);

                    break;

                case 5:
                    Console.WriteLine("Adios");
                    break;
            }


        }
        private static float funcionextraer(int cantidad)
        {
            if ((cantidad < 100) || (cantidad % 100 != 0)) //como cajero real, no te deja sacar menos de 100 ni con coma
            {
                Console.WriteLine("Error , debe ingresar un monto mayor a $100 y sus mutiplos");
            }
            else
            {
                Nuevosaldo = Saldo - cantidad;
                Console.WriteLine("Su saldo actual es: {0}", Nuevosaldo);

            }
            return Nuevosaldo;
        }
        private static float funciondeposito(float deposito)
        {

            Nuevosaldo = Program.Saldo + deposito;
            Console.WriteLine("Su saldo actual es: {0}", Nuevosaldo);
            return Nuevosaldo;
        }

        private static float funciontransferencia(float Transferencia)
        {

            Nuevosaldo = Program.Saldo - Transferencia;

            Console.WriteLine("Su saldo actual es: {0:0.##}", Nuevosaldo);
            Console.WriteLine("Usted transfirio ${0:0.##} a la cuenta: {1}", Transferencia, valores);

            return Nuevosaldo;
        }


        public static Boolean ValidarAliasoCbu(ref string valores)
        {
            var Aliasletras = new Regex(@"^[A-Z]*$"); //si el usuario ingresa un alias solo toma mayusculas y
            var Aliascantidad = new Regex(@".{6,20}"); // el alias tienen que ser de 6 a 20 caracteres

            var Cbunumeros = new Regex(@"^[0-9]*$"); //si el usuario ingresa un cbu tienen que ser num del 0 al 9 y
            var Cbucantidad = new Regex(@".{22,}");  //tienen que ser 22 caracteres

            if ((Aliasletras.IsMatch(valores) && Aliascantidad.IsMatch(valores)) || (Cbunumeros.IsMatch(valores) && Cbucantidad.IsMatch(valores)))
            {   //primer if si coincide alias y cant de caracteres es valido o si ingresa cbu con la cantidad de num tambien es valido
                Console.WriteLine("CBU Verificado");
                return true;
            }
            else
            {
                //msj de error si el usuario ingresa cualquier otra cantidad de letras y numeros o simbolos
                Console.WriteLine("Error");
                Console.WriteLine("Ingresó un Alias o CBU invalido");
                return false;
            }



        }

    }
}
