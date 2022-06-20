using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalES_GRUPO3
{
    public partial class FormControlador : Form
    {
        public FormControlador()
        {
            InitializeComponent();
        }

        ListaDoble Laforos = new ListaDoble();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Laforos.Agregar(txtSede.Text, int.Parse(txtAfoNormal.Text), int.Parse(txtPorcentaje.Text));
            txtSede.Clear();
            txtAfoNormal.Clear();
            txtPorcentaje.Clear();
            txtSede.Focus();
        }

        private void btnMostrarID_Click(object sender, EventArgs e)
        {
            lstListaDoble.Items.Clear();
            txtSede.Focus();
            Laforos.VerAforoID(lstListaDoble);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Laforos.Buscar(int.Parse(txtAfoNormal.Text));
            txtAfoNormal.Clear();
            txtSede.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Laforos.Modificar(int.Parse(txtPorcentaje.Text), int.Parse(txtNuevo.Text));
            btnMostrarID_Click(sender, e);
            txtPorcentaje.Clear();
            txtNuevo.Clear();
            txtSede.Focus();
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            Laforos.OrdenarAscendente();
            btnMostrarID_Click(sender, e);
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            Laforos.OrdenarDescendente();
            btnMostrarID_Click(sender, e);
        }
    }
}
