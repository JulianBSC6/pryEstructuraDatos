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
    public partial class frmBaseDatosConsulta : Form
    {
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentanaPrincipal volver = new frmVentanaPrincipal();
            volver.Show();
        }
        clsBaseDatos objDatos = new clsBaseDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
           
            objDatos.Listar(dgvGrilla, txtSql.Text);

        }
    }
}
