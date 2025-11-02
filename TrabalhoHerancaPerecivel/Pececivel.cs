using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaPerecivel
{
    public class Perecivel : Produto
    {
        private string? dataFabricacao;
        private string? dataValidade;
        private int lote;

        public string? DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }
        public string? DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        } 
        public void Mostrar()
        { 
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tPreço: {preco} \tData de Fabricação: {dataFabricacao} \tData de Validade: {dataValidade} \tLote: {lote}"); //posso ver o atributo codigo que está na classe Cliente (pai)
        }
    }
}