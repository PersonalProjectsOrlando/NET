using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Diccionario1
{
    class Program
    {
        static void Main(string[] args){
            Dictionary<int, Product> dictionary = new Dictionary<int, Product>();
            dictionary.Add(1, new Product("Rice",1200));
            dictionary.Add(2, new Product("Pain", 400));
            dictionary.Add(3, new Product("Pizza", 4500));
            printDictionary(dictionary);
            Console.Write("Enter code: ");
            int code= int.Parse(Console.ReadLine());
            printDictionaryId(dictionary, code);



        }
        public static void printDictionary(Dictionary<int, Product> dictionary) {
            foreach (KeyValuePair<int, Product> product in dictionary) {
                Console.WriteLine($"[Key: {product.Key} - Description: {product.Value.Description} Price: {product.Value.Price}]");
            }
        }
        public static void printDictionaryId(Dictionary<int, Product> dictionary, int id)
        {
            bool encontrado = false;
            foreach (KeyValuePair<int, Product> product in dictionary)
            {
                if (product.Key.Equals(id))
                {
                    Console.WriteLine($"[Key: {product.Key} - Description: {product.Value.Description} Price: {product.Value.Price}]");
                    encontrado = true;
                    break;
                }
                
                    
            }
            if (!encontrado)
            {
                // No se encontró el objeto, mostrar un mensaje
                Console.WriteLine($"the id does not exist {id}");
            }



        }
    }
    class Product {
        public Product(string description, int price) {
            Description = description;
            Price = price;
        }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}