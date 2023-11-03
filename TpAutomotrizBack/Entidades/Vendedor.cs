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

        public Vendedor() : base()
        {
            IdVendedor = 0;
            FechaIngreso = DateTime.MinValue;
            IdCategoria = 0;
        }

        public Vendedor(int idVend, string nombre, string apellido, string cuit, DateTime fec, int cat) : base(nombre, apellido, cuit)
        {
            IdVendedor = idVend;
            FechaIngreso = fec;
            IdCategoria = cat;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
