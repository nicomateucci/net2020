using System;
namespace EjercicioFacturacion
{
    public class Cliente
    {
        private int _codigo;
        private string _nombre;
        private string _direccion;
        private float _montoTotal;

        public Cliente()
        {
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public float MontoTotal { get => _montoTotal; set => _montoTotal = value; }
    }
}
