using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotriz.Entidades
{
    public class DetalleFactura
    {
        private Producto producto;
        private int id_detalle;
        private double precio;
        private double cantidad;
        private double descuento;
        private string entregado;


        public DetalleFactura()
        {
            producto = null;
            id_detalle = 0;
            precio = 0;
            cantidad = 0;
            descuento = 0;
            Entregado = string.Empty;

        }


        public DetalleFactura(Producto producto, int id_detalle, double precio, double cantidad, double descuento, string entregado)
        {
            this.Producto = producto;
            this.Id_detalle = id_detalle;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Descuento = descuento;
            this.Entregado = entregado;
        }

        public Producto Producto { get => producto; set => producto = value; }
        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public string Entregado { get => entregado; set => entregado = value; }

        public double CalcularSubtotal()
        {
            double subtotal = 0;
            subtotal = cantidad * precio * descuento;
            return subtotal;
    
    }

    }
}