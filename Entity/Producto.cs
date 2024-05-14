using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public string ReferenciaProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Existencias {  get; set; }
        public int StockMinimo {  get; set; }
        public double PrecioUnitario { get;set; }
        public string EstadoProducto {  get; set; }

        public Producto() { }
        public override string ToString()
        {
            return $"{ReferenciaProducto};{NombreProducto};{Existencias};{StockMinimo};{PrecioUnitario};{EstadoProducto}";
        }
    }
}
