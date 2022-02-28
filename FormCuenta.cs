using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3D
{
    public partial class FormCuenta : Form
    {
        public FormCuenta()
        {
            InitializeComponent();
        }

        private void FormCuenta_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();

            cuenta.NumeroCuenta = textBoxNumeroCuenta.Text; 
            cuenta.Dpi = textBoxDPI.Text;
            cuenta.Saldo = textBoxSaldo.Text;
            

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();

            labelNumeroCuenta.Text = cuenta.NumeroCuenta;
            labelDPI.Text = cuenta.Dpi; 
            labelSaldo.Text = cuenta.Saldo.ToString();
        }
    }
}
