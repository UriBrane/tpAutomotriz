﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Vendedor : Persona
    {
        public int Id_vendedor { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public int Id_categoria { get; set; }

        public Vendedor() : base()
        {
            Id_vendedor = 0;
            Fecha_ingreso = DateTime.MinValue;
            Id_categoria = 0;
        }

        public Vendedor(string nombre, string apellido, int cuit, int id_vent, DateTime fec, int cat) : base(nombre, apellido, cuit)
        {
            Id_vendedor = id_vent;
            Fecha_ingreso = fec;
            Id_categoria = cat;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
