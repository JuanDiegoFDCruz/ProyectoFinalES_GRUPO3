using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFinalES_GRUPO3
{
    internal class ListaVentas
    {
        private Registro primero = new Registro();
        private Registro ultimo = new Registro();
        public ListaVentas()
        {
            primero = null;
            ultimo = null;
        }
        public void Agregar(string usua, string pro, string prec, string priority)
        {
            Registro nuevo = new Registro();
            nuevo.Usuario = usua;
            nuevo.Producto = pro;
            nuevo.Precio = prec;
            nuevo.Prioridad = priority;
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Anterior = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }
        public void Venta(ListBox Ventas)
        {
            Registro datoactual = new Registro();
            datoactual = primero;
            if (primero != null)
            {
                while (datoactual != null)
                {
                    _ = Ventas.Items.Add(  "Usuario: " + datoactual.Usuario+"||"
                                  +  "Producto: " + datoactual.Producto+"||"
                                  +  "PORCENTAJE: " + datoactual.Precio+"||"
                                  +  "Prioridad: " + datoactual.Prioridad
                                  + Environment.NewLine);
                   datoactual = datoactual.Siguiente;
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
        }
    }
}
