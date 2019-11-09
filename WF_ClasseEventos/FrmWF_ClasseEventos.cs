using System;
using System.Windows.Forms;
using WF_ClasseEventos.Classes;

/// <summary>
/// BEM MODIFICADO, MAS BASEADO NO EXEMPLO DO MACORATTI:
/// C# - Como fazer uma classe definir e disparar eventos
/// http://www.macoratti.net/19/05/c_classevents1.htm
/// </summary>
namespace WF_ClasseEventos
{
    public partial class FrmWF_ClasseEventos : Form
    {
        private static Conta ContaBancaria;

        public delegate void AtualizaStatusEventHandler(string texto);
        public event AtualizaStatusEventHandler LogStatus;

        public FrmWF_ClasseEventos()
        {
            InitializeComponent();
        }

        private void FrmWF_ClasseEventos_Load(object sender, EventArgs e)
        {
            // Inscrevendo-se no evento HandleLogStatusEvent
            LogStatus += HandleLogStatusEvent;

            //Cria novo objeto do tipo conta e define o saldo
            ContaBancaria = new Conta
            {
                Saldo = 100m
            };
            //exibe o valor do saldo
            TxtSaldo.Text = ContaBancaria.Saldo.ToString("C");
            // Inscrever-se no evento SaldoInsuficiente
            ContaBancaria.SaldoInsuficiente += Conta_SaldoInsuficiente;

            OnLogStatus("===== INICIANDO O PROCESSO =====");
            OnLogStatus("Abre o form com o saldo: " + TxtSaldo.Text);
        }

        /// <summary>
        /// Trata o evento SaldoInsuficinte da conta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Conta_SaldoInsuficiente(object sender, SaldoInsuficienteArgs e)
        {
            // Cria um objeto do tipo Conta
            Conta conta = sender as Conta;
            // Pergunta se permite a transação
            if (MessageBox.Show("Saldo Insuficiente.\n\n    Saldo Atual: " +
                conta.Saldo.ToString("C") + "\n    Valor Débito: " + e.ValorDebito.ToString("C") + "\n\n" +
                "Deseja permitir esta transação ?",
                "Permite ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Permite o debito
                e.Libera = true;
            }
        }

        /// <summary>
        /// Essa função unifica o Crédito e o Débito
        /// </summary>
        /// <param name="strCD">Valor a ser computado.</param>
        /// <param name="blnCD">Informa se é "C"rédito ou "D"ébito. </param>
        public string CreditoDebito(decimal decCD, char blnCD)
        {
            try
            {
                if (blnCD == 'C')
                {
                    OnLogStatus(ContaBancaria.Credito(decCD));

                }
                else if (blnCD == 'D')
                {
                    OnLogStatus(ContaBancaria.Debito(decCD));
                }
                else
                {
                    OnLogStatus("ERRO na operação Débito / Crédito.");
                    return "";
                }
            }
            catch (Exception ex)
            {
                OnLogStatus("Erro: " + ex.Message);
            }

            return ContaBancaria.Saldo.ToString("C");
        }

        private void HandleLogStatusEvent(string texto)
        {
            try
            {
                if (!String.IsNullOrEmpty(texto))
                {
                    TxtLinhas.Text = TxtMensagens.Lines.Length.ToString();
                    TxtTamanho.Text = TxtMensagens.Text.Length.ToString();

                    if (rbtDesce.Checked)
                    {
                        TxtMensagens.Text = DateTime.Now.Hour.ToString("00") + ":"
                                          + DateTime.Now.Minute.ToString("00") + ":"
                                          + DateTime.Now.Second.ToString("00") + ":"
                                          + DateTime.Now.Millisecond.ToString("00") + " - "
                                          + texto
                                          + Environment.NewLine
                                          + TxtMensagens.Text;
                    }
                    else if (rbtSobe.Checked)
                    {

                        TxtMensagens.Text += DateTime.Now.Hour.ToString("00") + ":"
                                           + DateTime.Now.Minute.ToString("00") + ":"
                                           + DateTime.Now.Second.ToString("00") + ":"
                                           + DateTime.Now.Millisecond.ToString("00") + " - "
                                           + texto
                                           + Environment.NewLine;

                        TxtMensagens.SelectionStart = TxtMensagens.Text.Length;
                        TxtMensagens.ScrollToCaret();
                        TxtMensagens.Refresh();
                    }
                }
                else TxtMensagens.Clear();

            }
            catch (Exception ex)
            {
                OnLogStatus("Erro em: " + ex.Message);
            }
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            decimal decValor = 0;
            bool blnSucesso = true;

            if (!string.IsNullOrEmpty(TxtValor.Text))
            {
                blnSucesso = decimal.TryParse(TxtValor.Text, out decValor);

                if (blnSucesso)
                {
                    TxtSaldo.Text = CreditoDebito(decValor, 'C');
                }
                else OnLogStatus("Valor INCORRETO: " + TxtValor.Text);
            }
            else
            {
                MessageBox.Show("Por favor, digite um Valor.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtValor.Focus();
            }
        }

        private void BtnDebito_Click(object sender, EventArgs e)
        {
            decimal decValor = 0;
            bool blnSucesso = true;

            if (!string.IsNullOrEmpty(TxtValor.Text))
            {
                blnSucesso = decimal.TryParse(TxtValor.Text, out decValor);

                if (blnSucesso)
                {
                    TxtSaldo.Text = CreditoDebito(decValor, 'D');
                }
                else OnLogStatus("Valor INCORRETO: " + TxtValor.Text);
            }
            else
            {
                MessageBox.Show("Por favor, digite um Valor.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtValor.Focus();
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }

        private void TxtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }

        private void OnLogStatus(string texto)
        {
            LogStatus?.Invoke(texto);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtMensagens.Clear();
            TxtLinhas.Text = TxtMensagens.Lines.Length.ToString();
            TxtTamanho.Text = TxtMensagens.Text.Length.ToString();
        }

        private void rbtSobe_CheckedChanged(object sender, EventArgs e)
        {
            BtnLimpar_Click(sender, e);
        }

        private void rbtDesce_CheckedChanged(object sender, EventArgs e)
        {
            BtnLimpar_Click(sender, e);
        }
    }
}
