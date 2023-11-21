using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Descuento
    {
        public int ID {  get; set; }
        public int CantDescuento { get; set; }

        public Descuento()
        {
            ID = 1;
            CantDescuento = 0;
        }

        public Descuento(int id, int cant)
        {
            ID = id;
            CantDescuento = cant;
        }
    }
}
