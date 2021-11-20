using System;
using System.Threading;
using System.Collections;

namespace Servidor_de_vuelos
{
    public class Program

    {
        
        public static void Main(string[] args)
        {

            //variables a utilizar:
            
            string destino1 = "Chile";
            string destino2 = "Uruguay";       
            string destino3 = "Brasil";
            string destino4 = "Bolivia";        //destinos de viaje
            string destino5 = "Peru";
            string destino6 = "Paraguay";

            double costo_base_a = 12000.00;
            double costo_base_b = 15500.00;        //declaracion de las variables de precio para la funcion de costos.
            double costo_base_c = 20000.00;


            DateTime fecha_inicio;                   //declaramos la variable en fecha datetime para almacenar la fecha que ingresa el usuario.
            DateTime hora_actual = DateTime.Now;
            DateTime fecha_actual = DateTime.Now;   // la fecha actual a usar segun necesitemos dia, mes, año.

                                                    

            Stack prox_vuelo = new Stack();
            prox_vuelo.Push("Paraguay");        
            prox_vuelo.Push("Peru");
            prox_vuelo.Push("Bolivia");             //pila acumulando los destinos para luego sacarlos como opcion y el usuario determine si o no acepta.
            prox_vuelo.Push("Brasil");
            prox_vuelo.Push("Uruguay");
            prox_vuelo.Push("Chile");

            string respuesta;                       //respuesa para almacenar el "si" o "no" del usuario en vuelo low cost.
            string destino;
            int seleccion;
            int año, mes, dia;
            int opcion;

                


            Console.WriteLine("************************************************\n" +
                              "* {0}                    {1}*\n" +
                              "*                                              *\n" +
                              "*   Bienvenido al Servidor de  Vuelos I.F.T.S  *\n" +
                              "*                                              *\n" +
                              "*      International Flight Turist Sky         *\n" +
                              "*                                              *\n" +
                              "************************************************\n"+ 
                              "", fecha_actual.ToString("dd /MM/yyyy"), hora_actual.ToString("hh:mm:ss tt")); // hora actual en que se usa el pgm.

            Console.WriteLine("    Seleccione una de las opciones disponibles\n" +
                              "      --------------------------------------\n" +
                              "    [ 1 - Ver próximos destinos             ]     \n" +      //pantalla de inicio con opciones de interfaz
                              "    [ 2 - Ver vuelos Low Cost               ]     \n" +
                              "    [ 5 - Salir                             ]     ");

            Console.WriteLine();
            opcion = Convert.ToInt16(Console.ReadLine());                 //variable almacena el ingreso de opcion del usuario          
           
            if (opcion == 1)

            {
                 Console.WriteLine("  1.{0}  -  2.{1}  -  3.{2}  \n" +                                  //se muestran los destinos numerados para elegir por usuario
                                  "                       \n" +
                                  "  4.{3}  -  5.{4}  -  6.{5}\n" +
                                  "", destino1, destino2, destino3, destino4, destino5, destino6);
                
                Console.WriteLine(" Seleccione destino.");
                seleccion = Convert.ToInt16(Console.ReadLine());
                if (seleccion == 1)
                    Console.WriteLine("     Su selección fue : {0}  ", destino1);
                else if (seleccion == 2)
                    Console.WriteLine("     Su selección fue : {0}  ", destino2);
                else if (seleccion == 3)
                    Console.WriteLine("     Su selección fue : {0}  ", destino3);
                else if (seleccion == 4)
                    Console.WriteLine("     Su selección fue : {0}  ", destino4);
                else if (seleccion == 5)
                    Console.WriteLine("     Su selección fue : {0}  ", destino5);
                else if (seleccion == 6)
                    Console.WriteLine("     Su selección fue : {0}  ",destino6);
                Console.WriteLine();
                Console.WriteLine("     ┌──────────────────────────────┐");
                Console.WriteLine("     | INGRESO DE LA FECHA DE VIAJE |");
                Console.WriteLine("     └──────────────────────────────┘ ");
                Console.WriteLine();

                //codigo para seleccion de fecha de viaje y calculo de cant de dias 

                Console.WriteLine("             Seleccione el mes ");
                Console.WriteLine("             ───────────────── ");
                Console.WriteLine("   ┌─────┐    ┌─────┐    ┌─────┐    ┌─────┐  \n" +
                                  " 1 │ Ene │  2 │ Feb │  3 │ Mar │  4 │ Abr │  \n" +
                                  "   └─────┘    └─────┘    └─────┘    └─────┘  \n" +
                                  "   ┌─────┐    ┌─────┐    ┌─────┐    ┌─────┐  \n" +
                                  " 5 │ May │  6 │ Jun │  7 │ Jul │  8 │ Ago │  \n" +
                                  "   └─────┘    └─────┘    └─────┘    └─────┘  \n" +
                                  "   ┌─────┐    ┌─────┐    ┌─────┐    ┌─────┐  \n" +
                                  " 9 │ Sep │ 10 │ Oct │ 11 │ Nov │ 12 │ Dic │  \n" +
                                  "   └─────┘    └─────┘    └─────┘    └─────┘  \n" +
                                  "                                             ");

                do                                    //bucle que pide ingreso de fecha de viaje, en caso de ingresar algo mal, vuelve a preguntar                                                              
                {
                    Console.WriteLine("Mes:");
                    mes = Convert.ToInt32(Console.ReadLine());          //pide primero el mes de viaje
                    Console.WriteLine("     Ingrese el dia que desea viajar");
                    dia = Convert.ToInt32(Console.ReadLine());             //pide el dia

                    Console.WriteLine("     Por último ingrese el año");
                    año = Convert.ToInt32(Console.ReadLine());              //y el año
                    Console.WriteLine();
                    fecha_inicio = new DateTime(año, mes, dia);  //esta variable almacena los 3 datos ingresados y los acomoda en modo fecha con el "datetime"

                    if (fecha_inicio < fecha_actual)            //este if responde ante el error de ingresar una fecha menor a la actual
                        Console.WriteLine(" * ERROR * la fecha no puede ser menor a la actual.\n" +
                                          " Por favor Ingrese una fecha válida");

                    else if (fecha_inicio > (fecha_actual.AddMonths(6)))            //este if responde al error de ingresar una fecha muy lejana, como toda aerolinea
                                                                                    //no deja elegir fechas superiores a 6meses. 
                                                                                         // la clausula es: si la fecha de viaje es mayor a : la fecha de hoy + 6 meses, error.

                        Console.WriteLine(" * ERROR * La Aerolinea no presta servicio con fechas superiores a 6 meses de la fecha actual.\n" +
                                            "   Por favor Ingrese una fecha válida ");
                        Console.WriteLine(); // estos saltos de linea son esteticos
                }
                while (fecha_inicio < fecha_actual || fecha_inicio > (fecha_actual.AddMonths(6))); //la condicion del bucle antes mencionada
                {
                    Console.WriteLine(("     La fecha seleccionada fue: " + fecha_inicio.ToString(" dd/MM/yyyy"))); // si no hay errores en elegir la fecha, se muestra la misma

                }
              
                Console.WriteLine(" Buscando Vuelos...");   
                string medio = "█";                             //variable string con un simbolo que va a servir visualmente como barra de carga             
                Funcion_barra_cargando(medio);                  //funcion de la barra que carga
                Console.WriteLine(" 100%");                     //estetico, termina la barra y muestra el %
                Console.WriteLine();
               
                double dias = (fecha_inicio - fecha_actual).TotalDays;  //variable que determina la cantidad de dias proximo a la fecha elegida de vuelo
                                                                        //es la resta entre la fecha elegida, la actual, y el .Totaldays nos devuelve los dias

                string respuesta2; //variable que almacena la respuesta elegida dentro del proximo switch

                switch (mes)       
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        {

                            Console.WriteLine("     Cantidad de dias al destino {0} \n"+
                                "", Math.Round(dias));
                            if (dias < 90)
                                Console.WriteLine("   Usted eligio fechas en periodo de temporada alta y \n" +
                                    "   en rango menor a los 3 meses (el precio final puede verse afectado).\n" +
                                    "   Le recordamos que para reducir costos seleccionen reservas \n"+
                                    "   con periodos mayor a 3 meses.\n"+
                                    "   El costo final del pasaje es  : ${0:N2} ARS\n"+
                                    "", temporada_alta(costo_base_c) * 1.15);
                            else
                                Console.WriteLine("     Por seleccionar una fecha superior a los 3 meses, el pasaje mantendra su costo base.\n"+
                                    "     El Costo Final del pasaje: ${0} ARS\n"+
                                    "", temporada_baja(costo_base_a));

                            Console.WriteLine("     Desea continuar? S/N");
                            respuesta2 = Convert.ToString(Console.ReadLine());
                            if (respuesta2 == "s")
                            {


                                Seleccion_asientos();
                            }
                            else
                                Console.WriteLine(" Adiós");
                          
                        }
                        break;


                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        {

                            Console.WriteLine("     Cantidad de dias al destino {0} \n" +
                                "", Math.Round(dias));

                            {
                                if (dias > 90)
                                    Console.WriteLine("     Usted posee un descuento del 25% en su pasaje por programarlo en plazo superior a 3 meses.\n"+
                                        "       El Costo Final del pasaje es : ${0:N2} ARS", temporada_baja(costo_base_b) - (temporada_baja(costo_base_b) * 0.25));
                                else
                                    Console.WriteLine("     El Costo Final del pasaje: ${0:N2} ARS", temporada_baja(costo_base_b));
                            }

                            Console.WriteLine("     Desea continuar? S/N");
                            respuesta2 = Convert.ToString(Console.ReadLine());
                            if (respuesta2 == "s")
                            {


                                Seleccion_asientos();
                            }
                            else
                                Console.WriteLine(" Adiós");

                           

                        }
                
                        break;

                    case 9:
                    case 10:
                    case 11:
                    case 12:

                        {

                            Console.WriteLine("     Cantidad de dias al destino {0} \n" +
                                 "", Math.Round(dias));

                            {
                                if (dias > 90)
                                    Console.WriteLine("     Usted posee un descuento del 25% en su pasaje por programarlo en plazo superior a 3 meses.\n"+
                                        "       El Costo Final del pasaje es : ${0:N2} ARS", temporada_baja(costo_base_a) - (temporada_baja(costo_base_a) * 0.25));
                                else
                                    Console.WriteLine("     El Costo Final del pasaje: ${0:N2} ARS", temporada_baja(costo_base_a));
                            }
                            Console.WriteLine("     Desea continuar? S/N");
                             respuesta2 = Convert.ToString(Console.ReadLine());
                            if (respuesta2 == "s")

                                Seleccion_asientos();
                            else
                                Console.WriteLine(" Adiós");
                        }

                        break;

                    default:

                        break;
                }


            }

            else if (opcion == 2)
            
            {
                Console.WriteLine("   Usted selecciono un VUELO LOW COST.\n"+
                    "   Su vuelo en promoción tiene fecha de embarque hoy mismo,\n" +
                    "   (con aproximadamente 5 horas posteriores a la actual) \n" +
                    "   y no admite equipaje extra.\n"+
                    "");
                

                
                DateTime Hora_de_vuelo = hora_actual.AddHours(5);
                Console.WriteLine();
                Console.WriteLine("     La hora del vuelo es a las: {0} , del dia {1}", Hora_de_vuelo.ToString("hh:mm:ss"), Hora_de_vuelo.ToString("dd/MM/yyyy"));

                for (int i = 0; i < 6; )
                {
                    do
                    {
                        destino = (string)prox_vuelo.Pop();
                        Console.WriteLine("     El destino siguiente low cost es: {0}, acepta? s/n", destino);
                        respuesta = Convert.ToString(Console.ReadLine());
                       
                    } while (respuesta != "s");
                        if(destino == "Paraguay" || destino == "Chile")
                        Console.WriteLine(" El Costo Final del pasaje: ${0:N2} ARS", vuelo_lowcost(costo_base_a));
                        else if (destino == "Peru" || destino == "Bolivia")
                        Console.WriteLine(" El Costo Final del pasaje: ${0:N2} ARS", vuelo_lowcost(costo_base_b));
                        else if (destino == "Brasil" || destino == "Uruguay")
                        Console.WriteLine(" El Costo Final del pasaje: ${0:N2} ARS", vuelo_lowcost(costo_base_c));
                    break;


                }


                Console.WriteLine("     Proceda a la seleccion de asientos disponibles");

                Seleccion_asientos();


            }


            if (opcion == 5)

            {
                Console.WriteLine("Adios.");
                Environment.Exit(0);
            }

            Console.WriteLine();
            
     
        }


        public static void Funcion_barra_cargando(string medio )
        {
            for (int n = 0; n < 40; n++)
            {
                if (n == 10)
                {
                    Thread.Sleep(1000);
                }
                else if (n == 15)
                {
                    Thread.Sleep(2000);
                }

                else if (n == 20)
                {
                    Thread.Sleep(1000);
                }
                else if (n == 28)
                {
                    Thread.Sleep(1000);

                }
                else if (n == 33)
                {
                    Thread.Sleep(1000);

                }
                Console.Write(medio);
               
            }
            
        }

        public static double vuelo_lowcost(double costo_base)

        {
            double costo_final = costo_base * 1.10;

            
            return costo_final;
        }
        

        public static double temporada_baja(double costo_base)
             
            {
            
            double costo_final = costo_base * 1.65;
            
            return costo_final;

            }

        public static double temporada_alta(double costo_base)

        {

            double costo_final = costo_base * 1.65;

            return costo_final;

        }

        public static void Seleccion_asientos ()
        {

              
            string a = "  0A", b = "  1B", c = "  2C", d = "  3D", e = "  4E", f = "  5F", g = "  6G", h = "  7H", i = "  8I", j = "  9J", k = " 10K", l = " 11L", m = " 12M", o = " 13N", p = " 14O", q = " 15P", r = " 16Q", s = " 17R";
            int n;
            string medio2 = "█";
            ArrayList asientos_izq = new ArrayList();
            asientos_izq.Add(a);
            asientos_izq.Add(b);
            asientos_izq.Add(c);
            asientos_izq.Add(d);
            asientos_izq.Add(e);
            asientos_izq.Add(f);
            asientos_izq.Add(g);
            asientos_izq.Add(h);
            asientos_izq.Add(i);
            asientos_izq.Add(j);
            asientos_izq.Add(k);
            asientos_izq.Add(l);
            asientos_izq.Add(m);
            asientos_izq.Add(o);
            asientos_izq.Add(p);
            asientos_izq.Add(q);
            asientos_izq.Add(r);
            asientos_izq.Add(s);


            Console.WriteLine("\n" +
                              "      ┌──────────────────────────────┐\n" +
                              "      |     Seleccion de Asientos    |\n" +
                              "      └──────────────────────────────┘\n" +
                              "\n" +
                              "\n" +
                              "        Identificacion de Asientos\n" +
                              "        ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");



            for (int x = 0; x < asientos_izq.Count; x++)
            {

                if (x % 3 == 0)
                {
                    
                    Console.WriteLine("");
                }
                Console.Write("    ║{0} ║",asientos_izq[x]);
                Console.Write("  ");
            }

            Console.WriteLine("   \n" +
                              "    ");

            Console.WriteLine("");
            Console.WriteLine(" Cargando Disponibilidad de asientos...");
            Funcion_barra_cargando(medio2);      //funcion de la barra que carga
            Console.WriteLine(" 100%");
            Console.WriteLine();

            {
                Random ocupados = new Random();
                int extremo1 = ocupados.Next(0, 5);
                int extremo2 = ocupados.Next(10, 18);
             
                
                for (int x = 0; x < asientos_izq.Count; x++)
                {
                    

                    if (x >extremo1 && x <extremo2)
                    {
                        asientos_izq.RemoveAt(x);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(x, "[■]");


                    }
                    else
                    {
                        asientos_izq.RemoveAt(x);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(x, "[ ]");

                    }

                    

                }

                Console.WriteLine("  [■] Asiento Reservado - [ ] Asiento Disponible \n" +
                                  "");
                for (int x = 0; x < asientos_izq.Count; x++)
                {

                    if (x % 3 == 0)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write("       {0}", asientos_izq[x]);
                    Console.Write("  ");
                }
                Console.WriteLine(" \n" +
                    "");

                Console.WriteLine("     Escriba sólo el numero del asiento\n"+
                                  "     ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                
                n = Convert.ToInt32(Console.ReadLine());

                for (int x = 0; x < asientos_izq.Count; x++)
                {
                    if (x == n)
                    {
                        asientos_izq.RemoveAt(n);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(x, "[X]");
                    }

                }
                Console.WriteLine("");
                /*
                
                */
               
                   
            }



            Console.WriteLine("Su Seleccion Fue : \n" +
                                   "");
            Console.WriteLine("");

            for (int x = 0; x < asientos_izq.Count; x++)
            {

                if (x % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write("       {0}", asientos_izq[x]);
                Console.Write("  ");
                
            }

            Console.WriteLine(" \n" +
                "\n" +
                "\n" +
                "      ESPERAMOS QUE DISFRUTE DE SU VIAJE !!!");
         
            

            


        }

    }
}
