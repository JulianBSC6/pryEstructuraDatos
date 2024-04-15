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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;
            Lista.Agregar(objNodo);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(dgvGrilla);
            Lista.Recorrer();
            Lista.Recorrer(cmbCodigos);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
