using System;
namespace VenderItem
{   
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; private set; }
        public int ResultadoTransacao { get; private set; } // 0 = falha, 1 = OK

        public Cartao(double valor, string dadosTransacao)
        {
            Valor = valor;
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = 0;
        }

        public override bool ProcessaPagamento()
        {
            //se dadosTransacao não vazio => aprovado
            if (!string.IsNullOrWhiteSpace(DadosTransacao))
            {
                ResultadoTransacao = 1;
                return true;
            }
            ResultadoTransacao = 0;
            return false;
        }

        public override string ToString()
        {
            return $"Pagamento por Cartão - Transação: {DadosTransacao} - Resultado: {(ResultadoTransacao == 1 ? "Aprovada" : "Negada")}";
        }
    }
}