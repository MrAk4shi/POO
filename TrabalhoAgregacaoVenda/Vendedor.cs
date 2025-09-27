using System;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        public string? Nome { get; set; }
        public double Comissao { get; private set; }

        // método para calcular comissão de 2% do valor do produto
        public void CalcularComissao(Produto p)
        {
            Comissao += p.Preco * 0.02;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Vendedor: {Nome}\tComissão acumulada: {Comissao:c}");
        }
    }
}
