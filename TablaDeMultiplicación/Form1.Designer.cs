namespace TablaDeMultiplicación
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
            this.lblIngreseUnNumero = new System.Windows.Forms.Label();
            this.txtIngresarNumero = new System.Windows.Forms.TextBox();
            this.lstTabla = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseUnNumero
            // 
            this.lblIngreseUnNumero.AutoSize = true;
            this.lblIngreseUnNumero.Location = new System.Drawing.Point(47, 50);
            this.lblIngreseUnNumero.Name = "lblIngreseUnNumero";
            this.lblIngreseUnNumero.Size = new System.Drawing.Size(167, 22);
            this.lblIngreseUnNumero.TabIndex = 0;
            this.lblIngreseUnNumero.Text = "Ingrese un Número:";
            // 
            // txtIngresarNumero
            // 
            this.txtIngresarNumero.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtIngresarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarNumero.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIngresarNumero.Location = new System.Drawing.Point(220, 47);
            this.txtIngresarNumero.Name = "txtIngresarNumero";
            this.txtIngresarNumero.Size = new System.Drawing.Size(143, 28);
            this.txtIngresarNumero.TabIndex = 1;
            this.txtIngresarNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresarNumero_KeyPress);
            // 
            // lstTabla
            // 
            this.lstTabla.FormattingEnabled = true;
            this.lstTabla.ItemHeight = 22;
            this.lstTabla.Location = new System.Drawing.Point(51, 127);
            this.lstTabla.Name = "lstTabla";
            this.lstTabla.Size = new System.Drawing.Size(312, 378);
            this.lstTabla.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCalcular.Location = new System.Drawing.Point(491, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 64);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLimpiar.Location = new System.Drawing.Point(491, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 64);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSalir.Location = new System.Drawing.Point(491, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 64);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(751, 619);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstTabla);
            this.Controls.Add(this.txtIngresarNumero);
            this.Controls.Add(this.lblIngreseUnNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tabla de Multiplicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseUnNumero;
        private System.Windows.Forms.TextBox txtIngresarNumero;
        private System.Windows.Forms.ListBox lstTabla;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

