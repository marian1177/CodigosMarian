using System;
using System.Collections;



namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida al usuario 6 números enteros y luego los muestre en orden contrario,
            utilizando una pila.*/


            int numeros; //se declara el tipo de dato de los elementos
            Console.WriteLine("Ingrese el primer numero");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            int n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el sexto numero");
            int n6 = Convert.ToInt32(Console.ReadLine());

            Stack miPila = new Stack(); //se declara la pila
            miPila.Push(n1);
            miPila.Push(n2);    
            miPila.Push(n3);
            miPila.Push(n4);
            miPila.Push(n5);
            miPila.Push(n6);

            for (byte i = 0; i < 6; i++) /*recorre la pila. Adicional: si el limite del recorido
                                          * es mayor a los objetos de la pila, tira "error empty stack"
                                          * porque no tiene mas objetos a sacar*/

            {
            numeros = (int)miPila.Pop(); //extrae los elementos apilados del string del ultimo-abajo hacia arriba
            Console.WriteLine(numeros); //muestra en pantalla el resultado de la extraccion
            }

}               
}
}
