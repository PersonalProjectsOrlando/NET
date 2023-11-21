using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo
{
    class Program
    {
        public static void Main(string[] args) {
            //float resultSurface = surfaceSquare();
            //Console.WriteLine("resultSurface: " + resultSurface);


            //addProduct();

            //biggerNumber();

            //NumberDigits();

            //NumbersBiggerLower();

            //countParImpar();

            LoginValues();




        }
        //Realizar un programa que saca la superficie de una cuadrado.
        public static float surfaceSquare() {
            Console.Write("Ingresa el valor del lado 1: ");
            string lado = Console.ReadLine();
            float lado1 = float.Parse(lado);
            float surface = lado1 * lado1;
            return surface;

        }
        //Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
        public static void addProduct() {
            Console.Write("Login Value 1: ");
            string input1 = Console.ReadLine();
            float side1 = float.Parse(input1);
            Console.Write("Login Value 2: ");
            string input2 = Console.ReadLine();
            float side2 = float.Parse(input2);
            Console.Write("Login Value 3: ");
            string input3 = Console.ReadLine();
            float side3 = float.Parse(input3);
            Console.Write("Login Value 4: ");
            string input4 = Console.ReadLine();
            float side4 = float.Parse(input4);
            float add = side1 + side2 + side3 + side4;
            float average = add / 4;
            Console.WriteLine("Sum: " + add);
            Console.Write("average: " + average);
        }
        public static void biggerNumber() {
            Console.Write("Number 1: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine(number1);
            Console.Write("Number 2: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine(number2);
            if (number1 < number2)
            {
                Console.WriteLine("bigger number2 ");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("bigger number1 ");
            }
            else {
                Console.WriteLine("Equals");
            }
        }
        public static void NumberDigits() {
            Console.Write("Enter number 1 - 99 : ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 9) {
                Console.Write("One Digit");
            }
            else if (num >= 10 && num <= 99) {
                Console.Write("Two Digit");
            }
            else {
                Console.Write("Invalid Number!");
            }
        }
        //Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se
        //calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos)
        public static void NumbersBiggerLower() {
            Console.Write("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter n2 ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter n3 ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3) {
                if (n2 < n3) {
                    Console.Write(n1 + " :bigger " + n2 + " :lower");
                }
                else if (n2 > n3) {
                    Console.Write(n1 + " :bigger " + n3 + " :lower");
                }

            } else if (n2 > n1 && n2 > n3) {
                if (n1 < n3) {
                    Console.Write(n2 + " :bigger " + n1 + " :lower");
                } else if (n1 > n3) {
                    Console.Write(n2 + " :bigger " + n3 + " :lower");
                }

            }
            else if (n3 > n1 && n3 > n2) {
                if (n2 < n1)
                {
                    Console.Write(n3 + " :bigger" + n2 + " :lower");
                } else if (n2 > n1) {
                    Console.Write(n3 + " :bigger" + n1 + " :lower");
                }

            }


        }
        public static void countParImpar() {
            Console.Write("Enter #: ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(n);
            int countPairs = 0;
            int countInpars = 0;
            int i = 1;
            
            while (i<=n) {
                //Console.Write(i+" ");
                if (i % 2 == 0)
                {
                    countPairs++;
                    
                }
                else {
                    countInpars++;
                    
                }
                i++;
            }
            Console.WriteLine("Pairs: " + countPairs);
            Console.Write("Impairs: " + countInpars);

        }
        public static void LoginValues() {
            Random random = new Random();
            Console.Write("Enter #: ");
            int n = int.Parse(Console.ReadLine());
            int numeroAleatorio=0;
            int countNegatives = 0;
            int countPositives = 0;
            int multiplesFifTeen = 0;
            int acumPairs = 0;

            for (int i=0; i < n;i++) {
                numeroAleatorio = random.Next(-100, 100);
                Console.WriteLine(numeroAleatorio);
                if (numeroAleatorio < 0) {
                    countNegatives++;

                }if (numeroAleatorio % 2 == 0){
                    acumPairs = numeroAleatorio + acumPairs;
                }
                else if (numeroAleatorio >= 0) {
                    countPositives++;
                } else if (numeroAleatorio % 15 == 0) {
                    multiplesFifTeen++;
                }
            }
            
            Console.WriteLine("Negatives: " + countNegatives);
            Console.WriteLine("Positives: " + countPositives);
            Console.WriteLine("multiples of FifTeen: " + multiplesFifTeen);
            Console.Write("Acum Pairs: " + acumPairs);
        }
    }
}