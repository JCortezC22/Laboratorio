using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioDeConsola
{
    internal class Program
    {
        static List<Producto> productos = new List<Producto>();

        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al supermercado!");


            Console.Write("Que usuario eliges: ");
            int usuarioElegido = int.Parse(Console.ReadLine());
            // Ejemplo de creación de usuario
            Usuario usuario1 = new Usuario { Id = 1, Nombre = "Wendy", Edad = 20, Nivel = NivelUsuario.Cliente };
            Usuario usuario2 = new Usuario { Id = 1, Nombre = "Manuel", Edad = 25, Nivel = NivelUsuario.Admin };

            switch (usuarioElegido)
            {
                case 1:
                    Console.WriteLine($"Bienvenido " + usuario2.Nombre);
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Usted es ADMINISTRADOR");
                    // Ejemplo de creación de producto
                    Console.ResetColor();
                    Producto producto1 = Producto.CrearProducto();
                    AgregarProducto(producto1);

                    // Ejemplo de compra
                    Compra compra1 = new Compra { Cliente = usuario1 };
                    compra1.AgregarProducto(producto1);
                    compra1.MostrarResumen();

                    break;

                    case 2:

                    break;
               
            }

     
        }

        static void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine("\nEl producto ha sido agregado a la lista de productos");
        }
    }
}
