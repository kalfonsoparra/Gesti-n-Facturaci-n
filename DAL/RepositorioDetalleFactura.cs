using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioDetalleFactura : Repositorio_Crud<DetallesFactura>
    {
        protected string Archivo = "DetallesDeFactura.txt";
        public RepositorioDetalleFactura() { }

        public string Create(DetallesFactura detalle)
        {
            try
            {
                StreamWriter SR = new StreamWriter(Archivo, true);
                SR.WriteLine(detalle);
                SR.Close();
                return "Confirmado";
            }
            catch (NullReferenceException nre)
            {
                return "Error en" + nre.Message;
            }
        }

        public void Delete(string Date)
        {
            List<DetallesFactura> detalles = new List<DetallesFactura>();
            detalles = Reading();
            FileStream file = new FileStream(Archivo, FileMode.Create);
            file.Close();
            foreach (var item in detalles)
            {
                if (!ThisCorrect(item.IdDetalleFactura, Date))
                {
                    Create(item);
                }
            }
        }
        private bool ThisCorrect(string DatoRegistrado, string DatoBuscada)
        {
            return DatoRegistrado == DatoBuscada;
        }
        public DetallesFactura Maping(string Date)
        {
            try
            {
                if (Date == null || Date == " ")
                {
                    return null;
                }
                var Linea = Date.Split(';');
                DetallesFactura detallesFactura = new DetallesFactura
                {
                    IdDetalleFactura = Linea[0],
                    idFactura = new RepositorioFactura().Searching(Linea[1]),
                    Producto = new RepositorioProducto().Searching(Linea[2]),
                    CantidadFacturada = int.Parse(Linea[3]),
                    ValorVendido = double.Parse(Linea[4])

                };
                return detallesFactura;
            }
            catch (Exception e)
            {
                return new DetallesFactura();
            }
        }

        public List<DetallesFactura> Reading()
        {
            try
            {
                List<DetallesFactura> Lista = new List<DetallesFactura>();
                StreamReader SR = new StreamReader(Archivo);
                while (!SR.EndOfStream)
                {
                    Lista.Add(Maping(SR.ReadLine()));
                }
                SR.Close();
                return Lista;
            }
            catch (Exception e)
            {
                return null;
            }            
        }

        public DetallesFactura Searching(string Date)
        {
            var lista = Reading();
            foreach (var item in lista)
            {
                if (item.IdDetalleFactura == Date)
                {
                    return item;
                }

            }
            return null;
        }

        public string Update(List<DetallesFactura> NewList)
        {
            try
            {
                File.Delete(Archivo);
                foreach (var item in NewList)
                {
                    Create(item);
                }
                return "Actualizacion exitosa";
            }
            catch (Exception e)
            {
                return "Error en " + e.Message;
            }
        }
    }
}
