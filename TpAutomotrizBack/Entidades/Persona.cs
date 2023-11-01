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
        public int Cuit { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cuit = 0;
        }

        public Persona(string nom, string ape, int cuit)
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
