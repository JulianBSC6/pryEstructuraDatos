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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;
            Lista.Agregar(objNodo);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(dgvGrilla);
            Lista.Recorrer();
            Lista.Recorrer(cmbCodigos);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigos.Text);
                Lista.EliminarListaDoble(x);
                Lista.Recorrer(dgvGrilla);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbCodigos);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
                cmbCodigos.Text = "";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvGrilla);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cmbCodigos);
            Lista.Recorrer();
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDescendente(dgvGrilla);
            Lista.RecorrerDescendente(lstListaDoble);
            Lista.RecorrerDescendente(cmbCodigos);
            Lista.RecorrerDescendente();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentanaPrincipal volver = new frmVentanaPrincipal();
            volver.Show();
        }
    }
}
