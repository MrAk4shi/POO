using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        private static int codigoInicial = 500;
        public int Codigo { get; private set; }
        public string? Descricao { get; set; }
        private double preco;

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                    preco = value;
                else
                {
                    Console.WriteLine("Preço inválido! Usando 1.0 por padrão.");
                    preco = 1.0;
                }
            }
        }

        // construtor
        public Produto(string descricao, double preco)
        {
            Codigo = codigoInicial++;
            Descricao = descricao;
            Preco = preco;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tDescrição: {Descricao}\tPreço: {Preco:c}");
        }
    }
}
