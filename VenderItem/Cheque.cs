using System;
namespace VenderItem
{   
    public class Cheque : Pagamento
    {
        public long Numero { get; private set; }
        public DateTime DataDeposito { get; private set; }
        public int Situacao { get; private set; } // 0 = pendente, 1 = compensado, 2 = devolvido

        public Cheque(double valor, long numero, DateTime dataDeposito)
        {
            Valor = valor;
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = 0;
        }

        public override bool ProcessaPagamento()
        {
            // assume que o cheque fica pendente
            Situacao = 0;
            return true;
        }

        public override string ToString()
        {
            return $"Pagamento por Cheque - Nº {Numero} - Data Depósito: {DataDeposito:d} - Situação: {Situacao}";
        }
    }
}