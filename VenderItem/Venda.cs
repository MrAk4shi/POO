using System;
using System.Collections.Generic;
using System.Linq;

namespace VenderItem
{
    public class Venda
    {
        public DateTime Data { get; private set; } = DateTime.Now;
        private List<ItemVenda> itens = new List<ItemVenda>();
        public IReadOnlyList<ItemVenda> Itens => itens.AsReadOnly();

        public double DescontoAplicado { get; private set; } = 0.0;

        //desconto atacado de 20% quando QUANTIDADE TOTAL de produtos na venda >= 50
        private const int ATACADO_QTD_MIN = 50;
        private const double ATACADO_DESCONTO = 0.20;

        public void AdicionaItem(ItemVenda item)
        {
            itens.Add(item);
        }

        public int QuantidadeTotal()
        {
            return itens.Sum(i => i.Quantidade);
        }

        public double TotalBruto()
        {
            return itens.Sum(i => i.Subtotal);
        }

        public double CalculaDesconto()
        {
            int qtdTotal = QuantidadeTotal();
            if (qtdTotal >= ATACADO_QTD_MIN)
            {
                return TotalBruto() * ATACADO_DESCONTO;
            }
            return 0.0;
        }

        public double TotalLiquido()
        {
            double desconto = CalculaDesconto();
            DescontoAplicado = desconto;
            return TotalBruto() - desconto;
        }

        public void Finalizar()
        {
            // diminuir estoque dos produtos
            foreach (var item in itens)
            {
                item.DiminuirEstoque();
            }
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"Venda - Data: {Data}");
            foreach (var it in itens)
                sb.AppendLine("  " + it.ToString());
            sb.AppendLine($"Total bruto: R$ {TotalBruto():F2}");
            sb.AppendLine($"Desconto: R$ {CalculaDesconto():F2}");
            sb.AppendLine($"Total a pagar: R$ {TotalLiquido():F2}");
            return sb.ToString();
        }
    }
}