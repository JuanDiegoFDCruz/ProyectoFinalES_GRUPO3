using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalES_GRUPO3
{
    internal class Registro
    {
        private string usuario;
        private string producto;
        private string precio;
        private string prioridad;
        private Registro siguiente;
        private Registro anterior;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        internal Registro Siguiente { get => siguiente; set => siguiente = value; }
        internal Registro Anterior { get => anterior; set => anterior = value; }
    }
}
