using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioDetalleFactura : Servicio_Crud<DetallesFactura>
    {
        RepositorioDetalleFactura repositorioDetalleFactura;
        List<DetallesFactura> detalles;

        public ServicioDetalleFactura()
        {
            repositorioDetalleFactura = new RepositorioDetalleFactura();
            detalles = new List<DetallesFactura>();
        }
        public string Actualizar(DetallesFactura detalle)
        {
            RefrescarLista();
            var detalleSearch = Buscar(detalle.IdDetalleFactura);
            if (detalleSearch != null)
            {
                detalleSearch.IdDetalleFactura = detalle.IdDetalleFactura;
                detalleSearch.idFactura = detalle.idFactura;
                detalleSearch.Producto = detalle.Producto;
                detalleSearch.CantidadFacturada = detalle.CantidadFacturada;
                detalleSearch.ValorVendido = detalle.ValorVendido;
                return "Modificacion exitosa";
            }
            return "Factura no encontrado";
        }

        public DetallesFactura Buscar(string Date)
        {
            var item = repositorioDetalleFactura.Searching(Date); return item;
        }

        public List<DetallesFactura> Consultar()
        {
            return detalles;
        }

        public string Eliminar(string Date)
        {
            try
            {
                var IdDetalle = Buscar(Date);
                if (IdDetalle != null)
                {
                    repositorioDetalleFactura.Delete(Date);
                    RefrescarLista();
                    return "Eliminacion exitosa";
                }
                else
                {
                    return "No Hay datos";
                }
            }
            catch (Exception ex)
            {
                return "Fallo por " + ex.Message;
            };
        }

        public string Guardar(DetallesFactura detalle)
        {
            var mensaje = repositorioDetalleFactura.Create(detalle);
            RefrescarLista();
            return mensaje;
        }
        private void RefrescarLista()
        {
            detalles = repositorioDetalleFactura.Reading();
        }
    }
}
