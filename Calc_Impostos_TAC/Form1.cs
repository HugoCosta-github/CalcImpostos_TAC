using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calc_Impostos_TAC
{
    public partial class frmCalcTAC : Form
    {
        public frmCalcTAC()
        {
            InitializeComponent();
        }

        public void CalcularImpostos()
        {

            try
            {
                double ValorFrete = double.Parse(txtValorFrete.Text);
                //calculos
                double baseCalculo = ValorFrete * 0.2;
                double baseCalculoIRRF = ValorFrete * 0.1;
                double INSS = baseCalculo * 0.11;
                double SEST_SENAT = baseCalculo * 0.025;

                double IRRF = 0;
                if (baseCalculoIRRF < 1903.98)
                {
                    IRRF = baseCalculoIRRF * 0;
                }
                else if ((baseCalculoIRRF > 1903.98) && (baseCalculoIRRF < 2826.65))
                {
                    IRRF = baseCalculoIRRF * 0.075;
                }
                else if ((baseCalculoIRRF > 2826.65) && (baseCalculoIRRF < 3751.05))
                {
                    IRRF = baseCalculoIRRF * 0.15;
                }
                else if ((baseCalculoIRRF > 3751.05) && (baseCalculoIRRF < 4664.68))
                {
                    IRRF = baseCalculoIRRF * 0.225;
                }
                else
                {
                    IRRF = baseCalculoIRRF * 0.275;
                }
                //PARA MANTER O VALOR DO INSS NO LIMITE LEGAL
                if (INSS > 621.04)
                {
                    INSS = 621.04;
                }

                double total = INSS + IRRF + SEST_SENAT;

                lblINSS.Text = INSS.ToString("C");
                lblIRRF.Text = IRRF.ToString("C");
                lblSEST_SENAT.Text = SEST_SENAT.ToString("C");
                lblTotal.Text = total.ToString("C");
            }
            catch(Exception e)
            {
                MessageBox.Show( e.Message , "Erro!");
            }

        }
        
        public void LimparCampos()
        {
            txtValorFrete.Text = string.Empty;
            lblINSS.Text = string.Empty;
            lblIRRF.Text = string.Empty;
            lblSEST_SENAT.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

                          
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            CalcularImpostos();
        }
                      
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
                        
        }
        
        private void TxtValorFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)//Executa o método quando pressionada a tecla Enter quando foco no textBox
            {
                CalcularImpostos();
            }
            
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
    }
}
