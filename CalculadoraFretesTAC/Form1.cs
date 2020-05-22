using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFretesTAC
{
    public partial class frmCalculadoraFrete : Form
    {
        public frmCalculadoraFrete()
        {
            InitializeComponent();
            this.mskTxbValorCarga.Mask = "999,999.99";
           
        }

        public void LimparCampos()
        {
            mskTxbValorCarga.Text = string.Empty;
            txbKm.Text = string.Empty;
            lblValorFrete.Text = string.Empty;
            mskTxbValorCarga.Focus();
        }

        private void FrmCalcTAC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Carregamento carga = new Carregamento();
            
            carga.Valor = double.Parse(mskTxbValorCarga.Text);
            carga.Km = int.Parse(txbKm.Text);
            carga.CalcularFrete();
           
            lblValorFrete.Text = carga.Frete.ToString("C");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void txbKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//Executa o método quando pressionada a tecla Enter quando foco no textBox
            {
                Carregamento carga = new Carregamento();
                carga.Valor = double.Parse(mskTxbValorCarga.Text);
                carga.Km = int.Parse(txbKm.Text);
                carga.CalcularFrete();
                
                lblValorFrete.Text = carga.Frete.ToString("C");
                mskTxbValorCarga.Focus();
            }
        }
        
        private void FrmCalculadoraFrete_Activated(object sender, EventArgs e)
        {
            mskTxbValorCarga.Focus();
        }
    }
}
