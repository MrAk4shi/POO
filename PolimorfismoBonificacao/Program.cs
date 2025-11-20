using PolimorfismoBonificacao;

class Program
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario(1, "João", 2000);
        Secretario s1 = new Secretario(2, "Maria", 1800);
        Gerente g1 = new Gerente(3, "Carlos", 4000);
        Diretor d1 = new Diretor(4, "Ana", 8000);

        GerenciadorBonificacao gb = new GerenciadorBonificacao();
        
        gb.TotalizadorBonificacao(f1);
        gb.TotalizadorBonificacao(s1);
        gb.TotalizadorBonificacao(g1);
        gb.TotalizadorBonificacao(d1);

        Console.WriteLine("\nTotal acumulado de bonificações: " + gb.TotalBonificacao);

        Console.WriteLine("\nFim da execução.");
    }
}
