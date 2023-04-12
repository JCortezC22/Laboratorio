using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioDeConsola
{

    enum NivelUsuario
    {
        Admin,
        Cliente
    }
    class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public NivelUsuario Nivel { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nNombre: {Nombre}\nEdad: {Edad}\nNivel: {Nivel}";
        }
    }
}
