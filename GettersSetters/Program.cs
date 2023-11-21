using System;
using System.Collections.Generic;
//using System.Collections;
namespace gettersSetters{
    class Persona{
        private string name;
        private int age;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age {
            set { age = value; }
            get { return age; }
        }
        /*public static void Main(string[] args) {
            Persona persona = new Persona();
            persona.Name = "Orlando Barragan";
            persona.age = 35;
            Console.Write("Name: "+persona.Name+ " Age: "+persona.Age);
            
        }*/
    
    }
    
}
namespace exercise {
    class Socio { 
        private string name;
        private int antiguedad;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Antiguedad
        {
            set {
                if (value < 0)
                {   
                        throw new AntiguedadNegativoException(); 
                }
                antiguedad = value;

            }
            get { return antiguedad; }
        }
        
    }
    public class AntiguedadNegativoException : Exception
    {
        public AntiguedadNegativoException() : base("La antiguedad no puede ser negativo.")
        {
        }
    }
    class Club {
        public static void Main(string[] args){
            //Socio socio = new Socio();
            /*Socio socio1 = new Socio();
            Socio socio2 = new Socio();*/
            //List<Socio> socios = new List<Socio>();
            /*socios.Add(socio);
            socios.Add(socio1);
            socios.Add(socio2);*/

            for (int i = 0; i < 3; i++)
            {
                Socio socio = new Socio();

                Console.Write("Enter Name: ");
                socio.Name = Console.ReadLine();

                Console.Write("Enter Antiquity: ");
                socio.Antiguedad = int.Parse(Console.ReadLine());

                socios.Add(socio);
            }
            foreach (Socio socioP in socios)
            {
                Console.WriteLine(socioP.Name + " - "+socioP.Antiguedad);
            }
         }
    }
    
}
