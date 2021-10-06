using System;
using System.Collections;


namespace Ejercicios__Metodos
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int opcion;
            Stack mazo = new Stack();
            mazo.Push(10);
            mazo.Push(9);
            mazo.Push(1);
            mazo.Push(2);
            mazo.Push(3);
            mazo.Push(4);
            mazo.Push(6);
            mazo.Push(5);
            mazo.Push("comodin"); 
            mazo.Push(7);
            mazo.Push(8);
            //usamos 2 pilas distintas porque sino teniamos que usar una de 2 dimensiones 
            Stack palos = new Stack();
            palos.Push("oro");
            palos.Push("copa");
            palos.Push("copa");
            palos.Push("basto");
            palos.Push("copa");
            palos.Push("espada");
            palos.Push("oro");
            palos.Push("espada");
            palos.Push("comodin");
            palos.Push("oro");
            palos.Push("espada");
            Console.WriteLine("Usted encontro un mazo de cartas españolas");
            do
            {
                Console.WriteLine("******************************************************\n"+
                                   "Elija alguna de las siguientes opciones:\n" +
                                   "Opcion 1 :Cuenta cuantas cartas hay.(Count)\n" +
                                   "Opcion 2: Observar que numeros de cartas hay (GetType)\n" +
                                   "Opcion 3: Buscar si hay un comodin.(Contains)\n" +
                                   "Opcion 4: Observar la ultima carta del mazo.(peak)\n" +
                                   "Opcion 5: Ver el palo de cada carta (ToString)\n" +
                                   "Opcion 6: ToArray\n" +
                                   "Opcion 7: Get Enumerator\n" +
                                   "Opcion 8: Quemar el mazo y revisar.(Clear)\n" +
                                   "*****************************************************");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El mazo tiene un total de {0} cartas", mazo.Count);

                        break;

                    case 2:
                        Console.WriteLine("{0}",mazo.GetType());
                        break;
                    case 3:

                        Console.WriteLine(mazo.Contains("comodin"));
                       
                        break;
                    case 4:
                        Console.WriteLine("La última carta es: {0}", mazo.Peek()); //si se elige opcion 8 va a tirar stack empty error por vaciar todo

                        break;

                    case 5:

                        

                        string[] posiciones = { "primera: ", "segunda: ", "tercera: ", "cuarta: ", "quinta: ", "sexta: ", "septima: ", "octava: ", "novena: ", "decima: ", "decimaprimera: " };
                        string cartas; //un array para nombrar las posiciones de las cartas
                        for (byte a = 0; a < posiciones.Length; a++) //for para el array
                        {
                            cartas = (string)palos.Pop(); //extraccion de cada carta (de abajo hacia arriba, lo correcto seria usar queu y dequeue)

                            Console.Write(posiciones[a]); //primero la posicion

                            Console.WriteLine(cartas.ToString()); //luego muestra el palo de la carta

                        }

                        break;

                    case 6:
                        object[] listado = mazo.ToArray();
                        foreach (Object str in listado) /*cambiamos el "for" por foreach porque es mejor
                                                     * para recorrer una secuencia de datos*/
                        {
                            Console.WriteLine(str);
                        }

                        break;

                    case 7:

                        IEnumerator enumerador = mazo.GetEnumerator();
                        while (enumerador.MoveNext())
                        {
                            Console.WriteLine("Valor : {0}", enumerador.Current); /*detalle: si solo se poner ("xxxxxx",enumerador.current)
                                                                * no devuelve nada porque necesita {0} para concatenar
                                                                * los valores que va a mostrar*/
                        }
                        break;

                    case 8:

                        mazo.Clear();
                        palos.Clear();

                        Console.WriteLine("quedaron {0} cartas del mazo", mazo.Count);
                        break;
                }

                } while (opcion != 0) ;

            }   
   
    }
}
