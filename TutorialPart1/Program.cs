// 61 - Parámetros por valor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 61 - Parámetros por valor
namespace ParametrosValor1
{
    class Program {
        //Confeccionar un método que reciba un entero entre 1 y 5 y retorne el valor en castellano.
        /*static void Main(string[] args){
            Console.Write(nameNumberSpanish(90));
        }*/
        public static string nameNumberSpanish(int number) {
            string returnNumber="";
            switch (number) {
                case 1:
                    returnNumber = "One";
                    break;
                case 2:
                    returnNumber = "Two";
                    break;
                case 3:
                    returnNumber = "Three";
                    break;
                case 4:
                    returnNumber = "Four";
                    break;
                case 5:
                    returnNumber = "Five";
                    break;
                default:
                    returnNumber = "Out range";
                    break;
            }
            return returnNumber;
        }
        
    }
}
namespace ParametrosReferencia1
{
    class Program
    {
        public void Intercambiar(int valor1, int valor2)
        {
            int aux = valor1;
            valor1 = valor2;
            valor2 = aux;
        }

        /*static void Main(string[] args)
        {
            Program p = new Program();
            int x1 = 10;
            int x2 = 20;
            Console.WriteLine("Los valores antes de intercambiar son " + x1 + " " + x2);
            p.Intercambiar(x1, x2);
            Console.WriteLine("Los valores después de intercambiar son " + x1 + " " + x2);
            Console.ReadKey();
        }*/
    }
}
namespace ParametrosNombre1
{
    class Program
    {
        public void Imprimir(string mensaje, int columna, int fila)
        {
            Console.SetCursorPosition(columna, fila);
            Console.WriteLine(mensaje);
        }

        /*static void Main(string[] args)
        {
            Program ob1 = new Program();
            ob1.Imprimir(fila: 12, columna: 40, mensaje: "Hola Mundo");
            ob1.Imprimir(mensaje: "Fin", fila: 23, columna: 5);
            Console.ReadKey();
        }*/
    }
}

// 72 - Enumeraciones
namespace Enumeracion1
{
    class JuegoDeCartas
    {
        public enum TipoCarta { oro, basto, copa, espada };

        private TipoCarta cartaActual;

        public void Imprimir()
        {
            cartaActual = TipoCarta.oro;
            Console.WriteLine("El valor actual es:" + cartaActual);
            cartaActual = TipoCarta.espada;
            Console.WriteLine("El valor actual es:" + cartaActual);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeCartas jc = new JuegoDeCartas();
            jc.Imprimir();
        }
    }
}
