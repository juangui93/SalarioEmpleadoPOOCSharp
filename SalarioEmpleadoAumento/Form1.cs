using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalarioEmpleadoAumento
{
    public partial class Form1 : Form
    {
        Salario salario = new Salario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            salario.setSalario(double.Parse(txtSalario.Text));
            salario.setAntiguedad(cbxAntiguedad.Text);
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            lblSalario.Visible = true;
            lblAumento.Visible = true;
            lblTotal.Visible = true;
            lblSalario.Text = Convert.ToString(salario.getSalario());
            salario.calcularSalario();
            lblAumento.Text = Convert.ToString(salario.getAumento());
            lblTotal.Text = Convert.ToString(salario.getTotal());
           
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtSalario.Text = String.Empty;
            cbxAntiguedad.Text = String.Empty;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblSalario.Visible = false;
            lblAumento.Visible = false;
            lblTotal.Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
