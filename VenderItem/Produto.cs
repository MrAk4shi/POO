using System;

namespace VenderItem
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public override string ToString()
        {
            return $"[{Codigo}] {Nome} - R$ {Preco:F2} - Estoque: {Estoque}";
        }
    }
}