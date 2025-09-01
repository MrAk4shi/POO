using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//pasta
namespace TrabalhoVetorProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double preco;
        public int estoque;
        public double subtotal; // não pode digitar

        //declaração dos métodos/funções
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome +
            "\tPreço R$ " + preco + "\tEstoque: " + estoque +
            "\tSubtotal R$ " + subtotal);
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + preco * porcentagem / 100;
            //preco += preco * porcentagem / 100;
        }
        public void RetirarEstoque(int qtde)
        {
            estoque -= qtde;
            //estoque = estoque - qtde;
        }
        public void CalcularSubtotal()
        {
            subtotal = preco * estoque;
        }
    }
}