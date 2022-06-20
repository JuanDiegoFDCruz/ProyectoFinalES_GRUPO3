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
    public partial class FormCliente : Form
    {
        public FormCliente(Superior.Dato info)
        {
            InitializeComponent();
            lblUsuario.Text = info.usuario;
        }
        PriorityQueue<Compra, int> colaPrioridad = new PriorityQueue<Compra, int>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.producto = cboProducto.Text;
            compra.prioridad = int.Parse(cboPri.Text);
            compra.precio = lblPrecio.Text;

            if (compra.prioridad==1)
            {
                compra.urgencia= "Urgente";
            }
            if (compra.prioridad==2)
            {
                compra.urgencia = "No urgente";
            }
            
            colaPrioridad.Enqueue(compra, int.Parse(cboPri.Text));
            dgvCompra.Rows.Clear();
            foreach (var v in colaPrioridad.UnorderedItems.ToArray())
            {
                dgvCompra.Rows.Add(v.Element.producto, v.Element.precio, v.Element.urgencia, v.Priority);
            }

            StreamWriter sw = new StreamWriter(@"C:\Users\andre\source\repos\ProyectoFinalES_GRUPO3\ProyectoFinalES_GRUPO3\bin\Debug\" + lblUsuario.Text+".txt", true);
            try
            {
                sw.WriteLine("Producto: " + cboProducto.Text);
                sw.WriteLine("Precio: " + lblPrecio.Text);
                sw.WriteLine("Prioridad: " + compra.urgencia);
                sw.WriteLine("\n");
            }
            catch (Exception x)
            {
                MessageBox.Show("Error" + x, "ERROR DE INGRESO");
            }
            sw.Close();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Compra c = new Compra();
            c.producto = cboProducto.Text;

            if (cboProducto.SelectedItem.ToString()=="Pelota de fútbol de Cuero")
            {    
                lblPrecio.Text = "S/50";
            }
            if (cboProducto.SelectedItem.ToString()=="Guantes de Arquero")
            {
                lblPrecio.Text = "S/25";
            }
            if (cboProducto.SelectedItem.ToString() == "Canilleras para Fútbol")
            {
                lblPrecio.Text = "S/20";
            }
            if (cboProducto.SelectedItem.ToString() == "Pelota de Básket Wilson")
            {
                lblPrecio.Text = "S/160";
            }
            if (cboProducto.SelectedItem.ToString() == "Tablero De Básket")
            {
                lblPrecio.Text = "S/250";
            }
            if (cboProducto.SelectedItem.ToString() == "Rodillera de Básket")
            {
                lblPrecio.Text = "S/27";
            }
            if (cboProducto.SelectedItem.ToString() == "Set Pelotas de Tennis")
            {
                lblPrecio.Text = "S/24.90";
            }
            if (cboProducto.SelectedItem.ToString() == "Net Mini Tennis")
            {
                lblPrecio.Text = "S/649.90";
            }
            if (cboProducto.SelectedItem.ToString() == "Pelota de Vóley Comet")
            {
                lblPrecio.Text = "S/62";
            }
            if (cboProducto.SelectedItem.ToString() == "Rodillera de Voley")
            {
                lblPrecio.Text = "S/28";
            }
            if (cboProducto.SelectedItem.ToString() == "Net de Vóley Profesional")
            {
                lblPrecio.Text = "S/130";
            }
            if (cboProducto.SelectedItem.ToString() == "Pelota de HandBall HR Azul")
            {
                lblPrecio.Text = "S/25";
            }
            if (cboProducto.SelectedItem.ToString() == "Casco Ciclista")
            {
                lblPrecio.Text = "S/25";
            }
            if (cboProducto.SelectedItem.ToString() == "Cadena de Seguridad Bicicleta")
            {
                lblPrecio.Text = "S/32";
            }
            
        }

        private void cboPri_SelectedIndexChanged(object sender, EventArgs e){}

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form s = new Superior();
            s.Show();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            Compra c = new Compra();
            colaPrioridad.Dequeue();
            dgvCompra.Rows.Clear();
            foreach (var v in colaPrioridad.UnorderedItems.ToArray())
            {
                dgvCompra.Rows.Add(v.Element.producto, v.Element.precio, v.Element.urgencia, v.Priority);
            }
        }
    }
}
