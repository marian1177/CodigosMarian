using System;
using System.Collections;

namespace borrador
{
    class Program
    {
        static void Main(string[] args)


        {
            int contador = 3;
            string a = "L1", b = "M1", c = "L2", d = "L3", e = "M2";
            string n;
            ArrayList asientos_izq = new ArrayList();
            asientos_izq.Add(a);
            asientos_izq.Add(b);
            asientos_izq.Add(c);
            asientos_izq.Add(d);
            asientos_izq.Add(e);
            asientos_izq.Add("L4");
            asientos_izq.Add("1A");
            asientos_izq.Add("M3");
            asientos_izq.Add("L6");
            asientos_izq.Add("L7");
            asientos_izq.Add("M4");
            asientos_izq.Add("L8");
            asientos_izq.Add("L9");
            asientos_izq.Add("M5");
            asientos_izq.Add("L10");
            asientos_izq.Add("L11");
            asientos_izq.Add("M6");
            asientos_izq.Add("L12");

            Console.WriteLine("Seleccion de Asientos\n" +
                              "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

            for (int i = 0; i < asientos_izq.Count; i++)
            {
                
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(asientos_izq[i]);
                Console.Write("  ");
            }
            Console.WriteLine("   \n" +
                              "    ");
           
            Console.WriteLine(" ■ Asiento Reservado ");
            Console.WriteLine("[ ] Asiento Disponible");
            Console.WriteLine("");

            if (contador == 1)
            {

                for (int i = 0; i < asientos_izq.Count; i++)
                {

                    if (i % 2 == 0 || i>5)
                    {
                        asientos_izq.RemoveAt(i);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(i, " ■ ");


                    }
                    else
                    {
                        asientos_izq.RemoveAt(i);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(i, "[ ]");

                    }

                }
                for (int i = 0; i < asientos_izq.Count; i++)
                {

                    if (i % 3 == 0)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write(asientos_izq[i]);
                    Console.Write("  ");
                }

            }

            if (contador == 2)
                for (int i = 0; i < asientos_izq.Count; i++)
                {

                    if (i % 4 == 0 || i <5)
                    {
                        asientos_izq.RemoveAt(i);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(i, " ■ ");


                    }
                    else
                    {
                        asientos_izq.RemoveAt(i);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(i, "[ ]");

                    }

                }
            for (int i = 0; i < asientos_izq.Count; i++)
            {

                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(asientos_izq[i]);
                Console.Write("  ");
            }
            if (contador >=3)
                for (int i = 0; i < asientos_izq.Count; i++)
                {

                    if (i % 9 == 0 || i < 3)
                    {
                        asientos_izq.RemoveAt(i);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(i, " ■ ");


                    }
                    else
                    {
                        asientos_izq.RemoveAt(i);
                        asientos_izq.Remove(a);
                        asientos_izq.Insert(i, "[ ]");

                    }

                }
            for (int i = 0; i < asientos_izq.Count; i++)
            {

                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(asientos_izq[i]);
                Console.Write("  ");
            }

                Console.WriteLine("");
            Console.WriteLine("Escriba el asiento");
            n = Convert.ToString(Console.ReadLine());

            Console.WriteLine("el numero tecnico del asiento es: {0}", asientos_izq.IndexOf(n));





        }
    }
}
