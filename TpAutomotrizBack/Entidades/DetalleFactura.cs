using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int IdTipoVenta { get; set; }
        public int IdFactura { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int IdDescuento { get; set; }
        public string Entregado { get; set; } // ?? este campo no esta en la BD

        public DetalleFactura()
        {
            IdDetalleFactura = 0;
            IdTipoVenta = 0;
            IdFactura = 0;
            Producto = new Producto();
            Cantidad = 0;
            Precio = 0;
            IdDescuento = 0;
            Entregado = string.Empty;
        }
        public DetalleFactura(int idTipoVenta, int idFactura, Producto producto, int cantidad
                              , double precio, int idDescuento, string entregado)
        {
            IdTipoVenta = idTipoVenta;
            IdFactura = idFactura;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            IdDescuento = idDescuento;
            Entregado = entregado;
        }
        public DetalleFactura(int idDetalle, int idTipoVenta, int idFactura, Producto producto
                              , int cantidad, double precio, int idDescuento, string entregado)
        {
            IdDetalleFactura = idDetalle;
            IdTipoVenta = idTipoVenta;
            IdFactura = idFactura;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            IdDescuento = idDescuento;
            Entregado = entregado;
        }

        public double CalcularSubtotal()
        {
            double subtotal = 0;
            subtotal = Cantidad * Precio * IdDescuento;
            return subtotal;
        }

    }
}