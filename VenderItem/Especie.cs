using System;
namespace VenderItem
{
    public class Especie : Pagamento
    {
        public double Quantia { get; private set; }
        public double Troco => Quantia - Valor;

        public Especie(double valor, double quantia)
        {
            Valor = valor;
            Quantia = quantia;
        }

        public override bool ProcessaPagamento()
        {
            if (Quantia < Valor) return false;
            return true;
        }

        public override string ToString()
        {
            return $"Pagamento em Espécie - Pagamento: R$ {Quantia:F2} - Troco: R$ {Troco:F2}";
        }
    }
}