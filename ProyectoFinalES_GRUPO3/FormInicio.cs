using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ProyectoFinalES_GRUPO3
{
    public partial class Superior : Form
    {
        public Superior()
        {
            InitializeComponent();
        }
        public struct Dato
        {
            public string usuario;
        }
        

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsuario.SelectedItem.ToString()=="CONTROLADOR DE AFORO" || cboUsuario.SelectedItem.ToString() =="GERENTE")
            {
                txtDNI.Enabled = true;
            }
            else
            {
                txtDNI.Enabled = false;
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Dato info;
            info.usuario = txtUsuario.Text;

            try
            {
                if (cboUsuario.SelectedItem.ToString() == "CLIENTE")
                {
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Ingrese Usuario");
                    }
                    if (txtContraseña.Text == "")
                    {
                        MessageBox.Show("Ingrese contraseña");
                    }
                    else
                    {
                        this.Hide();
                        Form FormCompra = new FormCliente(info);
                        FormCompra.Show();
                    } 
                }
                if (cboUsuario.SelectedItem.ToString() == "CONTROLADOR DE AFORO")
                {
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Ingrese Usuario");
                    }
                    if (txtContraseña.Text == "")
                    {
                        MessageBox.Show("Ingrese contraseña");
                    }
                    if (txtDNI.Text == "")
                    {
                        MessageBox.Show("Ingrese su DNI");
                    }
                    else
                    {
                        this.Hide();
                        Form FormControlador = new FormControlador();
                        FormControlador.Show();
                    } 
                }
                if (cboUsuario.SelectedItem.ToString() == "GERENTE")
                {
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Ingrese Usuario");
                    }
                    if (txtContraseña.Text == "")
                    {
                        MessageBox.Show("Ingrese contraseña");
                    }
                    if (txtDNI.Text == "")
                    {
                        MessageBox.Show("Ingrese su DNI");
                    }
                    else
                    {
                        this.Hide();
                        Form FormAdmin = new FormGerente();
                        FormAdmin.Show();
                    }
                }
                if (cboUsuario.Text=="")
                {
                    MessageBox.Show("Ingrese Tipo de Usuario");
                }
                
            }
            catch(Exception es)
            {
                MessageBox.Show("Error" + es, "ERROR DE INGRESO");
            }
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}