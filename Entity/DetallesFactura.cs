using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetallesFactura
    {
        public DetallesFactura() { }

        public string IdDetalleFactura {  get; set; }
        public Factura idFactura { get; set;}
        public Producto Producto { get; set; }
        public int CantidadFacturada { get; set; }
        public double ValorVendido {  get; set; }

        public override string ToString()
        {
            return $"{IdDetalleFactura};{idFactura};{Producto};{CantidadFacturada};{ValorVendido}";
        }

    }
}
