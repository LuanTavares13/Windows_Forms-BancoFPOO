using System;
using System.Windows.Forms;
using WF_BancoPOO.Model;

namespace WF_BancoPOO
{
    public partial class Form1 : Form
    {
        Conta novaConta = new Conta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double vlr_dep = Convert.ToDouble(txtValorDepositar.Text);
            novaConta.Depositar(vlr_dep);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double vlr_sacar = Convert.ToDouble(txtValorSacar.Text);
            novaConta.Sacar(vlr_sacar);
        }

        private void btnExibirSaldo_Click(object sender, EventArgs e)
        {
            lblValorSaldo.Text = Convert.ToString(novaConta.saldo);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //txtValorDepositar.Text = String.Empty;
            //txtValorSacar.Text = String.Empty;
            lblValorSaldo.Text = String.Empty;

            foreach (Control caixas in this.Controls)
            {
                if (caixas is TextBox)
                {
                    ((TextBox)caixas).Text = String.Empty;
                }
            }

        }

        private void txtValorDepositar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
