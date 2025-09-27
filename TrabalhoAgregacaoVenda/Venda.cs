using System;
using System.Collections.Generic;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        public Comprador? Cliente { get; set; }
        public Vendedor? Funcionario { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void RealizarVenda()
        {
            double total = 0;
            foreach (var p in Produtos)
            {
                total += p.Preco;
                Cliente?.SubtrairVerba(p.Preco);
                Funcionario?.CalcularComissao(p);
            }
            Console.WriteLine($"Venda realizada! Total: {total:c}");
        }
    }
}
