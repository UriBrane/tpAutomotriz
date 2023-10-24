using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotriz.Entidades
{
    public class Cliente : Persona
    {
        public string Calle { get; set; }
        public int CalleNro { get; set; }
        public int TipoCliente { get; set; }
        public int Barrio { get; set; }
        public Cliente()
        {
            Calle = string.Empty;
            CalleNro = 0;
            TipoCliente = 0;
            Barrio = 0;
        }
        public Cliente(string calle, int nro, int tipo, int barrio)
        {
            Calle = calle;
            CalleNro = nro;
            TipoCliente = tipo;
            Barrio = barrio;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
