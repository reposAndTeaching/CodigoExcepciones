using System;
using System.Collections.Generic;

namespace CodigoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> miListaNumeros = new List<int>();

            miListaNumeros.Add(2);
            miListaNumeros.Add(5);
            miListaNumeros.Add(2001);

            Console.WriteLine("La lista tiene {0} elementos", miListaNumeros.Count);

            Console.WriteLine(miListaNumeros[0]);
            Console.WriteLine(miListaNumeros[1]);
            Console.WriteLine(miListaNumeros[2]);

            //Intento ejecutar un código que posiblemente podría caer una excepción
            //ArgumentOutOfRangeException
            try
            {
                Console.WriteLine(miListaNumeros[3]);
            }
            //si no puede ejecutar, directamente se ejecuta el catch que captura la excepción lanzada
            //si la excepción lanzada no se encuentra controlada, el código dejará de ejecutarse igualmente.
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("No se puede acceder a la posición");
                Console.WriteLine("La lista solo tiene {0} elementos", miListaNumeros.Count);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("El programa dejó de ejecutarse por alguna razon");
            }

            Console.WriteLine("El código a continuado luego del bloque try-catch");

            Console.WriteLine("****************");

            Fraccion nuevaFraccion = new Fraccion(4, 0);
            Console.WriteLine(nuevaFraccion.MostrarFraccion());
            Console.WriteLine("El resultado de la fracción es: {0}", nuevaFraccion.valorFraccion());
        }
    }
}
