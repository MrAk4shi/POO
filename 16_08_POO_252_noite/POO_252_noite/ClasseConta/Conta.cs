using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta //namespace é uma pasta
{
    public class Conta //tipo de dados meu de programador
    {
        //declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração dos métodos
        public void Sacar()
        {}
        public void Depositar()
        {}
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}