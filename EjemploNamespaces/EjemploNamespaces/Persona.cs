using System;

namespace NamespaceDeClasePersona
{
    public class Persona
    {
        //Defino una persona con atributos
        //nombre, apellido y edad
        private string _nombre;
        private string _apellido;
        private int _edad;

        //Constructor, se llama cuando haces el "new"
        // Ejemplo: Persona per = new Persona();
        public Persona()
        {
            this.Apellido = "Messi";
        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
        public string Apellido
        {
            set { _apellido = value; }
            get { return _apellido; }
        }
        public int Edad
        {
            set{ _edad = value; }
            get { return _edad; }
        }
    }
}
