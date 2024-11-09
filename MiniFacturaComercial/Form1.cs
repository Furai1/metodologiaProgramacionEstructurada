using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniFacturaComercial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Datos leídos correctamente!");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoDelProducto.Clear();
            txtDescuento.Clear();
            txtIVA.Clear();
            txtNombreDelProducto.Clear();
            txtPrecio.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            nudCantidad.Value = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validación de datos de entrada
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || !int.TryParse(nudCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el precio y la cantidad.", "Error de entrada");
                return;
            }

            // Cálculo del subtotal
            decimal subtotal = precio * cantidad;
            txtSubtotal.Text = "C$" + subtotal.ToString("N2");

            // Obtener el porcentaje de descuento seleccionado en los RadioButton
            int descuentoSeleccionado = ObtenerDescuentoSeleccionado();

            // Calcular descuento
            decimal descuento = subtotal * descuentoSeleccionado / 100;
            txtDescuento.Text = "C$" + descuento.ToString("N2");

            // Calcular IVA (15%)
            decimal iva = subtotal * 0.15m;
            txtIVA.Text = "C$" + iva.ToString("N2");

            // Calcular total
            decimal total = subtotal - descuento + iva;
            txtTotal.Text = "C$" + total.ToString("N2");
        }

        private int ObtenerDescuentoSeleccionado()
        {
            if (rad0Porciento.Checked) return 0; // Asegúrate de que los nombres de los RadioButton coincidan
            if (rad1Porciento.Checked) return 1;
            if (rad5Porciento.Checked) return 5;
            if (rad10Porciento.Checked) return 10;
            if (rad15Porciento.Checked) return 15;

            return 0; // Valor predeterminado en caso de que no haya ningún RadioButton seleccionado
        }
    }
}
