using System;
using System.Collections;

namespace practika
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             string fichero;
             Console.WriteLine("ingrese el nombre del fichero para ver su contenido");
             fichero =Convert.ToString (Console.ReadLine());

             Stack texto = new Stack();
             texto.Push("Archivos confidenciales n°1 ");
             texto.Push("Archivos clasificados cia ");
             texto.Push("Archivos materiales");
             texto.Push("Archivos decasiflicados");
             texto.Push("Archivos de seguimiento");

             for (byte i = 0; i < 5; i++)
             {
                 fichero = (string)texto.Pop(); 
                 Console.WriteLine(fichero); 
             }

             ArrayList miLista = new ArrayList();
            miLista.Add("datos1");
            miLista.Add("datos2");
            miLista.Add("datos3");
            miLista.Add("datos5");
            miLista.Add("datos4");
            Console.WriteLine("el contenido es : ");
            for (byte x = 0;x<5;x++) //comienza de 0 como todo array, segun la cantidad lo corta
            
                Console.WriteLine(miLista[x]);
            
            Console.WriteLine(" Posicion z : {0}", miLista[z]);

            miLista.Insert(z, "zzzzz");

            Console.WriteLine("lo que se busca:zz esta en {0}", miLista.IndexOf("lo buscado"));

            miLista.Sort();
            miLista.Reverse();
            miLista.RemoveAt(posicion);
            miLista.Remove("lo que se borra, podria ser variable");

            
            int resultado1;
            Stack suma = new Stack();
            suma.Push(3);
            suma.Push(4);
            suma.Push(resultado1);
            suma.Push(5);
            suma.Push();
            suma.Push(+);
            suma.Push(3);

            for (byte x = 1;x<6;x++)
            */
            int n1,n2 ;
            Console.WriteLine("Ingrese 2 numeros a sumar");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = Convert.ToInt16(Console.ReadLine());


            suma(n1,n2);




        }
        public static void suma(int n1,int n2 )
        {
            Console.WriteLine("la suma de los valores ingresados es: {0}!",n1+n2 );
        }

    }
}
