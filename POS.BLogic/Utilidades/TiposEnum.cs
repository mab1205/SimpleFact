﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POS.BLogic.Utilidades
{
    public class TiposEnum
    {
        public enum EstadoFactura
        {
            Activa = 'A',
            Cancelada = 'C',
            Pendiente = 'P'
        }

        public enum ModuloSistema
        {
            Facturacion = 1,
            MantenimientoProducto = 2,
            MantenimientoPersona = 3,
            MantenimientoFacturaElectronica = 4
        }
    }
}