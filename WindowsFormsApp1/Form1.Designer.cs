namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMaxJugadores = new System.Windows.Forms.TextBox();
            this.txtMinJugadores = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.maxJugadores = new System.Windows.Forms.Label();
            this.MinJugadores = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bAnyadir = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblValidacionID = new System.Windows.Forms.Label();
            this.lblValidacionNombre = new System.Windows.Forms.Label();
            this.lblValidacionMinJugadores = new System.Windows.Forms.Label();
            this.lblValidacionMaxJugadores = new System.Windows.Forms.Label();
            this.lblValidacionTiempo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 85);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 174);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtMaxJugadores
            // 
            this.txtMaxJugadores.Location = new System.Drawing.Point(125, 263);
            this.txtMaxJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxJugadores.Name = "txtMaxJugadores";
            this.txtMaxJugadores.Size = new System.Drawing.Size(100, 22);
            this.txtMaxJugadores.TabIndex = 2;
            this.txtMaxJugadores.TextChanged += new System.EventHandler(this.txtMaxJugadores_TextChanged);
            // 
            // txtMinJugadores
            // 
            this.txtMinJugadores.Location = new System.Drawing.Point(439, 174);
            this.txtMinJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinJugadores.Name = "txtMinJugadores";
            this.txtMinJugadores.Size = new System.Drawing.Size(100, 22);
            this.txtMinJugadores.TabIndex = 3;
            this.txtMinJugadores.TextChanged += new System.EventHandler(this.txtMinJugadores_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(439, 263);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 22);
            this.txtTiempo.TabIndex = 4;
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(37, 85);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(40, 178);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // maxJugadores
            // 
            this.maxJugadores.AutoSize = true;
            this.maxJugadores.Location = new System.Drawing.Point(16, 266);
            this.maxJugadores.Name = "maxJugadores";
            this.maxJugadores.Size = new System.Drawing.Size(103, 16);
            this.maxJugadores.TabIndex = 7;
            this.maxJugadores.Text = "Max. Jugadores";
            // 
            // MinJugadores
            // 
            this.MinJugadores.AutoSize = true;
            this.MinJugadores.Location = new System.Drawing.Point(334, 178);
            this.MinJugadores.Name = "MinJugadores";
            this.MinJugadores.Size = new System.Drawing.Size(99, 16);
            this.MinJugadores.TabIndex = 8;
            this.MinJugadores.Text = "Min. Jugadores";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Location = new System.Drawing.Point(357, 263);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(54, 16);
            this.tiempo.TabIndex = 9;
            this.tiempo.Text = "Tiempo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bActualizar);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.bAnyadir);
            this.groupBox1.Controls.Add(this.bUltimo);
            this.groupBox1.Controls.Add(this.bSiguiente);
            this.groupBox1.Controls.Add(this.bAnterior);
            this.groupBox1.Controls.Add(this.bPrimero);
            this.groupBox1.Location = new System.Drawing.Point(53, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(523, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(356, 95);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(96, 33);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(247, 95);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(96, 33);
            this.bActualizar.TabIndex = 6;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(131, 95);
            this.bguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(99, 33);
            this.bguardar.TabIndex = 5;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bAnyadir
            // 
            this.bAnyadir.Location = new System.Drawing.Point(19, 95);
            this.bAnyadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(99, 33);
            this.bAnyadir.TabIndex = 4;
            this.bAnyadir.Text = "Añadir";
            this.bAnyadir.UseVisualStyleBackColor = true;
            this.bAnyadir.Click += new System.EventHandler(this.bAnyadir_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.Location = new System.Drawing.Point(356, 39);
            this.bUltimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(96, 39);
            this.bUltimo.TabIndex = 3;
            this.bUltimo.Text = "Último";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(247, 39);
            this.bSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(96, 39);
            this.bSiguiente.TabIndex = 2;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Location = new System.Drawing.Point(136, 39);
            this.bAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(93, 39);
            this.bAnterior.TabIndex = 1;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(19, 39);
            this.bPrimero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(99, 39);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.Text = "primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(436, 85);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(65, 16);
            this.lblRegistros.TabIndex = 11;
            this.lblRegistros.Text = "Registros";
            // 
            // lblValidacionID
            // 
            this.lblValidacionID.AutoSize = true;
            this.lblValidacionID.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionID.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionID.Location = new System.Drawing.Point(127, 109);
            this.lblValidacionID.Name = "lblValidacionID";
            this.lblValidacionID.Size = new System.Drawing.Size(57, 16);
            this.lblValidacionID.TabIndex = 12;
            this.lblValidacionID.Text = "Valid. ID";
            this.lblValidacionID.Visible = false;
            // 
            // lblValidacionNombre
            // 
            this.lblValidacionNombre.AutoSize = true;
            this.lblValidacionNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionNombre.Location = new System.Drawing.Point(122, 198);
            this.lblValidacionNombre.Name = "lblValidacionNombre";
            this.lblValidacionNombre.Size = new System.Drawing.Size(90, 16);
            this.lblValidacionNombre.TabIndex = 13;
            this.lblValidacionNombre.Text = "Valid. nombre";
            this.lblValidacionNombre.Visible = false;
            // 
            // lblValidacionMinJugadores
            // 
            this.lblValidacionMinJugadores.AutoSize = true;
            this.lblValidacionMinJugadores.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionMinJugadores.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionMinJugadores.Location = new System.Drawing.Point(436, 198);
            this.lblValidacionMinJugadores.Name = "lblValidacionMinJugadores";
            this.lblValidacionMinJugadores.Size = new System.Drawing.Size(132, 16);
            this.lblValidacionMinJugadores.TabIndex = 14;
            this.lblValidacionMinJugadores.Text = "Valid. min. jugadores";
            this.lblValidacionMinJugadores.Visible = false;
            // 
            // lblValidacionMaxJugadores
            // 
            this.lblValidacionMaxJugadores.AutoSize = true;
            this.lblValidacionMaxJugadores.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionMaxJugadores.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionMaxJugadores.Location = new System.Drawing.Point(122, 287);
            this.lblValidacionMaxJugadores.Name = "lblValidacionMaxJugadores";
            this.lblValidacionMaxJugadores.Size = new System.Drawing.Size(136, 16);
            this.lblValidacionMaxJugadores.TabIndex = 15;
            this.lblValidacionMaxJugadores.Text = "Valid. max. jugadores";
            this.lblValidacionMaxJugadores.Visible = false;
            // 
            // lblValidacionTiempo
            // 
            this.lblValidacionTiempo.AutoSize = true;
            this.lblValidacionTiempo.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionTiempo.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionTiempo.Location = new System.Drawing.Point(436, 287);
            this.lblValidacionTiempo.Name = "lblValidacionTiempo";
            this.lblValidacionTiempo.Size = new System.Drawing.Size(85, 16);
            this.lblValidacionTiempo.TabIndex = 16;
            this.lblValidacionTiempo.Text = "Valid. tiempo";
            this.lblValidacionTiempo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.lblValidacionTiempo);
            this.Controls.Add(this.lblValidacionMaxJugadores);
            this.Controls.Add(this.lblValidacionMinJugadores);
            this.Controls.Add(this.lblValidacionNombre);
            this.Controls.Add(this.lblValidacionID);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.MinJugadores);
            this.Controls.Add(this.maxJugadores);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMinJugadores);
            this.Controls.Add(this.txtMaxJugadores);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMaxJugadores;
        private System.Windows.Forms.TextBox txtMinJugadores;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label maxJugadores;
        private System.Windows.Forms.Label MinJugadores;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bAnyadir;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblValidacionID;
        private System.Windows.Forms.Label lblValidacionNombre;
        private System.Windows.Forms.Label lblValidacionMinJugadores;
        private System.Windows.Forms.Label lblValidacionMaxJugadores;
        private System.Windows.Forms.Label lblValidacionTiempo;
    }
}

