﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Datos.Interfaz
{
    public interface IFacturaDAO
    {
        Factura GetFactura(int id);
        bool PostFactura(Factura f);
        List<Factura> GetFacturas();
    }
}
