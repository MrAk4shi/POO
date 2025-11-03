using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, Endereco endereco, double salario) : base(codigo, nome, endereco, salario)
        {}
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
    }
}