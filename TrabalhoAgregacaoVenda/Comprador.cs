using System;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        public string? Nome { get; set; }
        public double Verba { get; set; }

        public void SubtrairVerba(double valor)
        {
            if (valor <= Verba)
                Verba -= valor;
            else
                Console.WriteLine("Verba insuficiente para esta compra!");
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Comprador: {Nome}\tVerba: {Verba:c}");
        }
    }
}
