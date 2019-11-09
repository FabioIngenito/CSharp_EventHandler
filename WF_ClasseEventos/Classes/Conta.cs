using System;

namespace WF_ClasseEventos.Classes
{
    public class Conta
    {
        //Na classe conta definimos o evento SaldoInsuficiente usando um delegate. 
        //Este evento deve ser manipulado por um manipulador de eventos que usa dois parâmetros:
        //        sender  - representando o objeto que gerou o evento ;
        //        SaldoInsuficenteArgs - define os campos ValorDebito e Libera
        public event EventHandler<SaldoInsuficienteArgs> SaldoInsuficiente;

        // O saldo da conta
        public decimal Saldo { get; set; }
        public bool blnProcessa = false;

        // Retirar uma quantidade da conta
        public string Debito(decimal valor)
        {
            string strRetorno = "";

            if (valor < 0)
            {
                //NUNCA SERÁ CHAMADA, POIS TRATEI A ENTRADA DA "TxtValor"
                throw new ArgumentOutOfRangeException("O valor do débito deve ser um valor positivo.");
            }

            // Verifica se existe saldo
            if (Saldo >= valor)
            {
                // Há saldo
                Saldo -= valor;
                strRetorno = "Débito de " 
                           + valor.ToString("C") 
                           + " - Saldo: " 
                           + Saldo.ToString("C");
            }
            else
            {
                // Não tem dinheiro suficiente
                // Dispera o evento SaldoInsuficiente
                if (SaldoInsuficiente != null)
                {
                    // Cria um objeto do tipo SaldoInsuficienteArgs
                    SaldoInsuficienteArgs args = new SaldoInsuficienteArgs();
                    args.ValorDebito = valor;
                    // Dispara o evento somente se houver inscritos
                    SaldoInsuficiente?.Invoke(this, args);
                    // Se for liberado 
                    // debita o valor valor e a conta fica negativa
                    if (args.Libera)
                    {
                        Saldo -= valor;
                        strRetorno = "Libera o Débito de: " 
                                   + valor.ToString("C")
                                   + Environment.NewLine 
                                   +  " - Conta NEGATIVA de " 
                                   + Saldo.ToString("C");
                    }
                    else strRetorno = "Não Libera o Débito de: " 
                                    + valor.ToString("C")
                                    + Environment.NewLine
                                    + " - Conta: "
                                    + Saldo.ToString("C");
                }
            }

            return strRetorno;
        }

        // Deposita valor na conta
        public string Credito(decimal valor)
        {
            string strRetorno = "";

            if (valor < 0)
            {
                //NUNCA SERÁ CHAMADA, POIS TRATEI A ENTRADA DA "TxtValor"
                throw new ArgumentOutOfRangeException("O valor do crédito deve ser um valor positivo.");
            }

            Saldo += valor;
            strRetorno = "Crédito de "
                       + valor.ToString("C")
                       + " - Saldo: "
                       + Saldo.ToString("C");

            return strRetorno;
        }
    }
}
