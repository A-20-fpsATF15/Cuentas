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
    public partial class FrmCuentaEm : Form
    {
        private Cuenta_Empresa cuenta;
        public FrmCuentaEm()
        {
            cuenta = new Cuenta_Empresa();
            InitializeComponent();
        }

        private void FrmCuentaEm_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cuenta.Nombre;
            txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$ " + cuenta.Saldo;
            txtRfc.Text = cuenta.RFC;


        }

        private void btnDesposito_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                if (float.Parse(txtCantidad.Text) <= 0)
                {
                    MessageBox.Show("NO usar numeros negativos");
                }
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

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                if (float.Parse(txtCantidad.Text) <= 0)
                {
                    MessageBox.Show("NO usar numeros negativos");
                }
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
            MessageBox.Show(@"Nombre: " + cuenta.Nombre + "\n" + "Numero de cuenta: " + cuenta.NumCuenta + "\n" + "Saldo: $ " + cuenta.Saldo + "\n" + "RFC: " + cuenta.RFC);
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "solo numeros";
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }
    }
}
