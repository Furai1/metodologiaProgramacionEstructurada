using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SueldoEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSueldoCorrespondiente.ReadOnly = true;
            txtSueldoCorrespondiente.TabStop = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string cargo;
            cargo = cmbCargo.Text;
            if (cargo == "Gerente")
            {
                txtSueldoCorrespondiente.Text = "32,500";
            }
            if (cargo == "Administrador")
            {
                txtSueldoCorrespondiente.Text = "10,000";
            }
            if (cargo == "Secretaria")
            {
                txtSueldoCorrespondiente.Text = "5,500";
            }
            if (cargo == "Contador")
            {
                txtSueldoCorrespondiente.Text = "6,000";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtSueldoCorrespondiente.Text = "";
            cmbCargo.Text = "";
        }
    }
}
