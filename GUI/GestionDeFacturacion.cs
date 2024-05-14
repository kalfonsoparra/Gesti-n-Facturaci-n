using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GestionDeFacturacion : Form
    {
        public GestionDeFacturacion()
        {
            InitializeComponent();
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
    }
}
