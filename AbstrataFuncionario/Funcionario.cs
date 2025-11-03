using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected Endereco endereco;
        protected double salario;
        public Funcionario(int codigo, string nome, Endereco endereco, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            _Endereco = endereco;
            Salario = salario;
        }
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
        // _Endereco é a propriedade
        public Endereco _Endereco 
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário {Salario:c}");
        }
        public abstract double CalcularSalario(int diasUteis);
    }
}