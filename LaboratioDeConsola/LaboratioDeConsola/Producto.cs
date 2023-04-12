using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioDeConsola
{
    class Producto
    {
        public string Nombre { get; set; }
        public string proveedor { get; set; }
        public DateTime fechaCaducidad { get; set; }
        public DateTime fechaEntrada { get; set; }
        public string detalles { get; set; }
        public decimal Precio { get; set; }
        public int unidades { get; set; }

        public static Producto CrearProducto()
        {
            Console.Write("\nIngrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el proveedor del producto: ");
            string proveedor = Console.ReadLine();

            Console.Write("Ingrese la fecha de caducidad del producto (en formato dd/mm/yyyy): ");
            DateTime fechaCaducidad = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha de entrada del producto (en formato dd/mm/yyyy): ");
            DateTime fechaEntrada = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese los detalles del producto: ");
            string detalles = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de unidades del producto: ");
            int unidades = int.Parse(Console.ReadLine());

            Producto producto = new Producto();
            producto.Nombre = nombre;
            producto.proveedor = proveedor;
            producto.fechaCaducidad = fechaCaducidad;
            producto.fechaEntrada = fechaEntrada;
            producto.detalles = detalles;
            producto.Precio = precio;
            producto.unidades = unidades;

            Console.WriteLine("\nEl producto ha sido creado con éxito.");

            return producto;
        }
    }
}
