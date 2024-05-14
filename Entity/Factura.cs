using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Factura() { }
        public string IdFactura {  get; set; }
        public DateTime FechaFActura { get; set; }
        public double TotalValorFactura {  get; set; }
        public List<Producto> productos { get; set; }
        public override string ToString()
        {
            return $"{IdFactura};{FechaFActura};{TotalValorFactura}";
        }
    }
}
