﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POS.Data.Models
{
    public class TipoImpuestos
    {
        public TipoImpuestos()
        {
            Producto = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public bool? Excepcion { get; set; }

        public ICollection<Producto> Producto { get; set; }

    }
}
