using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalES_GRUPO3
{
    internal class Datos
    {
        private string sede;
        private int afonormal;
        private int porcentaje;
        private double afonuevo;
        private Datos siguiente;
        private Datos anterior;

        public string Sede { get => sede; set => sede = value; }
        public int Afonormal { get => afonormal; set => afonormal = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }
        public double Afonuevo { get => afonuevo; set => afonuevo = value; }
        internal Datos Siguiente { get => siguiente; set => siguiente = value; }
        internal Datos Anterior { get => anterior; set => anterior = value; }
    }
}
