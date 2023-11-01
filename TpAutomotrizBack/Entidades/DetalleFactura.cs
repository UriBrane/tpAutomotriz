using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class DetalleFactura
    {
        public Producto Producto { get; set; }
        public int IdDetalle { get; set; }
        public double Precio { get; set; }
        public double Cantidad { get; set; }
        public double Descuento { get; set; }
        public string Entregado { get; set; }

        public DetalleFactura()
        {
            Producto = new Producto();
            IdDetalle = 0;
            Precio = 0;
            Cantidad = 0;
            Descuento = 0;
            Entregado = string.Empty;
        }

        public DetalleFactura(Producto producto, int idDetalle, double precio, double cantidad, double descuento, string entregado)
        {
            this.Producto = producto;
            this.IdDetalle = idDetalle;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Descuento = descuento;
            this.Entregado = entregado;
        }

        public double CalcularSubtotal()
        {
            double subtotal = 0;
            subtotal = Cantidad * Precio * Descuento;
            return subtotal;
        }

    }
}