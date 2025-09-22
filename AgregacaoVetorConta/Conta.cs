using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVetorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public List<Cliente> VetTitulares { get; set; } // Aqui estabelece a relação de associação pelo atributo Titular da Classe Conta
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero} \tSaldo: {Saldo:c}");
        }
    }
}