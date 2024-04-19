using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        private Int32 cod;
        private string nom;
        private string tra;
        private clsNodo sig;
        private clsNodo ant;



        

        private clsNodo pri;
        private clsNodo ult;

        //Declaro las 2 propiedades

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //Metodo Agregar

        public void Agregar(clsNodo nvo)
        {
            if(Primero == null)
            {
                Primero = nvo;
                Ultimo = nvo;

            }
            else
            {
                if (nvo.Codigo < Primero.Codigo)
                {
                    nvo.Siguiente = Primero;
                    Primero.Anterior = nvo;
                    Primero = nvo;

                }
                else
                {
                    clsNodo Sig = Primero;
                    clsNodo Ant = Primero;
                    while (Sig.Codigo < nvo.Codigo)
                    {
                        Ant = Sig;
                        Sig = Sig.Siguiente;

                    }
                    Ant.Siguiente = nvo;
                    nvo.Siguiente = Sig;
                    Sig.Anterior = nvo;
                    nvo.Anterior = Ant;
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo ant = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}
