namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.treeArbol = new System.Windows.Forms.TreeView();
            this.gpListado = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.optInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.lstArbolBinario = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gpElementoEliminado.SuspendLayout();
            this.gpNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeArbol
            // 
            this.treeArbol.Location = new System.Drawing.Point(41, 10);
            this.treeArbol.Name = "treeArbol";
            this.treeArbol.Size = new System.Drawing.Size(285, 215);
            this.treeArbol.TabIndex = 0;
            // 
            // gpListado
            // 
            this.gpListado.Controls.Add(this.optPostOrden);
            this.gpListado.Controls.Add(this.optPreOrden);
            this.gpListado.Controls.Add(this.optInOrdenDesc);
            this.gpListado.Controls.Add(this.optInOrdenAsc);
            this.gpListado.Controls.Add(this.dgvGrilla);
            this.gpListado.Location = new System.Drawing.Point(12, 231);
            this.gpListado.Name = "gpListado";
            this.gpListado.Size = new System.Drawing.Size(710, 210);
            this.gpListado.TabIndex = 16;
            this.gpListado.TabStop = false;
            this.gpListado.Text = "Listado Del Arbol";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(6, 170);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 5;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(6, 128);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 4;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrdenDesc
            // 
            this.optInOrdenDesc.AutoSize = true;
            this.optInOrdenDesc.Location = new System.Drawing.Point(6, 85);
            this.optInOrdenDesc.Name = "optInOrdenDesc";
            this.optInOrdenDesc.Size = new System.Drawing.Size(133, 17);
            this.optInOrdenDesc.TabIndex = 3;
            this.optInOrdenDesc.TabStop = true;
            this.optInOrdenDesc.Text = "In-Orden Descendente";
            this.optInOrdenDesc.UseVisualStyleBackColor = true;
            this.optInOrdenDesc.CheckedChanged += new System.EventHandler(this.optInOrdenDesc_CheckedChanged);
            // 
            // optInOrdenAsc
            // 
            this.optInOrdenAsc.AutoSize = true;
            this.optInOrdenAsc.Location = new System.Drawing.Point(6, 40);
            this.optInOrdenAsc.Name = "optInOrdenAsc";
            this.optInOrdenAsc.Size = new System.Drawing.Size(126, 17);
            this.optInOrdenAsc.TabIndex = 2;
            this.optInOrdenAsc.TabStop = true;
            this.optInOrdenAsc.Text = "In-Orden Ascendente";
            this.optInOrdenAsc.UseVisualStyleBackColor = true;
            this.optInOrdenAsc.CheckedChanged += new System.EventHandler(this.optInOrdenAsc_CheckedChanged);
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
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.cmbCodigos);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Controls.Add(this.label4);
            this.gpElementoEliminado.Location = new System.Drawing.Point(555, 10);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(200, 116);
            this.gpElementoEliminado.TabIndex = 15;
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
            this.gpNuevoElemento.TabIndex = 14;
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(571, 150);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(184, 30);
            this.btnEquilibrar.TabIndex = 17;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // lstArbolBinario
            // 
            this.lstArbolBinario.FormattingEnabled = true;
            this.lstArbolBinario.Location = new System.Drawing.Point(748, 239);
            this.lstArbolBinario.Name = "lstArbolBinario";
            this.lstArbolBinario.Size = new System.Drawing.Size(202, 199);
            this.lstArbolBinario.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::pryEstructuraDatos.Properties.Resources.back_158491_1280;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(-1, -1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(36, 31);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstArbolBinario);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gpListado);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gpNuevoElemento);
            this.Controls.Add(this.treeArbol);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.gpListado.ResumeLayout(false);
            this.gpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gpNuevoElemento.ResumeLayout(false);
            this.gpNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeArbol;
        private System.Windows.Forms.GroupBox gpListado;
        private System.Windows.Forms.RadioButton optInOrdenDesc;
        private System.Windows.Forms.RadioButton optInOrdenAsc;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
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
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.ListBox lstArbolBinario;
        private System.Windows.Forms.Button btnVolver;
    }
}