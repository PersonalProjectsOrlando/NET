using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatosImplicitos1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter number: ");
            int limit = int.Parse(Console.ReadLine());
            int[] arreglo = new int[limit];
            Random random = new Random();
            var countUpper100 = 0; 
            for (var i=0; i < arreglo.Length ;i++) {
                arreglo[i]=random.Next(1000);
            }
            foreach (var number in arreglo) {
                Console.Write(number+" ");
                if (number>=100) {
                    countUpper100++;

                }
            }
            Console.WriteLine("");
            Console.Write("Total Number > 100: "+countUpper100);        }
    }
}