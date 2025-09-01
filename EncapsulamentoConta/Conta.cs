using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta //namespace é uma pasta
{
    public class Conta //tipo de dados meu de programador
    {
        //declaração dos atributos
        private int numero;
        private string? titular;
        private double saldo;

        //declaração dos métodos
        public int Numero
        { //com N maiúsculo é a propriedade
            //propriedade é a representação dos métodos de encapsulamento get e set
            set{ //com N minúsculo é o atributo
                this.numero = value;
            }
            get{ //com N minúsculo é o atributo
                return numero;
            }
        }

        public string? Titular{
            get{
                return titular;
            }
            set{
                this.titular = value;
            }
        }

        /*
        public double Saldo{
            get{
                return saldo;
            }
            set{
                this.saldo = value;
            }
        }
        */


        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero +
            "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
    }
}