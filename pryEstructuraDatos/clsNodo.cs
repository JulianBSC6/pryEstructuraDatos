using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class clsNodo
    {
        //Campos del nodo
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;

        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
