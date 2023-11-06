using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Datos.Interfaz
{
    public interface IVendedorDAO
    {
        Vendedor GetVendedor(int id);
        List<Vendedor> GetVendedores();
        bool PostVendedor(Vendedor v);
    }
}
