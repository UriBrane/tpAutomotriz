using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int CantMinPorMayor { get; set; }
        public int CantidadMin { get; set; }

        public Producto()
        {
            IdProducto = 0;
            Detalle = string.Empty;
            Precio = 0;
            Cantidad = 0;
            CantMinPorMayor = 0;
            CantidadMin = 0;
        }

        public Producto(int idProducto, string detalle, double precio, int cantidad, int cantMinPorMayor, int cantidadMin)
        {
            this.IdProducto = idProducto;
            this.Detalle = detalle;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.CantMinPorMayor = cantMinPorMayor;
            this.CantidadMin = cantidadMin;
        }

        public void CalcularStock()
        {


        }

        public override string ToString()
        {
            return Detalle.ToString();
        }

    }
}
