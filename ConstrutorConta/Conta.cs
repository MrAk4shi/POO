using System;


namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; } //escrever "prop" e dar um tab pra ter essa linha
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta() //construtor
        {
        }

        public Conta(int numero)
        {
            Numero = numero; //inicializa o objeto com o valor de um numero de conta
        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }



        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero +
            "\tTitular: " + Titular + "\tSaldo: " + Saldo);
        }

    }
}