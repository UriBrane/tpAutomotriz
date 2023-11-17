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
        List<Producto> GetProductos(int idTipo);
        bool PostProducto(Producto p);
        bool PutProducto(Producto p);
        List<Producto> GetProductos();

        Producto GetProducto(int id);
    }
}
