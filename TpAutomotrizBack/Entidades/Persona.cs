using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Persona
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("apellido")]
        public string Apellido { get; set; }

        [JsonProperty("cuit")]
        public long Cuit { get; set; }

        [JsonIgnore]
        public string NombreCompleto { get { return Apellido + ", " + Nombre; } }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cuit = 0;
        }

        [JsonConstructor]
        public Persona(string nom, string ape, long cuit)
        {
            Nombre = nom;
            Apellido = ape;
            Cuit = cuit;
        }

        public override string ToString()
        {
            return Nombre + " ," + Apellido;
        }
    }
}
