using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Vendedor : Persona
    {
        public int IdVendedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdCategoria { get; set; }
        public string Contrasenia { get; set; }

        public Vendedor() : base()
        {
            IdVendedor = 0;
            FechaIngreso = DateTime.MinValue;
            IdCategoria = 0;
            Contrasenia = string.Empty;
        }
        public Vendedor(string nombre, string apellido, string cuit, DateTime fec, int idCat, string contrasenia) : base(nombre, apellido, cuit)
        {
            FechaIngreso = fec;
            IdCategoria = idCat;
            Contrasenia = contrasenia;
        }

        public Vendedor(int idVend, string nombre, string apellido, string cuit, DateTime fec, int idCat, string contrasenia) : base(nombre, apellido, cuit)
        {
            IdVendedor = idVend;
            FechaIngreso = fec;
            IdCategoria = idCat;
            Contrasenia = contrasenia;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
