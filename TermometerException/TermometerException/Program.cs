using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception1;

namespace Exception1 {
    class Termometer{
        private double temperature;
        
        public double Temperature{
            get { return temperature; }
            set {
                if (value < -192 || value > 100)
                {
                    //throw new Exception("Out of Range!!");
                    throw new TemperatureOutOfRangeException();

                }
                else {
                    temperature = value;
                }
            }
        }
     }
        
    }
    class TemperatureOutOfRangeException : Exception{
        public TemperatureOutOfRangeException() {
           Console.WriteLine("OUT OF RANGE CUSTOMER");
        }
        public string messageCustom(string mensajeP) {
            return mensajeP;
        }
    }

    class Test {
        public static void Main(string[] args) {
        try {
            Termometer termometer = new Termometer();
            termometer.Temperature = -300;
            Console.Write(termometer.Temperature);
        }
        catch (TemperatureOutOfRangeException e) {
            Console.WriteLine(e.Message);
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        
            
            
        }
    }

