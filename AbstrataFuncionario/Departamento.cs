using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;            
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} ");
        }
        public void AdmitirFuncionario (Funcionario f)
        {
            VetF.Add(f);
        }
        public void ListarFuncionarios()
        {
            foreach (var f in VetF)      
                f.Mostrar();
        }
    }
}