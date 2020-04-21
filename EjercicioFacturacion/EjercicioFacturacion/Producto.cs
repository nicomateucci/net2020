using System;
namespace EjercicioFacturacion
{
    public class Producto
    {
        private int _codigo;
        private float _precio;
        private string _descripcion;
        private int _stock;



        public Producto()
        {
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
