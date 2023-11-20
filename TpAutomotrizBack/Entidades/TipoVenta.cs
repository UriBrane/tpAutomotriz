using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class TipoVenta
    {
        public int ID {  get; set; }
        public string Tipo { get; set; }

        public TipoVenta()
        {
               
        }

        public TipoVenta(int id, string tipo)
        {
            ID = id;
            Tipo = tipo;
        }

    }
}
