using System;

namespace EjercicioFacturacion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Producto[] productos = new Producto[100];
            Cliente[] clientes = new Cliente[45];

            Console.WriteLine("Ingrese el nombre de los 100 productos");
            string nom = Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                Producto p = new Producto();
                p.Codigo = i;
                p.Descripcion ="Producto: " + nom + i.ToString();
                p.Precio = i + 1 * 10;
                p.Stock = 50;
                productos[i] = p;
            }
            Console.WriteLine("Ingrese el nombre de los 45 clientes");
            string nombre = Console.ReadLine();
            for (int i = 0; i < 45; i++)
            {
                Cliente c = new Cliente();
                c.Codigo = i;
                c.Nombre = nombre + i.ToString();
                c.Direccion = "Direccion de " + nombre + i.ToString();
                clientes[i] = c;
            }

            // Articulos vendidos al cliente
            Console.WriteLine("Ingrese codigo de cliente");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre de cliente seleccionado: " + clientes[cod].Nombre);

            // Permito hacer 3 ingresos de articulos
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el codigo de articulo");
                int codArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de articulos vendidos");
                int cant = int.Parse(Console.ReadLine());

                //Verificar que halla stock
                if (productos[codArt].Stock >= cant)
                {
                    //Restar al stock la nueva compra
                    productos[codArt].Stock -= cant;
                    // Actualizar monto del cliente
                    clientes[i].MontoTotal += productos[codArt].Precio * cant;
                }
                Console.WriteLine("Factura ---------------------------");
                Console.WriteLine("Cliente:" + clientes[i].Nombre);
                Console.WriteLine("Direccion:" + clientes[i].Direccion);
                Console.WriteLine("Monto total:" + clientes[i].MontoTotal);
            }
        }
    }
}
