﻿namespace pryEstructuraDatos
{
    partial class frmListaDoble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpListado = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigos = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gpElementoEliminado.SuspendLayout();
            this.gpNuevoElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpListado
            // 
            this.gpListado.Controls.Add(this.dgvGrilla);
            this.gpListado.Controls.Add(this.lstListaDoble);
            this.gpListado.Location = new System.Drawing.Point(45, 210);
            this.gpListado.Name = "gpListado";
            this.gpListado.Size = new System.Drawing.Size(710, 231);
            this.gpListado.TabIndex = 12;
            this.gpListado.TabStop = false;
            this.gpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(198, 20);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(486, 198);
            this.dgvGrilla.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(6, 19);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(185, 199);
            this.lstListaDoble.TabIndex = 0;
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.cmbCodigos);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Controls.Add(this.label4);
            this.gpElementoEliminado.Location = new System.Drawing.Point(555, 10);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(200, 116);
            this.gpElementoEliminado.TabIndex = 11;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento a eliminar";
            // 
            // cmbCodigos
            // 
            this.cmbCodigos.FormattingEnabled = true;
            this.cmbCodigos.Location = new System.Drawing.Point(53, 32);
            this.cmbCodigos.Name = "cmbCodigos";
            this.cmbCodigos.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigos.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código:";
            // 
            // gpNuevoElemento
            // 
            this.gpNuevoElemento.Controls.Add(this.btnAgregar);
            this.gpNuevoElemento.Controls.Add(this.txtTramite);
            this.gpNuevoElemento.Controls.Add(this.txtNombre);
            this.gpNuevoElemento.Controls.Add(this.txtCodigo);
            this.gpNuevoElemento.Controls.Add(this.label3);
            this.gpNuevoElemento.Controls.Add(this.label2);
            this.gpNuevoElemento.Controls.Add(this.label1);
            this.gpNuevoElemento.Location = new System.Drawing.Point(332, 10);
            this.gpNuevoElemento.Name = "gpNuevoElemento";
            this.gpNuevoElemento.Size = new System.Drawing.Size(208, 176);
            this.gpNuevoElemento.TabIndex = 10;
            this.gpNuevoElemento.TabStop = false;
            this.gpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(196, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(76, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDescendente);
            this.groupBox1.Controls.Add(this.optAscendente);
            this.groupBox1.Location = new System.Drawing.Point(555, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Datos";
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Location = new System.Drawing.Point(7, 43);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(89, 17);
            this.optDescendente.TabIndex = 1;
            this.optDescendente.TabStop = true;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            this.optDescendente.CheckedChanged += new System.EventHandler(this.optDescendente_CheckedChanged);
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Location = new System.Drawing.Point(7, 20);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(82, 17);
            this.optAscendente.TabIndex = 0;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            this.optAscendente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDatos.Properties.Resources.doble;
            this.pictureBox1.Location = new System.Drawing.Point(24, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::pryEstructuraDatos.Properties.Resources.back_158491_1280;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(36, 31);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpListado);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gpNuevoElemento);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente Enlazada";
            this.gpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gpNuevoElemento.ResumeLayout(false);
            this.gpNuevoElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpListado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.ComboBox cmbCodigos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optAscendente;
        private System.Windows.Forms.RadioButton optDescendente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolver;
    }
}