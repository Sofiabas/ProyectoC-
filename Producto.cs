﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal precioVenta { get; set; }
        public string idUsuario { get; set; }
        public int stock { get; set; }

    }
}