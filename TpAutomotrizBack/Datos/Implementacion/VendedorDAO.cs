using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Interfaz;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Servicios.Implementacion;
using TpAutomotrizBack.Servicios.Interfaz;

namespace TpAutomotrizBack.Datos.Implementacion
{
    public class VendedorDAO : IVendedorDAO
    {
        private HelperDAO helper;
        private IMapeador mapeo;

        public VendedorDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo = Mapeador.GetInstance();
        }

        public bool PostVendedor(Vendedor v)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@nombre", v.Nombre),
                new Parametro( "@apellido", v.Apellido),
                new Parametro( "@CUIT", v.Cuit),
                new Parametro( "@fecha_ingreso", v.FechaIngreso),
                new Parametro( "@id_categoria", v.IdCategoria),
                new Parametro( "@contrasenia", v.Contrasenia)
            };
            return helper.EjecutarSQL("SP_INSERT_VENDEDOR", parametros);
        }

        public List<Vendedor> GetVendedores()
        {
            DataTable dt = helper.ConsultarTabla("SP_SELECT_VENDEDORES");
            List<Vendedor> l = mapeo.MapearVendedores(dt);
            return l;
        }

        public Vendedor GetVendedor(int id)
        {
            DataTable dt = helper.ConsultarTabla("SP_CONSULTAR_VENDEDOR", "@id", id);
            Vendedor v = mapeo.MapearVendedor(dt);
            return v;
        }

        public bool PutVendedor(Vendedor v)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@id_vendedor", v.IdVendedor),
                new Parametro( "@nombre", v.Nombre),
                new Parametro( "@apellido", v.Apellido),
                new Parametro( "@CUIT", v.Cuit),
                new Parametro( "@fecha_ingreso", v.FechaIngreso),
                new Parametro( "@id_categoria", v.IdCategoria)
            };
            return helper.EjecutarSQL("SP_UPDATE_VENDEDOR", parametros);
        }

    }
}
