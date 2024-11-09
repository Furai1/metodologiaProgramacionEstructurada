namespace Calculo_bonificaciones
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
            this.components = new System.ComponentModel.Container();
            this.LBLnombreempleado = new System.Windows.Forms.Label();
            this.LBLsueldobasico = new System.Windows.Forms.Label();
            this.TXTnombreempleado = new System.Windows.Forms.TextBox();
            this.TXTsalariobasico = new System.Windows.Forms.TextBox();
            this.LBLbonificacion = new System.Windows.Forms.Label();
            this.LBLretencion = new System.Windows.Forms.Label();
            this.LBLtotalrecibir = new System.Windows.Forms.Label();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.TXTbonificacion = new System.Windows.Forms.TextBox();
            this.TXTretencion = new System.Windows.Forms.TextBox();
            this.TXTtotalarecibir = new System.Windows.Forms.TextBox();
            this.GRPacciones = new System.Windows.Forms.GroupBox();
            this.GRPbonificaciones = new System.Windows.Forms.GroupBox();
            this.RBTN35 = new System.Windows.Forms.RadioButton();
            this.RBTN20 = new System.Windows.Forms.RadioButton();
            this.RBTN10 = new System.Windows.Forms.RadioButton();
            this.lblCalculoDeBonififcaciones = new System.Windows.Forms.Label();
            this.GRPacciones.SuspendLayout();
            this.GRPbonificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLnombreempleado
            // 
            this.LBLnombreempleado.AutoSize = true;
            this.LBLnombreempleado.BackColor = System.Drawing.Color.Transparent;
            this.LBLnombreempleado.Location = new System.Drawing.Point(20, 87);
            this.LBLnombreempleado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLnombreempleado.Name = "LBLnombreempleado";
            this.LBLnombreempleado.Size = new System.Drawing.Size(229, 25);
            this.LBLnombreempleado.TabIndex = 0;
            this.LBLnombreempleado.Text = "Nombre del empleado:";
            this.LBLnombreempleado.Click += new System.EventHandler(this.LBLnombreempleado_Click);
            // 
            // LBLsueldobasico
            // 
            this.LBLsueldobasico.AutoSize = true;
            this.LBLsueldobasico.BackColor = System.Drawing.Color.Transparent;
            this.LBLsueldobasico.Location = new System.Drawing.Point(20, 132);
            this.LBLsueldobasico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLsueldobasico.Name = "LBLsueldobasico";
            this.LBLsueldobasico.Size = new System.Drawing.Size(158, 25);
            this.LBLsueldobasico.TabIndex = 1;
            this.LBLsueldobasico.Text = "Sueldo Basico:";
            // 
            // TXTnombreempleado
            // 
            this.TXTnombreempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnombreempleado.Location = new System.Drawing.Point(270, 84);
            this.TXTnombreempleado.Margin = new System.Windows.Forms.Padding(5);
            this.TXTnombreempleado.Name = "TXTnombreempleado";
            this.TXTnombreempleado.Size = new System.Drawing.Size(362, 30);
            this.TXTnombreempleado.TabIndex = 2;
            this.TXTnombreempleado.TextChanged += new System.EventHandler(this.TXTnombreempleado_TextChanged);
            this.TXTnombreempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTnombreempleado_KeyPress);
            // 
            // TXTsalariobasico
            // 
            this.TXTsalariobasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTsalariobasico.Location = new System.Drawing.Point(270, 129);
            this.TXTsalariobasico.Margin = new System.Windows.Forms.Padding(5);
            this.TXTsalariobasico.Name = "TXTsalariobasico";
            this.TXTsalariobasico.Size = new System.Drawing.Size(160, 30);
            this.TXTsalariobasico.TabIndex = 3;
            this.TXTsalariobasico.TextChanged += new System.EventHandler(this.TXTsalariobasico_TextChanged);
            this.TXTsalariobasico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTsalariobasico_KeyPress);
            // 
            // LBLbonificacion
            // 
            this.LBLbonificacion.AutoSize = true;
            this.LBLbonificacion.BackColor = System.Drawing.Color.Transparent;
            this.LBLbonificacion.Location = new System.Drawing.Point(193, 459);
            this.LBLbonificacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLbonificacion.Name = "LBLbonificacion";
            this.LBLbonificacion.Size = new System.Drawing.Size(136, 25);
            this.LBLbonificacion.TabIndex = 4;
            this.LBLbonificacion.Text = "Bonificacion:";
            // 
            // LBLretencion
            // 
            this.LBLretencion.AutoSize = true;
            this.LBLretencion.BackColor = System.Drawing.Color.Transparent;
            this.LBLretencion.Location = new System.Drawing.Point(188, 508);
            this.LBLretencion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLretencion.Name = "LBLretencion";
            this.LBLretencion.Size = new System.Drawing.Size(187, 25);
            this.LBLretencion.TabIndex = 5;
            this.LBLretencion.Text = "Retencion del 5%:";
            // 
            // LBLtotalrecibir
            // 
            this.LBLtotalrecibir.AutoSize = true;
            this.LBLtotalrecibir.BackColor = System.Drawing.Color.Transparent;
            this.LBLtotalrecibir.Location = new System.Drawing.Point(193, 557);
            this.LBLtotalrecibir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLtotalrecibir.Name = "LBLtotalrecibir";
            this.LBLtotalrecibir.Size = new System.Drawing.Size(151, 25);
            this.LBLtotalrecibir.TabIndex = 6;
            this.LBLtotalrecibir.Text = "Total a recibir:";
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Location = new System.Drawing.Point(60, 33);
            this.BTNcalcular.Margin = new System.Windows.Forms.Padding(5);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(122, 36);
            this.BTNcalcular.TabIndex = 7;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Location = new System.Drawing.Point(60, 91);
            this.BTNlimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(122, 36);
            this.BTNlimpiar.TabIndex = 8;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(60, 156);
            this.BTNsalir.Margin = new System.Windows.Forms.Padding(5);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(122, 36);
            this.BTNsalir.TabIndex = 9;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // TXTbonificacion
            // 
            this.TXTbonificacion.Location = new System.Drawing.Point(389, 450);
            this.TXTbonificacion.Margin = new System.Windows.Forms.Padding(5);
            this.TXTbonificacion.Name = "TXTbonificacion";
            this.TXTbonificacion.ReadOnly = true;
            this.TXTbonificacion.Size = new System.Drawing.Size(160, 30);
            this.TXTbonificacion.TabIndex = 10;
            this.TXTbonificacion.TextChanged += new System.EventHandler(this.TXTbonificacion_TextChanged);
            // 
            // TXTretencion
            // 
            this.TXTretencion.Location = new System.Drawing.Point(389, 503);
            this.TXTretencion.Margin = new System.Windows.Forms.Padding(5);
            this.TXTretencion.Name = "TXTretencion";
            this.TXTretencion.ReadOnly = true;
            this.TXTretencion.Size = new System.Drawing.Size(160, 30);
            this.TXTretencion.TabIndex = 11;
            this.TXTretencion.TextChanged += new System.EventHandler(this.TXTretencion_TextChanged);
            // 
            // TXTtotalarecibir
            // 
            this.TXTtotalarecibir.Location = new System.Drawing.Point(389, 557);
            this.TXTtotalarecibir.Margin = new System.Windows.Forms.Padding(5);
            this.TXTtotalarecibir.Name = "TXTtotalarecibir";
            this.TXTtotalarecibir.ReadOnly = true;
            this.TXTtotalarecibir.Size = new System.Drawing.Size(160, 30);
            this.TXTtotalarecibir.TabIndex = 12;
            this.TXTtotalarecibir.TextChanged += new System.EventHandler(this.TXTtotalarecibir_TextChanged);
            // 
            // GRPacciones
            // 
            this.GRPacciones.BackColor = System.Drawing.Color.Transparent;
            this.GRPacciones.Controls.Add(this.BTNsalir);
            this.GRPacciones.Controls.Add(this.BTNlimpiar);
            this.GRPacciones.Controls.Add(this.BTNcalcular);
            this.GRPacciones.Location = new System.Drawing.Point(389, 201);
            this.GRPacciones.Margin = new System.Windows.Forms.Padding(5);
            this.GRPacciones.Name = "GRPacciones";
            this.GRPacciones.Padding = new System.Windows.Forms.Padding(5);
            this.GRPacciones.Size = new System.Drawing.Size(243, 216);
            this.GRPacciones.TabIndex = 13;
            this.GRPacciones.TabStop = false;
            this.GRPacciones.Text = "Acciones";
            // 
            // GRPbonificaciones
            // 
            this.GRPbonificaciones.BackColor = System.Drawing.Color.Transparent;
            this.GRPbonificaciones.Controls.Add(this.RBTN35);
            this.GRPbonificaciones.Controls.Add(this.RBTN20);
            this.GRPbonificaciones.Controls.Add(this.RBTN10);
            this.GRPbonificaciones.Location = new System.Drawing.Point(110, 201);
            this.GRPbonificaciones.Margin = new System.Windows.Forms.Padding(5);
            this.GRPbonificaciones.Name = "GRPbonificaciones";
            this.GRPbonificaciones.Padding = new System.Windows.Forms.Padding(5);
            this.GRPbonificaciones.Size = new System.Drawing.Size(190, 216);
            this.GRPbonificaciones.TabIndex = 14;
            this.GRPbonificaciones.TabStop = false;
            this.GRPbonificaciones.Text = "Bonificaciones";
            this.GRPbonificaciones.Enter += new System.EventHandler(this.GRPbonificaciones_Enter);
            // 
            // RBTN35
            // 
            this.RBTN35.AutoSize = true;
            this.RBTN35.Location = new System.Drawing.Point(57, 147);
            this.RBTN35.Margin = new System.Windows.Forms.Padding(5);
            this.RBTN35.Name = "RBTN35";
            this.RBTN35.Size = new System.Drawing.Size(76, 29);
            this.RBTN35.TabIndex = 2;
            this.RBTN35.TabStop = true;
            this.RBTN35.Text = "35%";
            this.RBTN35.UseVisualStyleBackColor = true;
            this.RBTN35.CheckedChanged += new System.EventHandler(this.RBTN35_CheckedChanged);
            // 
            // RBTN20
            // 
            this.RBTN20.AutoSize = true;
            this.RBTN20.Location = new System.Drawing.Point(57, 91);
            this.RBTN20.Margin = new System.Windows.Forms.Padding(5);
            this.RBTN20.Name = "RBTN20";
            this.RBTN20.Size = new System.Drawing.Size(76, 29);
            this.RBTN20.TabIndex = 1;
            this.RBTN20.TabStop = true;
            this.RBTN20.Text = "20%";
            this.RBTN20.UseVisualStyleBackColor = true;
            this.RBTN20.CheckedChanged += new System.EventHandler(this.RBTN20_CheckedChanged);
            // 
            // RBTN10
            // 
            this.RBTN10.AutoSize = true;
            this.RBTN10.Location = new System.Drawing.Point(57, 37);
            this.RBTN10.Margin = new System.Windows.Forms.Padding(5);
            this.RBTN10.Name = "RBTN10";
            this.RBTN10.Size = new System.Drawing.Size(76, 29);
            this.RBTN10.TabIndex = 0;
            this.RBTN10.TabStop = true;
            this.RBTN10.Text = "10%";
            this.RBTN10.UseVisualStyleBackColor = true;
            this.RBTN10.CheckedChanged += new System.EventHandler(this.RBTN10_CheckedChanged);
            // 
            // lblCalculoDeBonififcaciones
            // 
            this.lblCalculoDeBonififcaciones.AutoSize = true;
            this.lblCalculoDeBonififcaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculoDeBonififcaciones.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculoDeBonififcaciones.Location = new System.Drawing.Point(204, 22);
            this.lblCalculoDeBonififcaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCalculoDeBonififcaciones.Name = "lblCalculoDeBonififcaciones";
            this.lblCalculoDeBonififcaciones.Size = new System.Drawing.Size(335, 31);
            this.lblCalculoDeBonififcaciones.TabIndex = 15;
            this.lblCalculoDeBonififcaciones.Text = "Cálculo de Bonificaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 647);
            this.Controls.Add(this.lblCalculoDeBonififcaciones);
            this.Controls.Add(this.GRPbonificaciones);
            this.Controls.Add(this.GRPacciones);
            this.Controls.Add(this.TXTtotalarecibir);
            this.Controls.Add(this.TXTretencion);
            this.Controls.Add(this.TXTbonificacion);
            this.Controls.Add(this.LBLtotalrecibir);
            this.Controls.Add(this.LBLretencion);
            this.Controls.Add(this.LBLbonificacion);
            this.Controls.Add(this.TXTsalariobasico);
            this.Controls.Add(this.TXTnombreempleado);
            this.Controls.Add(this.LBLsueldobasico);
            this.Controls.Add(this.LBLnombreempleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calculo de Bonificaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRPacciones.ResumeLayout(false);
            this.GRPbonificaciones.ResumeLayout(false);
            this.GRPbonificaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLnombreempleado;
        private System.Windows.Forms.Label LBLsueldobasico;
        private System.Windows.Forms.TextBox TXTnombreempleado;
        private System.Windows.Forms.TextBox TXTsalariobasico;
        private System.Windows.Forms.Label LBLbonificacion;
        private System.Windows.Forms.Label LBLretencion;
        private System.Windows.Forms.Label LBLtotalrecibir;
        private System.Windows.Forms.Button BTNcalcular;
        private System.Windows.Forms.Button BTNlimpiar;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.TextBox TXTbonificacion;
        private System.Windows.Forms.TextBox TXTretencion;
        private System.Windows.Forms.TextBox TXTtotalarecibir;
        private System.Windows.Forms.GroupBox GRPacciones;
        private System.Windows.Forms.GroupBox GRPbonificaciones;
        private System.Windows.Forms.RadioButton RBTN10;
        private System.Windows.Forms.RadioButton RBTN35;
        private System.Windows.Forms.RadioButton RBTN20;
        private System.Windows.Forms.Label lblCalculoDeBonififcaciones;
    }
}

