using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListFuncionario //pasta
{
    public class Funcionario
    {
        //declaração de atributos
        public int codigo;
        public string? nome;
        public double salario;

        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome
            + "\tSalário R$ " + salario);
        }
        public void CalcularAumento()
        {   //5%
            salario += salario * 5 / 100;
        }
    }
}