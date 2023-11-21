namespace Inheriance {
    class Person {
        private string name;
        private int age;
        public Person() { }
        public Person(string name, int age) {
           Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public void printPerson() {
            Console.Write("Name: " + this.Name +"  "+ " Age: "+ this.Age);
        }

    }
    class Employee : Person {
        private double salary;
        public Employee(){}
        public Employee(string name, int age, double salary): base(name, age) {
            Salary = salary;
        }
        public double Salary{ set; get; }
            
        public void printSalary() {
            Console.Write("Salary: " + this.Salary);
        }
        public void printEmployee() {
            Console.Write("Name Employee: " + this.Name + " Age Employee: " + this.Age +" Salary: " + this.Salary);
        }
    }
    class main {
        public static void Main(string[] args) {
            Person person = new Person();
            person.Name="Orlando";
            person.Age = 35;
            person.printPerson();
            Console.WriteLine();
            Employee employee = new Employee();
            employee.Name = "Carlos";
            employee.Age = 32;
            employee.Salary = 1200000;
            employee.printEmployee();
            Console.ReadKey();

        }
    
    }
};
