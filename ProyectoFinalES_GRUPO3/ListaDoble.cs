using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalES_GRUPO3
{
    internal class ListaDoble
    {
        private Datos primero = new Datos();
        private Datos ultimo = new Datos();
        public ListaDoble()
        {
            primero = null;
            ultimo = null;
        }
        public void Agregar(string sed, int normal, int por)
        {
            Datos nuevo = new Datos();
            nuevo.Sede = sed;
            nuevo.Afonormal = normal;
            nuevo.Porcentaje = por;
            double naf = por * normal / 100;
            nuevo.Afonuevo = naf;
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
        public void VerAforoID(ListBox Aforos)
        {
            Datos dactual = new Datos();
            dactual = primero;
            if (primero != null)
            {
                while (dactual != null)
                {
                    Aforos.Items.Add("SEDE: " + dactual.Sede + " || AFORO NORMAL: " +
                    dactual.Afonormal + " || PORCENTAJE: " + dactual.Porcentaje + " || AFORO FINAL: " + dactual.Afonuevo + Environment.NewLine);
                    dactual = dactual.Siguiente;
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
        }
        public void Buscar(int d)
        {
            Datos actual = new Datos();
            actual = primero;
            bool flag = false;
            int afoNormalBuscado = d;
            while (actual != null && flag == false)
            {
                if (actual.Afonormal == afoNormalBuscado)
                {
                    MessageBox.Show("El aforo normal: " + afoNormalBuscado + " está en la lista", "Superior Sports", MessageBoxButtons.OK,
               MessageBoxIcon.Information);

                    flag = true;
                }
                actual = actual.Siguiente;
            }
            if (flag == false)
            {
                MessageBox.Show("El aforo normal: " + afoNormalBuscado + " NO está en la lista", "Superior Sports", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
        }
        public void Modificar(int val1, int val2)
        {
            Datos actual = new Datos();
            actual = primero;
            bool flag = false;
            int porcentajeBuscado = val1;
            while (actual != null && flag == false)
            {
                if (actual.Porcentaje == porcentajeBuscado)
                {
                    actual.Porcentaje = val2;
                    MessageBox.Show("El porcentaje: " + porcentajeBuscado + " fue modificado por "
                    + val2, "Superior Sports", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                    flag = true;
                }
                actual = actual.Siguiente;
            }
            if (flag == false)
                MessageBox.Show("El porcentaje: " + porcentajeBuscado + " NO está en la lista", "Superior Sports", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        public void OrdenarAscendente()
        {
            int c = 1, t = 1;
            Datos actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
                c++;
            }
            double tmp = 0;
            do
            {
                actual = primero;
                Datos sig = actual.Siguiente;
                while (actual.Siguiente != null)
                {
                    if (actual.Afonuevo > sig.Afonuevo)
                    {
                        tmp = actual.Afonuevo;
                        actual.Afonuevo = sig.Afonuevo;
                        sig.Afonuevo = tmp;
                        actual = actual.Siguiente;
                        sig = sig.Siguiente;
                    }
                    else
                    {
                        actual = actual.Siguiente;
                        sig = sig.Siguiente;
                    }
                }
                t++;
            } while (t <= c);
        }
        public void OrdenarDescendente()
        {
            int c = 1, t = 1;
            Datos actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
                c++;
            }
            double tmp = 0;
            do
            {
                actual = primero;
                Datos sig = actual.Siguiente;
                while (actual.Siguiente != null)
                {
                    if (actual.Afonuevo < sig.Afonuevo)
                    {
                        tmp = actual.Afonuevo;
                        actual.Afonuevo = sig.Afonuevo;
                        sig.Afonuevo = tmp;
                        actual = actual.Siguiente;
                        sig = sig.Siguiente;
                    }
                    else
                    {
                        actual = actual.Siguiente;
                        sig = sig.Siguiente;
                    }
                }
                t++;
            } while (t <= c);
        }
    
    }
}
