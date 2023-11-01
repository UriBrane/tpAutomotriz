﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Cliente : Persona
    {
        public string Calle { get; set; }
        public int CalleNro { get; set; }
        public int TipoCliente { get; set; }
        public int Barrio { get; set; }
        public Cliente() : base()
        {
            Calle = string.Empty;
            CalleNro = 0;
            TipoCliente = 0;
            Barrio = 0;
        }
        public Cliente(string nombre, string apellido, int cuit, string calle, int nro, int tipo, int barrio) : base(nombre, apellido, cuit)
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
