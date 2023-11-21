using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda1
{
    delegate double Operation(int x1, int x2);
    class lambda
    {
        static void Main(string[] args)
        {
            PairsNumber();

            Console.WriteLine();
            int number = 3;
            Console.WriteLine($"{number} is pair?: {isPar(number)}");

            methodOperate();

        }
        static void PairsNumber()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> pares = numeros.Where(x => x % 2 == 0).ToList();
            foreach (int number in pares)
            {
                Console.Write(number + " ");
            }
        }
        static bool isPar(int number)
        {
            Func<int, bool> esPar = x => x % 2 == 0;
            bool result = esPar(number);
            return result;
        }
        public static double operate(int x1, int x2, Operation delegado)
        {
            return delegado(x1, x2);
        }
        static void methodOperate()
        {
            int a = 12;
            int b = 4;
            var suma = lambda.operate(a, b, (x, y) => { return x + y; });
            Console.WriteLine($"{a}+{b}: {suma}");
            var resta = lambda.operate(a, b, (x, y) => { return x - y; });
            Console.WriteLine($"{a}-{b}: {resta}");
            var multiplicate = lambda.operate(a, b, (x, y) =>
            {
                return a * b;
            });
            Console.WriteLine($"the multiplication of {a} and {b} is: {multiplicate}");
            var pow = lambda.operate(a, b, (x, y) =>
            {
                return Math.Pow(a, b);
            });
            Console.WriteLine($"The pow of {a} and {b} is: {pow}");  
        }
    }
}
