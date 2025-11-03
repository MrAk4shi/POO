using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }
        public Comissionado(int codigo, string nome, Endereco endereco, double salario, double porcentagem) : base(codigo, nome, endereco, salario)
        {
            Porcentagem = porcentagem;
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis * Porcentagem /100 + Salario;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Porcentagem {Porcentagem:n} %");
        }
    }
}
    