using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            arbol.Agregar(ObjNodo);
            arbol.Recorrer(dgvGrilla);
            arbol.Recorrer(cmbCodigos);
            arbol.Recorrer(treeArbol);
            arbol.Recorrer(lstArbolBinario);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void optInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            arbol.RecorrerArbolDesc(dgvGrilla);
            arbol.RecorrerArbolDesc(cmbCodigos);
            arbol.RecorrerArbolDesc(lstArbolBinario);
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            arbol.Recorrer(dgvGrilla);
            arbol.Recorrer(cmbCodigos);
            arbol.Recorrer(lstArbolBinario);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            arbol.RecorrerPreOrden(dgvGrilla);
            
            arbol.RecorrerPreOrden(lstArbolBinario);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            arbol.RecorrerPostOrden(dgvGrilla);
            
            arbol.RecorrerPostOrden(lstArbolBinario);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigos.Text);
                arbol.Eliminar(x);
                arbol.Recorrer(dgvGrilla);
                arbol.Recorrer(cmbCodigos);
                arbol.Recorrer(lstArbolBinario);
                arbol.Recorrer(treeArbol);

                optInOrdenDesc.Checked = false;
                optPreOrden.Checked = false;
                optPostOrden.Checked = false;
            }
            else
            {
                MessageBox.Show("El árbol esta vacío");
                cmbCodigos.Text = "";
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            arbol.Equilibrar();
            arbol.Recorrer(treeArbol);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentanaPrincipal volver = new frmVentanaPrincipal();
            volver.Show();
        }
    }
}
