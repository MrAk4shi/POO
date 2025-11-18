using System;

namespace AbstrataFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Dependente(int codigo, string? nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Dependente - Código: {Codigo} Nome: {Nome} Idade: {Idade}");
        }
    }
}
