using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if(Raiz==null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if(Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if(Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;

                }
                else
                {
                    NodoPadre.Derecho = Nvo;

                }
            }
        }
        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenAsc(grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R == null)
            {
                // Si R es nulo, no hay nada que hacer.
                return;
            }
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);

        }
        private void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R == null)
            {
                // Si R es nulo, no hay nada que hacer.
                return;
            }

            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        //que esto se pase a un treeview
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            if (R == null)
            {
                // Si R es nulo, no hay nada que hacer.
                return;
            }
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, NodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, NodoPadre);
        }
        public void RecorrerPreOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            PreOrden(grilla, Raiz);
        }
        public void PreOrden(DataGridView grilla, clsNodo R) 
        {
            //Agrega el nodo raiz
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            //recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PreOrden(grilla, R.Izquierdo);
            }

            //recorre el subarbol derecho si existe
            if (R.Derecho != null)
            {
                PreOrden(grilla, R.Derecho);
            }
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while(Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;

            }
            return Aux;
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo !=null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);

            }
            Vector[i]= NodoPadre;
            i = i + 1;
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini , Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <=fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Eliminar (Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 codigo)
        {
            if(NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, codigo);
            }
            if (NodoPadre.Codigo != codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho !=null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, codigo);
            }
        }
        public void InOrdenDesc(ListBox lista, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(lista, R.Derecho);
            }
            lista.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(lista, R.Izquierdo);
            }
        }
        public void RecorrerArbolDesc(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenDesc(lista, Raiz);
        }

      
        public void PreOrden(ListBox lista, clsNodo R)
        {
            lista.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(lista, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(lista, R.Derecho);
            }
        }
        public void RecorrerPreOrden(ListBox lista)
        {
            lista.Items.Clear();
            PreOrden(lista, Raiz);
        }
        public void PostOrden(ListBox lista, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(lista, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(lista, R.Derecho);
            }
            lista.Items.Add(R.Codigo);
        }
        public void RecorrerPostOrden(ListBox lista)
        {
            lista.Items.Clear();
            PostOrden(lista, Raiz);
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R == null)
            {
                // Si R es nulo, no hay nada que hacer.
                return;
            }

            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void RecorrerArbolDesc(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenDesc(dgv, Raiz);
        }

        public void InOrdenDesc(DataGridView Dgv, clsNodo R)//R = Raíz 
        {
            //hay algo a la derecha?
            if (R.Derecho != null)
            {
                InOrdenDesc(Dgv, R.Derecho);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            //hay algo a la izquierda?
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Dgv, R.Izquierdo);
            }
        }
        public void RecorrerArbolDesc(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenDesc(combo, Raiz);
        }
        public void InOrdenDesc(ComboBox combo, clsNodo R)
        {
           
            if (R.Derecho != null)
            {
                InOrdenDesc(combo, R.Derecho);
            }

            combo.Items.Add(R.Codigo);


            if (R.Izquierdo != null)
            {
                InOrdenDesc(combo, R.Izquierdo);
            }
        }
        public void RecorrerPreOrden(ComboBox combo)
        {
            combo.Items.Clear();
            PreOrden(combo, Raiz);
        }

        public void PreOrden(ComboBox combo, clsNodo R)
        {
            combo.Items.Add(R.Codigo); //Agrega el nodo raíz primero

            //recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PreOrden(combo, R.Izquierdo);
            }

            //recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PreOrden(combo, R.Derecho);
            }
        }
        public void PostOrden(ComboBox combo, clsNodo R)
        {
            //Recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PostOrden(combo, R.Izquierdo);
            }

            //recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PostOrden(combo, R.Derecho);
            }

            //agrega el nodo raíz al final
            combo.Items.Add(R.Codigo);
        }
        public void RecorrerPostOrden(ComboBox combo)
        {
            combo.Items.Clear();
            PostOrden(combo, Raiz);
        }
        public void RecorrerPostOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            PostOrden(grilla, Raiz);
        }

        public void PostOrden(DataGridView grilla, clsNodo R)
        {
            //Recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PostOrden(grilla, R.Izquierdo);
            }

            //recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PostOrden(grilla, R.Derecho);
            }

            //agrega el nodo raíz al final
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
    }
}
