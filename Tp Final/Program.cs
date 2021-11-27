using System;
using System.Collections;
using System.Globalization;
using System.Threading;
using System.Linq;

namespace Tp_Final
{
    class Program
    {
        static void Main(string[] args)


            /* El programa simula un organizador de pedidos al estilo una app como  "Pedidos ya" o "Rappi" dentro de un comercio.
             * tiene unos using distinguidos como como el  System.Globalization y el System.Linq que agregue para obtener dia de 
             * semanas en español y para consultas en arrays respectivamente.
             * El programa funciona tomando fecha actual segun sea dia de semana o fin de semana, es decir que,
             * si se corre el pgm dia de semana permite agregar 8 pedidos (simulando 1 pedido por hora) y si se corre
             * un sab permite solo 4 pedidos (simulando medio dia de trabajo) y dom envia msj de " Dia no laborable".
             */

        {
            int ingreso;
            int horas_laborables;
            DateTime dia_actual = DateTime.Now;
            int opcion;
            int total;
            string medio = "█";
            

            Console.WriteLine("**********************************************************************\n" +
                             "*                                                           FOODCALL® *\n" +
                             "*                                                                     *\n" +
                             "*                                                                     *\n" +
                             "*    _____   ___    ___    ___                  ____  _      _        *\n" +
                             "*   |     | /   '. /    '.|    '.    ▄████▄    /    || |    | |       *\n" +
                             "*   |   __||     ||      ||     |   ███▄█▀    |     || |    | |       *\n" +
                             "*   |  |_  |  O  ||  O   ||  D  |  ▐████   O  |  O  || |___ | |___    *\n" +
                             "*   |   _] |     ||      ||     |   █████▄    |  _  ||     ||     |   *\n" +
                             "*   |  |   |     ||      ||     |    ▀████▀   |  |  ||     ||     |   *\n" +
                             "*   |__|   '.___/ '. ___/ |___.´              |__|__||_____||_____|   *\n" +
                             "*                                                                     *\n" +
                             "*                                                                     *\n" +
                             "*     -PLATAFORMA EMPRESARIAL PARA GESTION DE PEDIDOS DE COMERCIOS-   *\n" +
                             "*                                                                     *\n" +
                             "***********************************************************************" +
                             "\n" +
                             "");

            Console.WriteLine("                                 Inicio                \n" +
                              "                  -------------------------------------\n" +
                              "                  [ 1 - Crear bandeja de pedidos.     ]\n" +      //pantalla de inicio con opciones de interfaz
                              "                  [ 2 - Salir.                        ] " +
                              " \n"  +
                              " \n" +
                              "");

            string dia = dia_actual.ToString("dddd", new CultureInfo("es-ES"));
            Console.WriteLine("       Promedio horas activas de la plataforma : 8 hrs Diarias Lun a Vier \n" +
                "");
            Console.WriteLine("         Sab: 4 hrs                -           Dom :  Plataforma inactiva \n" +
                "");
            Console.WriteLine("                            Hoy es: {0}\n" +
                "", dia);
            Console.WriteLine("                 Estadistica del sistema: 1 pedido por hora\n" +
                "");
            Queue pedido_individual;
            
            
            opcion = Convert.ToInt16(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    {
                        Console.WriteLine("Creando bandeja de pedidos...");
                        Funcion_barra_cargando(medio);
                        Console.WriteLine(" 100%");

                        pedido_individual = new Queue();
                        Console.WriteLine("Bandeja de pedidos creada.");

                     

                        Console.WriteLine("                   Procede a agregar los pedidos? s-S/n-N");

                        string opcion_2 = Convert.ToString(Console.ReadLine());
                        if (opcion_2 == "s" || opcion_2 == "S")
                        {

                            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
                            {
                                horas_laborables = 9;

                                for (int i = 1; i < horas_laborables;)
                                {
                                    do
                                    {
                                        Console.WriteLine("                   Ingrese el numero del nuevo pedido y presione ENTER");
                                        ingreso = Convert.ToInt32(Console.ReadLine());
                                        
                                      

                                        if (ingreso < 0 || ingreso > 999)
                                        {

                                            Console.WriteLine("                   *¡Error pedido fuera de rango, no se tomara en cuenta, ingrese un pedido mayor a 0 y menor a 999 !*");

                                        }
                                        
                                    } while (ingreso < 1 || ingreso > 999 );

                                    {

                                        pedido_individual.Enqueue(ingreso);
                                        total = pedido_individual.Count;
                                        if (total == 8)
                                        {
                                            Console.WriteLine("                   Se cumplieron las 8hr. Se termino el turno.");
                                            break;
                                        }
                                        else
                                            i++;
                                    }

                                }

                                ///opciones
                                ///
                                /// 
                                /// 
                                ///
                                int opcion_3;
                                ArrayList listadoarray = new ArrayList(pedido_individual);
                                
                                do
                                {
                                    Console.WriteLine("              ");


                                    Console.WriteLine("                             MEÚ OPCIONES                 \n" +
                                                      "                    ---------------------------------      \n" +
                                                      "                   [ 1 - Borrar pedidos.                ]  \n" +
                                                      "                   [ 2 - Listar todos los pedidos.      ]  \n" +
                                                      "                   [ 3 - Listar primer pedido.          ]  \n" +
                                                      "                   [ 4 - Listar ultimo pedido.          ]  \n" +
                                                      "                   [ 5 - Mostrar total de pedidos.      ]  \n" +
                                                      "                   [ 6 - Borrar toda bandeja de pedidos.]  \n" +
                                                      ""
                                                       );
                                   

                                    opcion_3 = Convert.ToInt32(Console.ReadLine());



                                    if (opcion_3 == 1)
                                    {


                                        Console.WriteLine("                   Indique la posicion del pedido que desea borrar");
                                        int borrar = Convert.ToInt32(Console.ReadLine());
                                        listadoarray.RemoveAt(borrar);
                                        listadoarray.Insert(borrar, "BORRADO");
                                        Console.WriteLine(" - El pedido ha sido borrado, verifique nuevamente listando todos los pedidos -");




                                    }

                                    else if (opcion_3 == 2)
                                    {

                                        for (int f = 1; f < listadoarray.Count; f++)  // opcion pedir listar los pedidos
                                        {



                                            Console.WriteLine("                   El pedido n°{0} fue el - '{1}'", f, listadoarray[f]);


                                        }

                                    }
                                    else if (opcion_3 == 3)

                                        Console.WriteLine("                   El primer pedido es '{0}'", listadoarray[1]);
                                    else if (opcion_3 == 4)

                                    {


                                        Console.WriteLine("                   El ultimo pedido es el '{0}'", listadoarray[7]);


                                    }


                                    else if (opcion_3 == 5)
                                    {
                                        int totalfinal = pedido_individual.Count;
                                        Console.WriteLine("                   Hay un total de '{0}' pedidos.", totalfinal);
                                    }
                                    else if (opcion_3 == 6)
                                    {
                                        Console.WriteLine("      Usted borro toda la bandeja. Para volver a comenzar reinicie el Programa.");

                                        listadoarray.Clear();
                                        break;
                                    }
                                   
                                } while (opcion_3 != 0);
                                Console.WriteLine("adios.");

                            }
                            else if ((dia == "sabado"))
                                horas_laborables = 5;
                            else if (dia == "domingo")

                            {
                                Console.WriteLine(" Dom no se trabaja. Adiós");
                                Environment.Exit(0);
                            }

                        }

                        else if (opcion_2 == "n" || opcion_2 == "N")
                        {
                            Console.WriteLine(" Adiós.");
                            Environment.Exit(0);
                        }
                        

                    }

                    break;
                case 2:
                    {

                    }
                    break;
               

                   
                }

                
        }

                    public static void Funcion_barra_cargando(string medio)
                    {
                        for (int n = 0; n < 40; n++)
                        {
                            if (n == 10)
                            {
                                Thread.Sleep(100);
                            }
                            else if (n == 15)
                            {
                                Thread.Sleep(100);
                            }

                            else if (n == 20)
                            {
                                Thread.Sleep(100);
                            }
                            else if (n == 28)
                            {
                                Thread.Sleep(100);

                            }
                            else if (n == 33)
                            {
                                Thread.Sleep(000);

                            }
                            Console.Write(medio);

                        }

                    }
            }

}
