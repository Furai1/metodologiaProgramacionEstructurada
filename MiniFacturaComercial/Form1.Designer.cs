namespace MiniFacturaComercial
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbCodigoDelProducto = new System.Windows.Forms.Label();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigoDelProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.grpDescuento = new System.Windows.Forms.GroupBox();
            this.rad15Porciento = new System.Windows.Forms.RadioButton();
            this.rad10Porciento = new System.Windows.Forms.RadioButton();
            this.rad5Porciento = new System.Windows.Forms.RadioButton();
            this.rad1Porciento = new System.Windows.Forms.RadioButton();
            this.rad0Porciento = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpDescuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(406, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "COMERCIAL \"EL TRIUNFO\"";
            // 
            // lbCodigoDelProducto
            // 
            this.lbCodigoDelProducto.AutoSize = true;
            this.lbCodigoDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoDelProducto.Location = new System.Drawing.Point(62, 119);
            this.lbCodigoDelProducto.Name = "lbCodigoDelProducto";
            this.lbCodigoDelProducto.Size = new System.Drawing.Size(198, 22);
            this.lbCodigoDelProducto.TabIndex = 1;
            this.lbCodigoDelProducto.Text = "Código del Producto:";
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelProducto.Location = new System.Drawing.Point(62, 159);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(204, 22);
            this.lblNombreDelProducto.TabIndex = 2;
            this.lblNombreDelProducto.Text = "Nombre del Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(62, 198);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(118, 22);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio (C$):";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(62, 237);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(96, 22);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCodigoDelProducto
            // 
            this.txtCodigoDelProducto.Location = new System.Drawing.Point(293, 116);
            this.txtCodigoDelProducto.Name = "txtCodigoDelProducto";
            this.txtCodigoDelProducto.Size = new System.Drawing.Size(239, 28);
            this.txtCodigoDelProducto.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(293, 195);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(239, 28);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(293, 156);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(239, 28);
            this.txtNombreDelProducto.TabIndex = 8;
            // 
            // grpDescuento
            // 
            this.grpDescuento.Controls.Add(this.rad15Porciento);
            this.grpDescuento.Controls.Add(this.rad10Porciento);
            this.grpDescuento.Controls.Add(this.rad5Porciento);
            this.grpDescuento.Controls.Add(this.rad1Porciento);
            this.grpDescuento.Controls.Add(this.rad0Porciento);
            this.grpDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescuento.Location = new System.Drawing.Point(606, 108);
            this.grpDescuento.Name = "grpDescuento";
            this.grpDescuento.Size = new System.Drawing.Size(239, 218);
            this.grpDescuento.TabIndex = 9;
            this.grpDescuento.TabStop = false;
            this.grpDescuento.Text = "Descuento";
            // 
            // rad15Porciento
            // 
            this.rad15Porciento.AutoSize = true;
            this.rad15Porciento.Location = new System.Drawing.Point(46, 177);
            this.rad15Porciento.Name = "rad15Porciento";
            this.rad15Porciento.Size = new System.Drawing.Size(77, 26);
            this.rad15Porciento.TabIndex = 4;
            this.rad15Porciento.TabStop = true;
            this.rad15Porciento.Text = "15%";
            this.rad15Porciento.UseVisualStyleBackColor = true;
            // 
            // rad10Porciento
            // 
            this.rad10Porciento.AutoSize = true;
            this.rad10Porciento.Location = new System.Drawing.Point(46, 145);
            this.rad10Porciento.Name = "rad10Porciento";
            this.rad10Porciento.Size = new System.Drawing.Size(77, 26);
            this.rad10Porciento.TabIndex = 3;
            this.rad10Porciento.TabStop = true;
            this.rad10Porciento.Text = "10%";
            this.rad10Porciento.UseVisualStyleBackColor = true;
            // 
            // rad5Porciento
            // 
            this.rad5Porciento.AutoSize = true;
            this.rad5Porciento.Location = new System.Drawing.Point(46, 113);
            this.rad5Porciento.Name = "rad5Porciento";
            this.rad5Porciento.Size = new System.Drawing.Size(65, 26);
            this.rad5Porciento.TabIndex = 2;
            this.rad5Porciento.TabStop = true;
            this.rad5Porciento.Text = "5%";
            this.rad5Porciento.UseVisualStyleBackColor = true;
            // 
            // rad1Porciento
            // 
            this.rad1Porciento.AutoSize = true;
            this.rad1Porciento.Location = new System.Drawing.Point(46, 81);
            this.rad1Porciento.Name = "rad1Porciento";
            this.rad1Porciento.Size = new System.Drawing.Size(65, 26);
            this.rad1Porciento.TabIndex = 1;
            this.rad1Porciento.TabStop = true;
            this.rad1Porciento.Text = "1%";
            this.rad1Porciento.UseVisualStyleBackColor = true;
            // 
            // rad0Porciento
            // 
            this.rad0Porciento.AutoSize = true;
            this.rad0Porciento.Location = new System.Drawing.Point(46, 49);
            this.rad0Porciento.Name = "rad0Porciento";
            this.rad0Porciento.Size = new System.Drawing.Size(65, 26);
            this.rad0Porciento.TabIndex = 0;
            this.rad0Porciento.TabStop = true;
            this.rad0Porciento.Text = "0%";
            this.rad0Porciento.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(66, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(198, 48);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(293, 235);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(132, 28);
            this.nudCantidad.TabIndex = 11;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(62, 408);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(109, 22);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal →";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(62, 449);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(130, 22);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.Text = "Descuento →";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(62, 492);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(125, 22);
            this.lblIVA.TabIndex = 14;
            this.lblIVA.Text = "IVA (15%) →";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(62, 533);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 22);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total →";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(214, 405);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(181, 28);
            this.txtSubtotal.TabIndex = 16;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(214, 446);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(181, 28);
            this.txtDescuento.TabIndex = 17;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(214, 489);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(181, 28);
            this.txtIVA.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(214, 530);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(181, 28);
            this.txtTotal.TabIndex = 19;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(558, 408);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 39);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(558, 463);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(172, 39);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(558, 516);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(172, 39);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(908, 619);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDescuento);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigoDelProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreDelProducto);
            this.Controls.Add(this.lbCodigoDelProducto);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MINI FACTURA";
            this.grpDescuento.ResumeLayout(false);
            this.grpDescuento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbCodigoDelProducto;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigoDelProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.GroupBox grpDescuento;
        private System.Windows.Forms.RadioButton rad15Porciento;
        private System.Windows.Forms.RadioButton rad10Porciento;
        private System.Windows.Forms.RadioButton rad5Porciento;
        private System.Windows.Forms.RadioButton rad1Porciento;
        private System.Windows.Forms.RadioButton rad0Porciento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

