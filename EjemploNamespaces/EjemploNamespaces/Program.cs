using System;

using NamespaceDeClasePersona;

// Para que este archivo vea a la clase Persona, hay que
// importar el namespace de la clase persona con 
//    using.NamespaceDeClasePersona

namespace EjemploNamespaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cargar persona");
            Console.WriteLine("Ingrese nombre");
            string nom = Console.ReadLine();

            Console.WriteLine("Ingrese edad (Número mayor a cero)");
            int num = int.Parse(Console.ReadLine());

            // Crear nueva persona
            Persona per = new Persona();
            per.Nombre = nom;
            per.Edad = num;

            Console.WriteLine("Atributos de la persona");
            Console.WriteLine("Nombre: " + per.Nombre);
            Console.WriteLine("Apellido: " + per.Apellido);
            Console.WriteLine("Edad: " + per.Edad.ToString());
        }
    }
}
