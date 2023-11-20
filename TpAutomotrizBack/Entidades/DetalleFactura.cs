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
        public TipoVenta TipoVenta { get; set; }
        public int IdFactura { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public Descuento Descuento { get; set; }
        public string Entregado { get; set; } // ?? este campo no esta en la BD

        public DetalleFactura()
        {
            IdDetalleFactura = 0;
            TipoVenta = new TipoVenta();
            IdFactura = 0;
            Producto = new Producto();
            Cantidad = 0;
            Precio = 0;
            Descuento = new Descuento();
            Entregado = string.Empty;
        }
        public DetalleFactura(TipoVenta TipoVenta, int idFactura, Producto producto, int cantidad
                              , double precio, Descuento des, string entregado)
        {
            this.TipoVenta = TipoVenta;
            IdFactura = idFactura;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Descuento = des;
            Entregado = entregado;
        }
        public DetalleFactura(int idDetalle, TipoVenta TipoVenta, int idFactura, Producto producto
                              , int cantidad, double precio, Descuento des, string entregado)
        {
            IdDetalleFactura = idDetalle;
            this.TipoVenta = TipoVenta;
            IdFactura = idFactura;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Descuento = des;
            Entregado = entregado;
        }

        public double CalcularSubtotal()
        {
            double subtotal = 0;
            double precio = Cantidad * Precio;
            subtotal = (precio * (100 - Descuento.CantDescuento)) / 100;
            return subtotal;
        }

    }
}