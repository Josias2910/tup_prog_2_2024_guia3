namespace PrespuestoMueble
{
    partial class DatosProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptarProducto = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Material";
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Items.AddRange(new object[] {
            "Silla",
            "Mesa"});
            this.cbTipoProducto.Location = new System.Drawing.Point(105, 25);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(199, 21);
            this.cbTipoProducto.TabIndex = 5;
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Pino",
            "Algarrobo",
            "Caoba"});
            this.cbMaterial.Location = new System.Drawing.Point(105, 129);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(199, 21);
            this.cbMaterial.TabIndex = 6;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(105, 52);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(199, 20);
            this.tbLargo.TabIndex = 7;
            this.tbLargo.TextChanged += new System.EventHandler(this.tbLargo_TextChanged);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(105, 78);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(199, 20);
            this.tbDescripcion.TabIndex = 8;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(105, 103);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(199, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // btnAceptarProducto
            // 
            this.btnAceptarProducto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptarProducto.Location = new System.Drawing.Point(120, 180);
            this.btnAceptarProducto.Name = "btnAceptarProducto";
            this.btnAceptarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProducto.TabIndex = 10;
            this.btnAceptarProducto.Text = "Aceptar";
            this.btnAceptarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarProducto.Location = new System.Drawing.Point(201, 180);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProducto.TabIndex = 11;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            // 
            // DatosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 217);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnAceptarProducto);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbLargo);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.cbTipoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosProducto";
            this.Text = "DatosProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnAceptarProducto;
        public System.Windows.Forms.Button btnCancelarProducto;
        public System.Windows.Forms.TextBox tbLargo;
        public System.Windows.Forms.TextBox tbDescripcion;
        public System.Windows.Forms.TextBox tbPrecio;
        public System.Windows.Forms.ComboBox cbMaterial;
        public System.Windows.Forms.ComboBox cbTipoProducto;
    }
}