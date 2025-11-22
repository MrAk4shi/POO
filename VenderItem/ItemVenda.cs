using System;
namespace VenderItem
{
    public class ItemVenda
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public double Subtotal => Produto.Preco * Quantidade;

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public void DiminuirEstoque()
        {
            if (Produto != null)
            {
                Produto.Estoque -= Quantidade;
                if (Produto.Estoque < 0) Produto.Estoque = 0;
            }
        }

        public override string ToString()
        {
            return $"{Produto.Nome} x{Quantidade} @ R$ {Produto.Preco:F2} = R$ {Subtotal:F2}";
        }
    }

}