using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoExcepciones
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public int Numerador { get => numerador; set => numerador = value; }
        public int Denominador { get => denominador; set => denominador = value; }

        public string MostrarFraccion()
        {
            string fracc = numerador+"/"+denominador;
            return fracc;
        }

        public double valorFraccion()
        {
            //DivideByZeroException
            double resultado;
            try
            {
                resultado = numerador / denominador;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("El resultado es imposible de mostrar, porque el denominador es actualmente un 0, y la división por 0, no está definida");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                resultado = 0;
            }
            finally
            {
                Console.WriteLine("El Código sigue su ejecución...");
            }
            
            return resultado;
        }
    }
}
