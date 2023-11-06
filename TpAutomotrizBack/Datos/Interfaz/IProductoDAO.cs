using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Datos.Interfaz
{
    public interface IProductoDAO
    {
        Producto GetProducto(int id);
        bool PostProducto(Producto p);
        List<Producto> GetProductos();
    }
}
