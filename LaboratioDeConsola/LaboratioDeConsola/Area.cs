using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioDeConsola
{
    public class Area
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Area(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
