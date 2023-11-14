using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Vendedor : Persona
    {
        private DateTime fecIngreso;
        private int idCat;

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
        public Vendedor(string nombre, string apellido, long cuit, DateTime fec, int idCat, string contrasenia) : base(nombre, apellido, cuit)
        {
            FechaIngreso = fec;
            IdCategoria = idCat;
            Contrasenia = contrasenia;
        }

        public Vendedor(int idVend, string nombre, string apellido, long cuit, DateTime fec, int idCat, string contrasenia) : base(nombre, apellido, cuit)
        {
            IdVendedor = idVend;
            FechaIngreso = fec;
            IdCategoria = idCat;
            Contrasenia = contrasenia;
        }

        public Vendedor(int id, string nom, string ape, long cuit, DateTime fecIngreso, int idCat) : base(nom, ape, cuit)
        {
            IdVendedor = id;
            FechaIngreso = fecIngreso;
            IdCategoria = idCat;
            Contrasenia = "";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
