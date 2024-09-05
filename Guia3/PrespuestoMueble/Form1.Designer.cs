namespace PrespuestoMueble
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
            this.btnIniciarPresupuesto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnVerPresupuesto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreAsignado = new System.Windows.Forms.Label();
            this.lblDireccionAsignado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarPresupuesto
            // 
            this.btnIniciarPresupuesto.Location = new System.Drawing.Point(12, 12);
            this.btnIniciarPresupuesto.Name = "btnIniciarPresupuesto";
            this.btnIniciarPresupuesto.Size = new System.Drawing.Size(150, 35);
            this.btnIniciarPresupuesto.TabIndex = 0;
            this.btnIniciarPresupuesto.Text = "Iniciar Presupuesto";
            this.btnIniciarPresupuesto.UseVisualStyleBackColor = true;
            this.btnIniciarPresupuesto.Click += new System.EventHandler(this.btnIniciarPresupuesto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 53);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(150, 35);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVerPresupuesto
            // 
            this.btnVerPresupuesto.Location = new System.Drawing.Point(12, 94);
            this.btnVerPresupuesto.Name = "btnVerPresupuesto";
            this.btnVerPresupuesto.Size = new System.Drawing.Size(150, 35);
            this.btnVerPresupuesto.TabIndex = 2;
            this.btnVerPresupuesto.Text = "Ver Presupuesto";
            this.btnVerPresupuesto.UseVisualStyleBackColor = true;
            this.btnVerPresupuesto.Click += new System.EventHandler(this.btnVerPresupuesto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 135);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(219, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(211, 53);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombreAsignado
            // 
            this.lblNombreAsignado.AutoSize = true;
            this.lblNombreAsignado.Location = new System.Drawing.Point(272, 31);
            this.lblNombreAsignado.Name = "lblNombreAsignado";
            this.lblNombreAsignado.Size = new System.Drawing.Size(10, 13);
            this.lblNombreAsignado.TabIndex = 6;
            this.lblNombreAsignado.Text = "-";
            // 
            // lblDireccionAsignado
            // 
            this.lblDireccionAsignado.AutoSize = true;
            this.lblDireccionAsignado.Location = new System.Drawing.Point(272, 53);
            this.lblDireccionAsignado.Name = "lblDireccionAsignado";
            this.lblDireccionAsignado.Size = new System.Drawing.Size(10, 13);
            this.lblDireccionAsignado.TabIndex = 7;
            this.lblDireccionAsignado.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 180);
            this.Controls.Add(this.lblDireccionAsignado);
            this.Controls.Add(this.lblNombreAsignado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnIniciarPresupuesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPresupuesto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnVerPresupuesto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreAsignado;
        private System.Windows.Forms.Label lblDireccionAsignado;
    }
}

