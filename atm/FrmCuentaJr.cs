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
    public partial class FrmCuentaJr : Form
    {
        private CuentaJR cuenta;
        public FrmCuentaJr()
        {
            cuenta = new CuentaJR();
            InitializeComponent();
        }

        private void FrmCuentaJr_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cuenta.Nombre;
            txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$ " + cuenta.Saldo;
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
            MessageBox.Show(cuenta.Estado());
        }

        private void txtCantidad_Click(object sender, EventArgs e)
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
    }
}
