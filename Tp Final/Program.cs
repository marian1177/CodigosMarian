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
         * tiene unos using distinguidos como como el  System.Globalization y el System.Linq para obtener dia de la 
         * semana en español y para consultas en arrays respectivamente.
         * El programa funciona tomando fecha real actual según sea dia de semana o fin de semana, es decir que,
         * si se corre el pgm dia de semana permite agregar 8 pedidos (simulando 1 pedido por hora) y si se corre
         * un sab permite solo 4 pedidos (simulando medio dia de trabajo) y dom envia msj de " Dia no laborable".
         * Delimitaciones Controladas : - No Prosigue si el dia actual es "domingo"
         *                               - Solo toma numeros de pedido en el rango de 0 a 999
         *                               - Solo admite 8 pedidos lun a vier. Sab 4 pedidos.
         *                               - Listar todos los pedidos y Borrarlos individualmente Usan un mismo array
         *                                 para mantener coherencia de datos manipulados
         *                               - Listar primer pedido, ultimo pedido, listar 3 mayores, menor a mayor y total
         *                                 usan array desvinculado para mantener constancia de datos.
         *                                 
         */

        {
            int ingreso;                        //variable que almacena el número de pedido ingresado
            int horas_laborables;               // variable que determina cuantos pedidos se pueden ingresar
            DateTime dia_actual = DateTime.Now; // variable que determina que dia de la semana es
            int opcion;                         //variable que almacena ingreso de interfaz : Inicio
            int total;                          //variable para almacenar el total de ingresos/pedidos
            string medio = "█";                 // string para el método de "barra de carga"
          
     


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
                              "                  [ 1 - Crear bandeja de pedidos.     ]\n" +      // Primera pantalla de inicio con opciones de interfaz
                              "                  [ 2 - Salir.                        ] " +
                              " \n"  +
                              " \n" +
                              "");

            string dia = dia_actual.ToString("dddd", new CultureInfo("es-ES")); //obtención del string del dia de la semana
            Console.WriteLine("       [Horas activas de la plataforma : 8 hrs Diarias Lun a Vier] \n" +
                "");
            Console.WriteLine("         Sab: 4 hrs                -           Dom :  Plataforma inactiva \n" +
                "");
            Console.WriteLine("                            Hoy es: {0}\n" +
                "", dia);
            Console.WriteLine("                 Estadistica del sistema: 1 pedido por hora\n" +
                "");
            Queue pedido_individual; //declaracion la estructura FIFO/cola
            
            
            opcion = Convert.ToInt16(Console.ReadLine());  
            switch (opcion)                 //switch que separa la opcion de ingreso al programa con la opcion de Salir
            {
                case 1:

                    {
                        Console.WriteLine("Creando bandeja de pedidos...");
                        Funcion_barra_cargando(medio);
                        Console.WriteLine(" 100%");

                        pedido_individual = new Queue(); // asignación a la estructura Cola
                        Console.WriteLine("Bandeja de pedidos creada.");

                     

                        Console.WriteLine("                   Procede a agregar los pedidos? s-S/n-N");

                        string opcion_2 = Convert.ToString(Console.ReadLine());
                        if (opcion_2 == "s" || opcion_2 == "S") 
                        {

                            if (dia == "lunes" || dia == "martes" || dia == "miércoles" || dia == "jueves" || dia == "viernes")
                            {
                                horas_laborables = 8; 

                                for (int i = 1; i < horas_laborables;)     //Bucle que pide ingreso de datos/nro de pedidos al usuario
                                {
                                    do
                                    {
                                          Console.WriteLine("                   Ingrese el numero del nuevo pedido (mayor a 0 y menor a 999) y presione ENTER");
                                            ingreso = Convert.ToInt32(Console.ReadLine());

                                        if (ingreso < 0 || ingreso > 999)   //mensaje de error fuera de rango
                                        {

                                            Console.WriteLine("                   *¡Error pedido fuera de rango, no se tomara en cuenta, ingrese un pedido mayor a 0 y menor a 999 !*");

                                        }

                                    } while (ingreso < 1 || ingreso > 999); //delimitacion de rango

                                    {

                                        pedido_individual.Enqueue(ingreso);  //vinculación de los ingresos del usuario a cada dato de la Cola
                                        total = pedido_individual.Count;    //variable que determina el limite de ingresos
                                        if (total == 9)
                                        {
                                            Console.WriteLine("                   Se cumplieron las 8hr. Se termino el turno.");
                                            break;
                                        }
                                        else
                                            i++;            // Si no se llena la estructura sigue el bucle
                                    }

                                }

                                int opcion_3;   //tipificación de la nueva variable de la siguiente interfaz
                                
                                int contador;  //tipificación de la variable que calcula la posición de los pedidos

                                ArrayList listadoarrayA = new ArrayList(pedido_individual);  //IMPORTANTE: CONVERSION DE LA ESTRUCTURA FIFO A UN ARRAYLIST
                                do 
                                {
                                    Console.WriteLine("");
                                    


                                    Console.WriteLine(" _________________________________________________________________________________________________\n" +
                                                      "                                                                    \n" +
                                                      "                                      MEÚ OPCIONES                            \n" +
                                                      "                               ---------------------------------              \n" +
                                                      "                           [ 1 - Listar todos los pedidos          ]          \n" +
                                                      "                           [ 2 - Listar primer pedido.             ]          \n" +
                                                      "                           [ 3 - Listar ultimo pedido.             ]          \n" +
                                                      "                           [ 4 - Mostrar total de pedidos.         ]          \n" +
                                                      "                           [ 5 - Ordenar pedidos de Menor a Mayor  ]          \n" +
                                                      "                           [ 6 - Obtener los 3 pedidos mas grandes ]          \n" +
                                                      "                           [ 7 - Borrar pedidos individualmente    ]          \n" +
                                                      "                           [ 8 - Borrar toda bandeja de pedidos.   ]          \n" +
                                                      "__________________________________________________________________________________________________\n" +                               
                                                      "" );
                                    

                                     opcion_3 = Convert.ToInt32(Console.ReadLine()); //declaración de la variable opcion 



                                    if (opcion_3 == 7)      // Opción que borra pedidos. 
                                    {
                                        

                                        Console.WriteLine("                   Indique la posicion del pedido que desea borrar");
                                        int borrar = Convert.ToInt32(Console.ReadLine());
                                        if (borrar >=  1 && borrar <=8)    // Al ingreso del usuario le resta 1 porque el array comienza en 0
                                                                           // y genere el numero correcto
                                            borrar--;

                                        listadoarrayA.RemoveAt(borrar);     // Método que borra el dato original y lo remplaza con un string
                                        listadoarrayA.Insert(borrar, "BORRADO");
                                        Console.WriteLine(" - El pedido ha sido borrado, verifique nuevamente listando todos los pedidos -");




                                    }

                                    else if (opcion_3 == 1)
                                    {
                                       
                                        contador = 1;  // Declaración de la variable para usar como "posicion" del pedido.
                                        for (int f = 0; f < listadoarrayA.Count; f++)  // Bucle que recorre el array 

                                        { 

                                            Console.WriteLine("                          El pedido n°{0} fue el - '{1}'", contador, listadoarrayA[f]);
                                            contador++;

                                        }

                                    }
                                    else if (opcion_3 == 2)
                                    {
                                        ArrayList listadoarray = new ArrayList(pedido_individual); //Encapsulamiento del array para mantener constancia del dato
                                        Console.WriteLine("                           El primer pedido es '{0}'", listadoarray[0]);
                                    }
                                    else if (opcion_3 == 3)

                                    {
                                        ArrayList listadoarray = new ArrayList(pedido_individual); //Encapsulamiento del array para mantener constancia del dato

                                        Console.WriteLine("                           El ultimo pedido es el '{0}'", listadoarray[7]);


                                    }


                                    else if (opcion_3 == 4)
                                    {
                                        int totalfinal = listadoarrayA.Count;         //Método que cuenta la cantidad de datos que componen la estructura
                                        Console.WriteLine("                           Hay un total de '{0}' pedidos.", totalfinal);

                                    }
                                    else if (opcion_3 == 5)
                                    {
                                        ArrayList listadoarray = new ArrayList(pedido_individual);  //Encapsulamiento del array para mantener constancia del dato
                                        listadoarray.Sort();                                // Método que ordena de menor a mayor
                                        for (int f = 0; f < listadoarray.Count; f++)
                                            Console.WriteLine("                           '{0}'", listadoarray[f]);


                                    }


                                    else if (opcion_3 == 6)
                                    {
                                        ArrayList listadoarray = new ArrayList(pedido_individual);//Encapsulamiento del array para mantener constancia del dato
                                        listadoarray.Sort();                                      //Se ordena de menor a mayor y con el método Get enumerator
                                                                                                  //se toma un rango de los últimos tres datos. 

                                        IEnumerator mayores = listadoarray.GetEnumerator(5, 3);

                                        while (mayores.MoveNext())
                                        {
                                            Object obj = mayores.Current;
                                                                                                    // El breve bucle que muestra la salida

                                            Console.Write("               -   {0}   -", obj);
                                        }
                                        Console.WriteLine("\n" +
                                                          "");
                                        Console.WriteLine("Ingrese el número de cualquiera de estos tres pedidos para saber cuando fue ingresado.");
                                        int ingreso3 = Convert.ToInt32(Console.ReadLine());
                                        ArrayList arrayB = new ArrayList(pedido_individual); //nuevo array encapsulado   
                                        Console.WriteLine("                           El pedido {0} fue el pedido n° {1}", ingreso3, arrayB.IndexOf(ingreso3) + 1);
                                                                                            //con el método indexof, se obtiene la posición del dato a buscar.
                                    }





                                    else if (opcion_3 == 8)
                                    {
                                        
                                        Console.WriteLine("                Usted borro toda la bandeja. Para volver a comenzar reinicie el Programa.");

                                        listadoarrayA.Clear();              //Método que borra todos los datos del array
                                        break;
                                    }
                                   
                                } while (opcion_3 != 0);                    
                                Console.WriteLine("                           adios.");

                            }
                            else if ((dia == "sabado"))
                                horas_laborables = 5;
                            else if (dia == "domingo")

                            {
                                Console.WriteLine("                           Dom no se trabaja. Adiós");
                                Environment.Exit(0);
                            }

                        }

                        else if (opcion_2 == "n" || opcion_2 == "N")
                        {
                            Console.WriteLine("                           Adiós.");
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
