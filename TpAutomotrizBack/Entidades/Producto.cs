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
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int CantMinPorMayor { get; set; }
        public int CantidadMin { get; set; }
        public int IdTipoProducto { get; set; }

        public Producto()
        {
            IdProducto = 0;
            Descripcion = string.Empty;
            Precio = 0;
            Cantidad = 0;
            CantMinPorMayor = 0;
            CantidadMin = 0;
            IdTipoProducto = 0;
        }
        public Producto(string descripcion, double precio, int cantidad, int cantMinPorMayor, int cantidadMin, int idTipoProd)
        {
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            CantMinPorMayor = cantMinPorMayor;
            CantidadMin = cantidadMin;
            IdTipoProducto = idTipoProd;
        }
        public Producto(int idProducto, string descripcion, double precio, int cantidad, int cantMinPorMayor, int cantidadMin, int idTipoProd)
        {
            IdProducto = idProducto;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            CantMinPorMayor = cantMinPorMayor;
            CantidadMin = cantidadMin;
            IdTipoProducto = idTipoProd;
        }

        public void CalcularStock()
        {


        }

        public override string ToString()
        {
            return Descripcion.ToString();
        }

    }
}
