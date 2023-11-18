using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Producto
    {
        [JsonProperty("idProducto")]
        public int IdProducto { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("precio")]
        public double Precio { get; set; }

        [JsonProperty("cantidad")]
        public int Cantidad { get; set; }

        [JsonProperty("cantMinPorMayor")]
        public int CantMinPorMayor { get; set; }

        [JsonProperty("cantidadMin")]
        public int CantidadMin { get; set; }

        [JsonProperty("idTipoProducto")]
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

        [JsonConstructor]
        public Producto(int idProducto, string descripcion, double precio, int cantidad, int cantMinPorMayor, int cantidadMin, int idTipoProducto)
        {
            IdProducto = idProducto;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            CantMinPorMayor = cantMinPorMayor;
            CantidadMin = cantidadMin;
            IdTipoProducto = idTipoProducto;
        }

        public override string ToString()
        {
            return Descripcion.ToString();
        }

    }
}
