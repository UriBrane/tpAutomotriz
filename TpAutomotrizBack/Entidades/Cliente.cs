using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string Calle { get; set; }
        public int CalleNro { get; set; }
        public int TipoCliente { get; set; }
        public int IdBarrio { get; set; }
        public Cliente() : base()
        {
            IdCliente = 0;
            Calle = string.Empty;
            CalleNro = 0;
            TipoCliente = 0;
            IdBarrio = 0;
        }
        public Cliente(string nombre, string apellido, string cuit, string calle, int nro, int idTipo, int idBarrio) : base(nombre, apellido, cuit)
        {
            Calle = calle;
            CalleNro = nro;
            TipoCliente = idTipo;
            IdBarrio = idBarrio;
        }
        public Cliente(int idCli, string nombre, string apellido, string cuit, string calle, int nro, int idTipo, int idBarrio) : base(nombre, apellido, cuit)
        {
            IdCliente = idCli;
            Calle = calle;
            CalleNro = nro;
            TipoCliente = idTipo;
            IdBarrio = idBarrio;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
