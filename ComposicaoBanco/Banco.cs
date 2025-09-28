using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{ 
    public class Banco
    {
        private List<ContaCorrente> contasCorrente;
        private List<Poupanca> poupancas;

        public Banco()
        {
            contasCorrente = new List<ContaCorrente>();
            poupancas = new List<Poupanca>();
        }

        public ContaCorrente AbrirContaCorrente(string titular, double saldoInicial, double limiteChequeEspecial)
        {
            var novaConta = new ContaCorrente(titular, saldoInicial, limiteChequeEspecial);
            contasCorrente.Add(novaConta);
            Console.WriteLine($"Conta Corrente aberta para {titular}.");
            return novaConta;
        }

        public Poupanca AbrirPoupanca(string titular, double saldoInicial)
        {
            var novaPoupanca = new Poupanca(titular, saldoInicial);
            poupancas.Add(novaPoupanca);
            Console.WriteLine($"Conta Poupança aberta para {titular}.");
            return novaPoupanca;
        }

        public void GerarRendimentoEmTodasPoupancas(double taxa)
        {
            Console.WriteLine("\n--- Gerando rendimento para todas as contas poupança ---");
            foreach (var poupanca in poupancas)
            {
                poupanca.GerarRendimento(taxa);
            }
        }

        public void DecretarFalencia()
        {
            Console.WriteLine("\n--- O Banco Faliu! Decretando Falência... ---");
            contasCorrente.Clear();
            poupancas.Clear();

            contasCorrente = null;
            poupancas = null;

            Console.WriteLine("Todas as contas foram encerradas. Referências removidas.");
            GC.Collect();
        }


        
    }
}