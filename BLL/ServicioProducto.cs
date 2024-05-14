using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioProducto : Servicio_Crud<Producto>
    {
        RepositorioProducto repositorioProducto;
        List<Producto> productos;

        public ServicioProducto()
        {
            repositorioProducto = new RepositorioProducto();
            productos = new List<Producto>();
            RefrescarLista();
        }
        public string Actualizar(Producto producto)
        {
            RefrescarLista();
            var productoSearch = Buscar(producto.ReferenciaProducto);
            if (productoSearch != null)
            {
                productoSearch.ReferenciaProducto = producto.ReferenciaProducto;
                productoSearch.NombreProducto = producto.NombreProducto;
                productoSearch.Existencias = producto.Existencias;
                productoSearch.StockMinimo = producto.StockMinimo;
                productoSearch.PrecioUnitario = producto.PrecioUnitario;
                productoSearch.EstadoProducto = producto.EstadoProducto;
                return "Modificacion exitosa";
            }
            return "Producto no encontrado";
        }

        public Producto Buscar(string Date)
        {
            var item = repositorioProducto.Searching(Date);
            return item;
        }

        public List<Producto> Consultar()
        {
            return productos;
        }

        public string Eliminar(string Date)
        {
            try
            {
                var referencia = Buscar(Date);
                if (referencia != null)
                {
                    repositorioProducto.Delete(Date);
                    RefrescarLista();
                    return "Eliminacion exitosa";
                }
                else
                {
                    return "No Hay datos con dicha referencia";
                }
            }
            catch (Exception ex)
            {
                return "Fallo por " + ex.Message;
            };
        }

        public string Guardar(Producto producto)
        {
            var mensaje = repositorioProducto.Create(producto);
            RefrescarLista();
            return mensaje;
        }
        private void RefrescarLista()
        {
            productos = repositorioProducto.Reading();
        }
    }
}
