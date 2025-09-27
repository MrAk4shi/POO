using TrabalhoEncapsulamentoEstudante;

Estudante e1 = new Estudante();
e1.Nome = "Danilo";
e1.Nota = 8;
e1.ExibirDetalhes();
e1.ExibirInformacoes();

Console.WriteLine();

Estudante e2 = new Estudante();
Console.WriteLine("Digite o nome do estudante: ");
e2.Nome = Console.ReadLine();
Console.WriteLine("Digite a nota: ");
e2.Nota = Convert.ToDouble(Console.ReadLine());
e2.ExibirDetalhes();
e2.ExibirInformacoes();
