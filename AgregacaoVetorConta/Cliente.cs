using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVetorConta
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public int Rg { get; set; }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {Nome} \tRg: {Rg}");
        }
    }
}