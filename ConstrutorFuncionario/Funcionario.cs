using System;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //atributos com encapsulamento
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }

        //construtores
        public Funcionario()
        {
        }
        public Funcionario(int codigo)
        {
            Codigo = codigo;
        }
        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }


        //métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome
            + "\tSalário R$ " + Salario);
        }

    }
}