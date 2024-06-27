namespace pryEstructuraDatos
{
    partial class frmBaseDatosOperaciones
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.gpbProyecion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyecciónMultiatributo = new System.Windows.Forms.Button();
            this.btnProeccionSimple = new System.Windows.Forms.Button();
            this.gpbSeleccion = new System.Windows.Forms.GroupBox();
            this.BtnSelecciónConvolución = new System.Windows.Forms.Button();
            this.btnSelecciónMultiatributo = new System.Windows.Forms.Button();
            this.btnSelecciónSimple = new System.Windows.Forms.Button();
            this.gpbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.BtnDiferencia = new System.Windows.Forms.Button();
            this.BtnIntersección = new System.Windows.Forms.Button();
            this.btnUnión = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gpbProyecion.SuspendLayout();
            this.gpbSeleccion.SuspendLayout();
            this.gpbAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(13, 30);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(790, 260);
            this.dgvGrilla.TabIndex = 0;
            // 
            // gpbProyecion
            // 
            this.gpbProyecion.Controls.Add(this.btnJuntar);
            this.gpbProyecion.Controls.Add(this.btnProyecciónMultiatributo);
            this.gpbProyecion.Controls.Add(this.btnProeccionSimple);
            this.gpbProyecion.Location = new System.Drawing.Point(13, 296);
            this.gpbProyecion.Name = "gpbProyecion";
            this.gpbProyecion.Size = new System.Drawing.Size(261, 172);
            this.gpbProyecion.TabIndex = 1;
            this.gpbProyecion.TabStop = false;
            this.gpbProyecion.Text = "Operaciones De Proyeccion - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(23, 134);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(214, 32);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProyecciónMultiatributo
            // 
            this.btnProyecciónMultiatributo.Location = new System.Drawing.Point(23, 82);
            this.btnProyecciónMultiatributo.Name = "btnProyecciónMultiatributo";
            this.btnProyecciónMultiatributo.Size = new System.Drawing.Size(214, 32);
            this.btnProyecciónMultiatributo.TabIndex = 1;
            this.btnProyecciónMultiatributo.Text = "Proyección Multiatributo";
            this.btnProyecciónMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnProeccionSimple
            // 
            this.btnProeccionSimple.Location = new System.Drawing.Point(23, 34);
            this.btnProeccionSimple.Name = "btnProeccionSimple";
            this.btnProeccionSimple.Size = new System.Drawing.Size(214, 32);
            this.btnProeccionSimple.TabIndex = 0;
            this.btnProeccionSimple.Text = "Proyección Simple";
            this.btnProeccionSimple.UseVisualStyleBackColor = true;
            // 
            // gpbSeleccion
            // 
            this.gpbSeleccion.Controls.Add(this.BtnSelecciónConvolución);
            this.gpbSeleccion.Controls.Add(this.btnSelecciónMultiatributo);
            this.gpbSeleccion.Controls.Add(this.btnSelecciónSimple);
            this.gpbSeleccion.Location = new System.Drawing.Point(280, 296);
            this.gpbSeleccion.Name = "gpbSeleccion";
            this.gpbSeleccion.Size = new System.Drawing.Size(257, 172);
            this.gpbSeleccion.TabIndex = 2;
            this.gpbSeleccion.TabStop = false;
            this.gpbSeleccion.Text = "Operaciones de Seleccion - WHERE";
            // 
            // BtnSelecciónConvolución
            // 
            this.BtnSelecciónConvolución.Location = new System.Drawing.Point(21, 137);
            this.BtnSelecciónConvolución.Name = "BtnSelecciónConvolución";
            this.BtnSelecciónConvolución.Size = new System.Drawing.Size(214, 32);
            this.BtnSelecciónConvolución.TabIndex = 5;
            this.BtnSelecciónConvolución.Text = "Selección por convolción";
            this.BtnSelecciónConvolución.UseVisualStyleBackColor = true;
            // 
            // btnSelecciónMultiatributo
            // 
            this.btnSelecciónMultiatributo.Location = new System.Drawing.Point(21, 86);
            this.btnSelecciónMultiatributo.Name = "btnSelecciónMultiatributo";
            this.btnSelecciónMultiatributo.Size = new System.Drawing.Size(214, 32);
            this.btnSelecciónMultiatributo.TabIndex = 4;
            this.btnSelecciónMultiatributo.Text = "Selección Multiatributo";
            this.btnSelecciónMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSelecciónSimple
            // 
            this.btnSelecciónSimple.Location = new System.Drawing.Point(20, 32);
            this.btnSelecciónSimple.Name = "btnSelecciónSimple";
            this.btnSelecciónSimple.Size = new System.Drawing.Size(214, 32);
            this.btnSelecciónSimple.TabIndex = 3;
            this.btnSelecciónSimple.Text = "Selección Simple";
            this.btnSelecciónSimple.UseVisualStyleBackColor = true;
            // 
            // gpbAlgebraicas
            // 
            this.gpbAlgebraicas.Controls.Add(this.BtnDiferencia);
            this.gpbAlgebraicas.Controls.Add(this.BtnIntersección);
            this.gpbAlgebraicas.Controls.Add(this.btnUnión);
            this.gpbAlgebraicas.Location = new System.Drawing.Point(543, 296);
            this.gpbAlgebraicas.Name = "gpbAlgebraicas";
            this.gpbAlgebraicas.Size = new System.Drawing.Size(270, 172);
            this.gpbAlgebraicas.TabIndex = 3;
            this.gpbAlgebraicas.TabStop = false;
            this.gpbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // BtnDiferencia
            // 
            this.BtnDiferencia.Location = new System.Drawing.Point(28, 137);
            this.BtnDiferencia.Name = "BtnDiferencia";
            this.BtnDiferencia.Size = new System.Drawing.Size(214, 32);
            this.BtnDiferencia.TabIndex = 8;
            this.BtnDiferencia.Text = "Diferencia";
            this.BtnDiferencia.UseVisualStyleBackColor = true;
            // 
            // BtnIntersección
            // 
            this.BtnIntersección.Location = new System.Drawing.Point(28, 86);
            this.BtnIntersección.Name = "BtnIntersección";
            this.BtnIntersección.Size = new System.Drawing.Size(214, 32);
            this.BtnIntersección.TabIndex = 7;
            this.BtnIntersección.Text = "Intersección";
            this.BtnIntersección.UseVisualStyleBackColor = true;
            // 
            // btnUnión
            // 
            this.btnUnión.Location = new System.Drawing.Point(28, 32);
            this.btnUnión.Name = "btnUnión";
            this.btnUnión.Size = new System.Drawing.Size(214, 32);
            this.btnUnión.TabIndex = 6;
            this.btnUnión.Text = "Unión";
            this.btnUnión.UseVisualStyleBackColor = true;
            this.btnUnión.Click += new System.EventHandler(this.btnUnión_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 470);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbAlgebraicas);
            this.Controls.Add(this.gpbSeleccion);
            this.Controls.Add(this.gpbProyecion);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDatosOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gpbProyecion.ResumeLayout(false);
            this.gpbSeleccion.ResumeLayout(false);
            this.gpbAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox gpbProyecion;
        private System.Windows.Forms.GroupBox gpbSeleccion;
        private System.Windows.Forms.GroupBox gpbAlgebraicas;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyecciónMultiatributo;
        private System.Windows.Forms.Button btnProeccionSimple;
        private System.Windows.Forms.Button BtnSelecciónConvolución;
        private System.Windows.Forms.Button btnSelecciónMultiatributo;
        private System.Windows.Forms.Button btnSelecciónSimple;
        private System.Windows.Forms.Button BtnDiferencia;
        private System.Windows.Forms.Button BtnIntersección;
        private System.Windows.Forms.Button btnUnión;
        private System.Windows.Forms.Button btnVolver;
    }
}