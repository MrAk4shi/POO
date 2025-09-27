using System;

namespace TrabalhoEncapsulamentoEstudante
{
    public class Estudante
    {
        private string? nome;
        private double nota;

        public string? Nome
        {
            get
            {
                return nome != null ? nome.ToUpper() : null; // retorna sempre em maiúsculo
            }
            set
            {
                nome = value;
            }
        }

        public double Nota
        {
            get
            {
                return nota;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota = value;
                }
                else
                {
                    Console.WriteLine("A nota deve estar entre 0 e 10. Valor ignorado!");
                }
            }
        }

        // métodos
        public void ExibirDetalhes()
        {
            Console.WriteLine("Nome: " + Nome + "\tNota: " + nota);
        }

        public bool EstaAprovado()
        {
            return nota >= 6;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + Nome + "\tNota: " + nota);
            Console.WriteLine("Status: " + (EstaAprovado() ? "Aprovado" : "Reprovado"));
        }
    }
}
