using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo();
            rectangulo1.Lado1 = 5;
            rectangulo1.Lado2 = 10;
            Console.WriteLine("La superficie del rectángulo es:" +
                                rectangulo1.RetornarSuperficie());
            Console.WriteLine("El perímetro del rectángulo es:" +
                                rectangulo1.RetornarPerimetro());
            Console.ReadKey();
        }
    }
}
