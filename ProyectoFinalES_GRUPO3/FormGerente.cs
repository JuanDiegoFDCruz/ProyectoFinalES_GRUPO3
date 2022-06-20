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
    public partial class FormGerente : Form
    {
        public FormGerente()
        {
            InitializeComponent();
        }
        ListaVentas admin = new ListaVentas();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsuarioR.Text == "" && txtProductoR.Text == "" && txtPrecioR.Text == "" && txtPrioridadR.Text == "")
            {
                MessageBox.Show("Ingrese los Datos en las cajas de texto");
            }
            else if (txtUsuarioR.Text=="")
            {
                MessageBox.Show("Ingrese el nombre de Usuario del Cliente");
            }
            else if (txtProductoR.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del Producto vendido");
            }
            else if (txtPrecioR.Text == "")
            {
                MessageBox.Show("Ingrese el precio del producto vendido");
            }
            else if (txtPrioridadR.Text == "")
            {
                MessageBox.Show("Ingrese la prioridad de la venta");
            }
            else
            {
                admin.Agregar(txtUsuarioR.Text, txtProductoR.Text, txtPrecioR.Text, txtPrioridadR.Text);
                txtUsuarioR.Clear();
                txtProductoR.Clear();
                txtPrecioR.Clear();
                txtPrioridadR.Clear();
                txtUsuarioR.Focus();
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            lstVentas.Items.Clear();
            txtUsuarioR.Focus();
            admin.Venta(lstVentas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formI = new Superior();
            formI.Show();
        }
    }
}
