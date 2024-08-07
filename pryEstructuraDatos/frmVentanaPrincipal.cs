﻿using System;
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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void datosDeDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatosDesarrollador pasar = new frmDatosDesarrollador();
            pasar.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCola pasar = new frmCola();
            pasar.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListaSimple pasar = new frmListaSimple();
            pasar.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPila pila = new frmPila();
            pila.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListaDoble pasar = new frmListaDoble();
            pasar.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmArbolBinario pasar = new frmArbolBinario();
            pasar.Show();
        }

        private void operacionesConTablasDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBaseDatosOperaciones pasar = new frmBaseDatosOperaciones();
            pasar.Show();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBaseDatosConsulta pasar = new frmBaseDatosConsulta();
            pasar.Show();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBaseDatosRepasoOperaciones pasar = new frmBaseDatosRepasoOperaciones ();
            pasar.Show();
        }
    }
}
