using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaPerecivel
{
    public class Produto
    {
        protected int codigo;
        protected string? nome;
        protected decimal preco;
        
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        
    }
}