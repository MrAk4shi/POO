using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private static long proximoNumeroConta = 1000;
        private string titular;
        private double saldo;
        private double limiteChequeEspecial;

        public long NumeroConta { get; }
        public string Titular { get { return titular; } }
        public double Saldo { get { return saldo; } }
        public double LimiteChequeEspecial { get { return limiteChequeEspecial; } }

        public ContaCorrente(string titular, double saldoInicial, double limiteChequeEspecial)
        {
            NumeroConta = proximoNumeroConta++;
            this.titular = titular;
            this.saldo = saldoInicial;
            this.limiteChequeEspecial = limiteChequeEspecial;
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
                if (saldo + limiteChequeEspecial >= valor)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque de R$ {valor:F2} realizado. Saldo atual: R$ {saldo:F2}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente, incluindo o limite do cheque especial.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"--- Extrato da Conta Corrente (Conta {NumeroConta}) ---");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: R$ {saldo:F2}");
            Console.WriteLine($"Cheque Especial: R$ {limiteChequeEspecial:F2}");
            Console.WriteLine("-----------------------------------");
        }

        ~ContaCorrente()
        {
            Console.WriteLine($"Conta Corrente do titular {titular} (número {NumeroConta}) foi encerrada.");
        }
    }
}