using InterfaceTributavel;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente cc = new ContaCorrente(1000); //5% de 1000 = 50
        SeguroVida sv = new SeguroVida();           //75

        TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

        totalizador.Adiciona(cc);
        totalizador.Adiciona(sv);

        Console.WriteLine("Imposto Conta Corrente: " + cc.CalculaTributos());
        Console.WriteLine("Imposto Seguro de Vida: " + sv.CalculaTributos());
        Console.WriteLine("Total de Tributos: " + totalizador.Total);
        Console.WriteLine("\nFim da execução.");
    }
}
