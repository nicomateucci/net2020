<h1 align="center">
  <img src="imagenes/UTN.png" alt="logo_utn">
</h1>
<h5 align="center">Universidad Tecnologica Nacional </h5>

# Materia: Técnicas y Tecnologías de Desarrollo  Software IDE 2020

# Entorno 🛠️

* **Microsoft Visual Studio 2019**
    * Proyecto de Consola
    * Bibliotecas de Clases
* **Campus Virtual UTN**


## Ejempo definicion de una clase en C#:
```
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
          // Por defecto se inicia con el apellido Messi
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

```


## Autor

* **Nicolas Mateucci** - *Trabajo Practico TTADS Frontend* - [Github oficial ⚡️](https://github.com/nicomateucci)

--------------------------------------------------------

### Plantillas README

[Ejemplos **muy buenos** de uso de Markdown Langauge](https://github.com/ricval/Documentacion/blob/master/Guias/GitHub/mastering-markdown.md#ejemplos)

[Modelo de plantilla para hacer un buen README ⚡️](https://gist.github.com/Villanuevand/6386899f70346d4580c723232524d35a)



🚀 📋 📦 🛠️ 📄 🎁 📢 🍺 🤓 🔧
