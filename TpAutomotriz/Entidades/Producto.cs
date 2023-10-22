using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotriz.Entidades
{
    public class Producto
    {
        private int id_producto;
        private string detalle;
        private double precio;
        private int cantidad;
        private int cant_min_por_mayor;
        private int cantidad_min;


        public Producto()
        {
            id_producto=0;
            detalle = string.Empty;
            precio = 0;
            cantidad = 0;
            cant_min_por_mayor= 0;
            cantidad_min= 0;

        }

        public Producto(int id_producto, string detalle, double precio, int cantidad, int cant_min_por_mayor, int cantidad_min)
        {
            this.Id_producto = id_producto;
            this.Detalle = detalle;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Cant_min_por_mayor = cant_min_por_mayor;
            this.Cantidad_min = cantidad_min;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Cant_min_por_mayor { get => cant_min_por_mayor; set => cant_min_por_mayor = value; }
        public int Cantidad_min { get => cantidad_min; set => cantidad_min = value; }


        public void CalcularStock()
        {


        }

        public override string ToString()
        {
            return detalle.ToString();
        }

    }
}
