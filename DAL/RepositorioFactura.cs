using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioFactura : Repositorio_Crud<Factura>
    {
        protected string Archivo = "Factura.txt";
        public RepositorioFactura() { }

        public string Create(Factura factura)
        {
            try
            {
                StreamWriter SR = new StreamWriter(Archivo, true);
                SR.WriteLine(factura);
                SR.Close();
                return "Gracias por su compra";
            }
            catch (NullReferenceException nre)
            {
                return "Error en" + nre.Message;
            }
        }

        public void Delete(string Date)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = Reading();
            FileStream file = new FileStream(Archivo, FileMode.Create);
            file.Close();
            foreach (var item in facturas)
            {
                if (!ThisCorrect(item.IdFactura, Date))
                {
                    Create(item);
                }

            }
        }
        private bool ThisCorrect(string DatoRegistrado, string DatoBuscada)
        {
            return DatoRegistrado == DatoBuscada;
        }
        public Factura Maping(string Date)
        {
            try
            {
                if (Date == null || Date == " ")
                {
                    return null;
                }
                var Linea = Date.Split(';');
                Factura factura = new Factura
                {
                    IdFactura = Linea[0],
                    FechaFActura = DateTime.Parse(Linea[1]),
                    TotalValorFactura = double.Parse(Linea[2])
                };
                return factura;
            }
            catch (Exception e)
            {
                return new Factura();
            }
        }

        public List<Factura> Reading()
        {
            try
            {
                List<Factura> Lista = new List<Factura>();
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

        public Factura Searching(string Date)
        {
            var lista = Reading();
            foreach (var item in lista)
            {
                if (item.IdFactura == Date)
                {
                    return item;
                }

            }
            return null;
        }

        public string Update(List<Factura> NewList)
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
