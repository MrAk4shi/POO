using System;
using System.Collections.Generic;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected Endereco endereco;
        protected double salario;

        // LISTA DE DEPENDENTES adicionada
        public List<Dependente> VetDep { get; set; } = new List<Dependente>();

        public Funcionario(int codigo, string? nome, Endereco endereco, double salario)
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
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário: {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);



        // MÉTODOS DE DEPENDENTES 

        public int CalcularTotalDependente()
        {
            return VetDep.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            VetDep.Add(novoDep);
        }

        // Remove dependente pelo código 
        public void RemoverDependente(int codigoDep)
        {
            VetDep.RemoveAll(d => d.Codigo == codigoDep);
        }

        public void ListarDependentes()
        {
            if (VetDep.Count == 0)
            {
                Console.WriteLine($"{Nome} não possui dependentes.");
                return;
            }

            Console.WriteLine($"\nDependentes de {Nome}:");
            foreach (var dep in VetDep)
                dep.Mostrar();
        }

        public void MostrarQtdeDependentesFuncionario()
        {
            Console.WriteLine($"{Nome} possui {CalcularTotalDependente()} dependente(s).");
        }
    }
}
