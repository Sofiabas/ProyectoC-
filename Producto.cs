using System;
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
        public double costo { get; set; }
        public double precioVenta { get; set; }
        public string idUsuario { get; set; }
        public int stock { get; set; }


        public Producto()
        {
            id = 0;
            descripcion = "";
            costo = 0;
            precioVenta = 0;
            idUsuario = "";
            stock= 0;
        }

    }
}