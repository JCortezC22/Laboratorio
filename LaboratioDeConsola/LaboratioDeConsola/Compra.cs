using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioDeConsola
{
    class Compra
    {
        public Usuario Cliente { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Cliente: {Cliente.Nombre}");
            decimal total = 0;
            foreach (Producto producto in Productos)
            {
                Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.Precio}");
                total += producto.Precio*producto.unidades;
            }
            Console.WriteLine($"Total a pagar: {total}");
        }
    }
}
