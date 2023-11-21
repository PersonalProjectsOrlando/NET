class Operarios {
    string[] nameEmployee = new string[3];
    //vamos a cagar 3 nombres ingresados por teclado e inicializamos el metodo constructor
    Operarios(){
        for (int i=0; i< nameEmployee.Length; i++) {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            nameEmployee[i] = name;
            
        }
        
    }
    public void printOperators() {
        Array.Sort(nameEmployee);
        foreach (string name in nameEmployee)
        {
            Console.WriteLine(name);
        }
    }
   public static void Main(string[] args) {
        Operarios operarios = new Operarios();
        operarios.printOperators();
    }
}

