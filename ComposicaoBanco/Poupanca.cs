using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace ComposicaoBanco
{
    public class Poupanca
    {
        private static long proximoNumeroConta = 2000;
        private string titular;
        private double saldo;

        public long NumeroConta { get; }
        public string Titular { get { return titular; } }
        public double Saldo { get { return saldo; } }

        public Poupanca(string titular, double saldoInicial)
        {
            NumeroConta = proximoNumeroConta++;
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Console.WriteLine($"Conta {NumeroConta}:");
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado. Saldo atual: R$ {saldo:F2}");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public void Sacar(double valor)
        {
            Console.WriteLine($"Conta {NumeroConta}:");
            if (valor > 0)
            {
                if (saldo >= valor)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque de R$ {valor:F2} realizado. Saldo atual: R$ {saldo:F2}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente na poupança.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
            }
        }

        public void GerarRendimento(double taxa)
        {
            Console.WriteLine($"Conta {NumeroConta}:");
            if (taxa > 0)
            {
                double rendimento = saldo * taxa;
                saldo += rendimento;
                Console.WriteLine($"Rendimento de R$ {rendimento:F2} gerado. Novo saldo: R$ {saldo:F2}");
            }
            else
            {
                Console.WriteLine("A taxa de rendimento deve ser positiva.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"--- Detalhes da Conta Poupança (Conta {NumeroConta}) ---");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: R$ {saldo:F2}");
            Console.WriteLine("-----------------------------------");
        }

        ~Poupanca()
        {
            Console.WriteLine($"Conta Poupança do titular {titular} (número {NumeroConta}) foi encerrada.");
        }
    }
}