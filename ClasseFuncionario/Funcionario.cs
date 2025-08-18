using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario //pasta
{
    public class Funcionario //nome do arquivo
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double salario;
        //declaração dos métodos
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código do funcionário: "+codigo);
            System.Console.WriteLine("Nome do funcionário: "+nome);
            System.Console.WriteLine("Salário do funcionário: "+salario);
            System.Console.WriteLine("-------------------------");
        }
        public void CalcAumento()
        {
            salario = salario + (salario * 0.05);
        }
    }
}