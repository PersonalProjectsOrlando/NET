using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace PruebaClase1
{
    class Employee{
        string name;
        double salary;
        public void chargeDates() {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            //Console.WriteLine(name);
            Console.Write("Enter salary: ");
            salary = double.Parse(Console.ReadLine());
            //Console.WriteLine(salary);

        }
        public void showDates() {
            Console.WriteLine(name);
            Console.WriteLine(salary);
        }
        public void validateTax() {
            if (salary > 3000000)
            {
                Console.Write("must pay tax");
            }
            else {
                Console.Write("should not pay tax");
            }
        }
        /*public static void Main(String[] args) {
            Employee employee = new Employee();
            employee.chargeDates();
            employee.showDates();
            employee.validateTax();
        }*/

    }
}
namespace pruebaClasevector{
    using System;
    using System.Security.Cryptography;

    class Program
    {
        public static void Main(String[] args) {
            array();
        }
        static void array()
        {
            Random random = new Random();
            Console.Write("Enter length vector: ");
            int len = int.Parse(Console.ReadLine());
            Console.Write("Enter limit vector: ");
            int limit = int.Parse(Console.ReadLine());


            int[] numeros = new int[len];

            // Llenar el arreglo con números aleatorios
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(limit); // Generar números aleatorios 
            }

            Console.WriteLine("Números generados aleatoriamente:");
            ImprimirNumeros(numeros);

            // Ordenar el arreglo
            Array.Sort(numeros);

            Console.WriteLine("\nNúmeros ordenados:");
            ImprimirNumeros(numeros);
            minorNumber(numeros);
            biggerNumber(numeros);
        }

        static void ImprimirNumeros(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void biggerNumber(int[] arr) {
            double mayor = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i]>mayor) {
                    mayor = arr[i];
                }
            }
            Console.WriteLine("Bigger number: "+mayor);
        }
        static void minorNumber(int[] arr)
        {
            double minor = arr[0];
            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] < minor)
                {
                    minor = arr[i];
                }
            }
            Console.WriteLine("Minor Number: " + minor);
        }
    }
}