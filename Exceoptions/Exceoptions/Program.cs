using System;

// Definir una excepción personalizada
public class MiExcepcionPersonalizada : Exception
{
    public MiExcepcionPersonalizada()
    {
    }

    public MiExcepcionPersonalizada(string message)
        : base(message)
    {
    }

    public MiExcepcionPersonalizada(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    // Puedes agregar propiedades y métodos adicionales a tu excepción personalizada según tus necesidades
    public int CodigoDeError { get; set; }
}

class Program
{
    static void Main()
    {
        try
        {
            // Simular una situación que genere una excepción personalizada
            throw new MiExcepcionPersonalizada("Se ha producido un error personalizado.");
            throw new Exception();
        }
        catch (MiExcepcionPersonalizada ex)
        {
            Console.WriteLine("Excepción personalizada capturada:");
            Console.WriteLine("Mensaje: " + ex.Message);
            Console.WriteLine("Código de error: " + ex.CodigoDeError);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Excepción genérica capturada:");
            Console.WriteLine("Mensaje: " + ex.Message);
        }
    }
}
