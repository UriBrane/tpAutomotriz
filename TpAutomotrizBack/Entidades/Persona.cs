using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cuit { get; set; }
        public string NombreCompleto { get { return Apellido + ", " + Nombre; } } 

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cuit = string.Empty;
        }

        public Persona(string nom, string ape, string cuit)
        {
            Nombre = nom;
            Apellido = ape;
            Cuit = cuit;
        }

        public override string ToString()
        {
            return Nombre + " ," + Apellido;
        }
    }
}
