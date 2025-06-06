using ATM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class FrmCuentaFree : Form
    {
        private CuentaFree cuenta;
        public FrmCuentaFree()
        {
            cuenta = new CuentaFree();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = cuenta.Nombre;
            this.txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$ " + cuenta.Saldo;

        }

        private void btnDesposito_Click_1(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                try
                {
                    cuenta.Deposito(float.Parse(txtCantidad.Text));
                    txtSaldo.Text = "$ " + cuenta.Saldo;
                    txtCantidad.Text = "";
                }
                catch
                {
                    MessageBox.Show("Datos capturados no validos");
                    txtCantidad.Text = "";
                }
            }
        }

        

        private void txtCantidad_Enter_1(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "solo numeros";
            }
        }

        private void btnRetiro_Click_1(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                try
                {
                    cuenta.Retiro(float.Parse(txtCantidad.Text));
                    txtCantidad.Text = "";
                    txtSaldo.Text = "$ " + cuenta.Saldo;
                }
                catch
                {
                    MessageBox.Show("Datos capturados no validos");
                    txtCantidad.Text = "";
                }

            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Estado());
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
