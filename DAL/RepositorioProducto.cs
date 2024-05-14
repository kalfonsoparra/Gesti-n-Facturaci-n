using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class RepositorioProducto : Repositorio_Crud<Producto>
    {
        protected string Archivo = "Producto.txt";
        public RepositorioProducto()
        {

        }
        public string Create(Producto producto)
        {
            try
            {
                StreamWriter SR = new StreamWriter(Archivo, true);
                SR.WriteLine(producto);
                SR.Close();
                return "Exito en Registrar producto";
            }
            catch (NullReferenceException nre)
            {
                return "Error en" + nre.Message;
            }
        }

        public void Delete(string Date)
        {
            List<Producto> productos = new List<Producto>();
            productos = Reading();
            FileStream file = new FileStream(Archivo, FileMode.Create);
            file.Close();
            foreach (var item in productos)
            {
                if (!ThisCorrect(item.ReferenciaProducto, Date))
                {
                    Create(item);
                }
            }
        }
        private bool ThisCorrect(string DatoRegistrado, string DatoBuscada)
        {
            return DatoRegistrado == DatoBuscada;
        }

        public Producto Maping(string Date)
        {
            try
            {
                if (Date == null || Date == " ")
                {
                    return null;
                }
                var Linea = Date.Split(';');
                Producto producto = new Producto
                {
                    ReferenciaProducto = Linea[0],
                    NombreProducto = Linea[1],
                    Existencias = int.Parse(Linea[2]),
                    StockMinimo = int.Parse(Linea[3]),
                    PrecioUnitario = double.Parse(Linea[4]),
                    EstadoProducto = Linea[5]
                };
                return producto;
            }
            catch (Exception e)
            {
                return new Producto();
            }
        }

        public List<Producto> Reading()
        {
            try
            {
                List<Producto> Lista = new List<Producto>();
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

        public Producto Searching(string Date)
        {
            var lista = Reading();
            foreach (var item in lista)
            {
                if (item.ReferenciaProducto == Date)
                {
                    return item;
                }

            }
            return null;
        }

        public string Update(List<Producto> NewList)
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
