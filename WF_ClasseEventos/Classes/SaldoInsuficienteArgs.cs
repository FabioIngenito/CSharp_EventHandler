using System;

/// <summary>
/// Esta classe fornece o campo ValorDebito que representa o valor 
/// do débito que será sacado da conta. O campo Boolean Libera permite 
/// que o programa principal diga ao objeto se ele deve permitir o 
/// débito, mesmo que isso faça com que a conta fique com um saldo 
/// negativo.
/// </summary>
namespace WF_ClasseEventos.Classes
{
    public class SaldoInsuficienteArgs : EventArgs
    {
        // O valor a ser debitado
        public decimal ValorDebito;

        //Define se libera ou não o debito do valor
        // O valor padrão é false para não permitir saldo negativo
        public bool Libera = false;
    }
}
