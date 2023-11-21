using System;
using System.Collections;
using System.Collections.Generic;
using listas;

List<Product> productos = new List<Product>
        {
            new Product(1, "Arroz"),
            new Product(2, "Frijoles"),
            new Product(3, "Aceite"),
            new Product(4, "Harina"),
            new Product(5, "Leche"),
            new Product(6, "Azúcar"),
            new Product(7, "Sal"),
            new Product(8, "Café"),
            new Product(9, "Pasta"),
            new Product(10, "Sopa")
        };
//readList(productos);
List<Product> product1 = productos.FindAll(p => p.Id >= 5 && p.Id <= 9);
readList(product1);
Product product5 = productos.Find(p => p.Id == 1);
Console.WriteLine($"{product5.Id} {product5.Name}");


void readList(List<Product> lista)
{
    for (int x = 0; x < lista.Count; x++)
        Console.WriteLine($"Id: {lista[x].Id}  Name: {lista[x].Name}");
    Console.WriteLine();
}
namespace listas
{
    class Product {
   public Product(int id, string name) {
            Id = id;
            Name = name;
   }
        
    public int Id { get; set; }
    public string Name { get; set; }

}
}
