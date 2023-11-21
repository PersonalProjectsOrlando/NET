using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cola o Queue");
        Queue<string> cola = new Queue<string>();
        cola.Enqueue("Primero");
        cola.Enqueue("Segundo");
        cola.Enqueue("Tercero");       
        while (cola.Count > 0)
        {
            string elemento = cola.Dequeue();
            Console.WriteLine("Elemento en la cola: " + elemento);
        }
        //--------------------------------------------------------------------------------------
        Console.WriteLine(" ");
        Console.WriteLine("Pila o Stack");
        Stack<string> pila = new Stack<string>();
        pila.Push("Primero");
        pila.Push("Segundo");
        pila.Push("Tercero");

        while (pila.Count > 0)
        {
            string elemento = pila.Pop();
            Console.WriteLine("Elemento en la pila: " + elemento);
        }

        // ------------------------------------------------------------------------------------

        Console.WriteLine("");
        Console.WriteLine("Lista Generica");
        List<int> numeros = new List<int>();

        // Agregar elementos a la lista
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        // Acceder a elementos por índice
        Console.WriteLine("Elemento en el índice 1: " + numeros[1]); // Imprimirá 20

        // Iterar a través de la lista
        Console.WriteLine("Elementos en la lista:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        // Verificar si un elemento está en la lista
        bool contiene20 = numeros.Contains(20);
        Console.WriteLine("¿La lista contiene el número 20? " + contiene20);

        // Eliminar un elemento de la lista
        numeros.Remove(20);
        Console.WriteLine("Elementos en la lista después de eliminar el 20:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        // Borrar todos los elementos de la lista
        numeros.Clear();
        Console.WriteLine("Número de elementos después de limpiar la lista: " + numeros.Count);

        // Exercise -----------------------------------------------------------------------------
        Console.WriteLine("Exercise Generic List");
        List<int> number = new List<int>();
        
        //  Insertar un nodo al principio de la lista.
        number.Insert(0,1);
        readList(number);
        Console.WriteLine("");
        
        //  Insertar un nodo al final de la lista.
        number.Insert(number.Count,2);
        readList(number);

        //  Insertar un nodo en la segunda posición.Si la lista está vacía no se inserta el nodo.
        Console.WriteLine("");
        if (number.Count!=0) {
            number.Insert(1, 122);
            readList(number);
        }
        
        // Insertar un nodo en la ante última posición.
        Console.WriteLine("");
        number.Insert(number.Count-1, 322);
        readList(number);

        // Borrar el primer nodo.
        Console.WriteLine("");
        number.RemoveAt(0);
        readList(number);


        // Borrar el segundo nodo.
        Console.WriteLine("");
        number.RemoveAt(1);
        readList(number);
        // Borrar el último nodo.
        Console.WriteLine("");
        number.RemoveAt(number.Count-1);
        readList(number);
        Console.ReadKey();
    }
    public static void readList(List<int> number){
        
        foreach (int num in number)
        {
            Console.Write(num + " ");
        }
        
    }
}


