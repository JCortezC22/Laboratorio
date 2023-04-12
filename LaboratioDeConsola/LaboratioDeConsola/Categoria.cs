using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioDeConsola
{
    public class Categoria 
    {
        public string Nombre { get; set; }
  
        public Categoria(string nombre)
        {
            Nombre = nombre;

        }

        public static List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public static void AgregarCategoria(string nombre)
        {
            Categoria nuevaCategoria = new Categoria(nombre);
            Categorias.Add(nuevaCategoria);
        }
    }
}
