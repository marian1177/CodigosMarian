using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Analice el código ¿Qué hace este código? Realizar captura de pantalla del
            código con su resultado y análisis del mismo.*/


            //El codigo dibuja un triangulo equilatero de 7 (por la fila de  la variable declarada) niveles

        
            Console.Clear();
            for (int fila = 1; fila <= 7; fila++) //el primer for recorre la primera linea
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--) /* dentro de la primera linea
                                                                         * de codigo, este for dibuja los espacios
                                                                         * para llegar a la punta del triangulo.
                                                                         * son 7 espacios menos 1  que va ser el medio "*".
                                                                         * cuando llega a 0 sigue con el siguiente for*/
                    Console.Write(" ");

               for (int conta = 1; conta < (2 * fila); conta++) /* este for dibuja los *,una vez dado los espacios, 
                                                                  * mientras "conta" sea menor al doble de fila en la que se 
                                                                  * encuentra dibuja los  *  .*/
                   Console.Write("*"); //sigue en la misma linea sin salto

               Console.WriteLine(" ");/* una vez que "conta" supera la fila llegue a este salto para pasar a la siguiente linea
                                        * y repeir el ciclo*/
              

           }
            /* En caso de querer hacer un triangulo isosceles seria lo mismo casi modificando
               2 cosas: borrando la linea de espacios :
            for (int espacios = 7 - fila; espacios > 0; espacios--)
            y  la linea de asteriscos va a ser menor o igual a la fila. el codigo quedaria asi:
            
            for (int fila = 1; fila <= 7; fila++)
            {
              for (int conta = 1; conta <= (fila); conta++)

                    Console.Write("*");

               Console.WriteLine(" ");
            */
        }
    }
}
