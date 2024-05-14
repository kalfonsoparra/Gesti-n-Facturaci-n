using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GestionDeProductos : Form
    {
        ServicioProducto servicioProducto = new ServicioProducto();
        Producto Producto = new Producto();
        public GestionDeProductos()
        {
            InitializeComponent();
        }

        private void GestionDeProductos_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioProducto.Consultar());
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            this.Hide();
            principal.Show();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            Producto.ReferenciaProducto = TbReferenciaProducto.Text;
            Producto.NombreProducto = TbNombreProducto.Text;
            Producto.Existencias = int.Parse(TbCantidadProducto.Text);
            Producto.StockMinimo = int.Parse(TbStockMinimo.Text);
            Producto.PrecioUnitario = double.Parse(TbValorUnitario.Text);
            Producto.EstadoProducto = CbEstado.Text;
            Guardar(Producto);
            CargarGrilla(servicioProducto.Consultar());
            Limpiar();
            
        }

        private void BtBuscarProducto_Click(object sender, EventArgs e)
        {
            string Referencia = TbReferenciaProducto.Text;
            Producto product = servicioProducto.Buscar(Referencia);
            DevolverProducto(product);
        }

        private void BtActualizarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            DialogResult respuesta = MessageBox.Show("¿Estas seguro querer actualizar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                string referencia = TbReferenciaProducto.Text;
                if (servicioProducto.Buscar(referencia) != null)
                {
                    producto.ReferenciaProducto = referencia;
                    producto.NombreProducto = TbNombreProducto.Text;
                    producto.Existencias = int.Parse(TbCantidadProducto.Text);
                    producto.StockMinimo= int.Parse(TbStockMinimo.Text);
                    producto.PrecioUnitario = double.Parse(TbValorUnitario.Text);
                    producto.EstadoProducto = CbEstado.Text;
                    var msg = servicioProducto.Actualizar(producto);
                    MessageBox.Show(msg);
                    CargarGrilla(servicioProducto.Consultar());
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el producto");
                }
            }
        }
        void Guardar(Producto producto)
        {
            var mensaje = servicioProducto.Guardar(producto);
            MessageBox.Show(mensaje);
        }
        void CargarGrilla(List<Producto> list)
        {
            DgvProductos.Rows.Clear();
            foreach (var item in list)
            {
                DgvProductos.Rows.Add(item.ReferenciaProducto, item.NombreProducto, item.Existencias, item.PrecioUnitario, item.StockMinimo,item.EstadoProducto);
            }
        }
        void Limpiar()
        {
            TbReferenciaProducto.Text = string.Empty;
            TbNombreProducto.Text = string.Empty;
            TbCantidadProducto.Text = string.Empty;
            TbStockMinimo.Text = string.Empty;
            TbValorUnitario.Text = string.Empty;
            CbEstado.Text = string.Empty;
        }
        void DevolverProducto(Producto producto)
        {
            try
            {
                if (Producto != null)
                {
                    TbNombreProducto.Text = producto.NombreProducto;
                    TbCantidadProducto.Text=producto.Existencias.ToString();
                    TbStockMinimo.Text = producto.StockMinimo.ToString();
                    TbValorUnitario.Text = producto.PrecioUnitario.ToString();
                    CbEstado.Text = producto.EstadoProducto;

                    MessageBox.Show("Producto encontrada.", "Busqueda");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No se encontró ningun producto con la referencia proporcionada.", "Busqueda");
            }
        }
        #region Errores
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
