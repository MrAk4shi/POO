using ComposicaoBanco;


Banco meuBanco = new Banco();

Console.WriteLine("--- Abrindo Contas ---");
var contaCorrente1 = meuBanco.AbrirContaCorrente("Danilo", 1500.00, 500.00);
var poupanca1 = meuBanco.AbrirPoupanca("Gustavo", 800.00);
var poupanca2 = meuBanco.AbrirPoupanca("Anderson", 250.00);

Console.WriteLine("\n--- Operações ---");
contaCorrente1.Sacar(2000.00);
poupanca1.Depositar(100.00);

Console.WriteLine("\n--- Exibindo Detalhes das Contas ---");
contaCorrente1.GerarExtrato();
poupanca1.ExibirDetalhes();
        
meuBanco.GerarRendimentoEmTodasPoupancas(0.01);


meuBanco.DecretarFalencia();