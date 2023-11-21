using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Cliente : Persona
    {
        [JsonProperty("idCliente")]
        public int IdCliente { get; set; }

        [JsonProperty("calle")]
        public string Calle { get; set; }

        [JsonProperty("calleNro")]
        public int CalleNro { get; set; }

        [JsonProperty("tipoCliente")]
        public int TipoCliente { get; set; }

        [JsonProperty("idBarrio")]
        public int IdBarrio { get; set; }

        public Cliente() : base()
        {
            IdCliente = 0;
            Calle = string.Empty;
            CalleNro = 0;
            TipoCliente = 0;
            IdBarrio = 0;
        }
        public Cliente(string nombre, string apellido, long cuit, string calle, int nro, int idTipo
                        , int idBarrio) : base(nombre, apellido, cuit)
        {
            Calle = calle;
            CalleNro = nro;
            TipoCliente = idTipo;
            IdBarrio = idBarrio;
        }

        [JsonConstructor]
        public Cliente(int idCliente, string nombre, string apellido, long cuit, string calle, int calleNro
                        , int tipoCliente, int idBarrio) : base(nombre, apellido, cuit)
        {
            IdCliente = idCliente;
            Calle = calle;
            CalleNro = calleNro;
            TipoCliente = tipoCliente;
            IdBarrio = idBarrio;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
