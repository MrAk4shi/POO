using ListFuncionario;

//Funcionario[] vetF = new Funcionario[3];
List<Funcionario> vetF = new List<Funcionario>();
double total = 0;

for (int i = 0; i < 3; i++)
{
    Funcionario f = new Funcionario();
    Console.Write("Digite o código: ");
    f.codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    f.nome = Console.ReadLine();
    Console.Write("Digite o salário: ");
    f.salario = Convert.ToDouble(Console.ReadLine());
    total = total + f.salario;
    vetF.Add(f);
}
Console.WriteLine($"\nO salário total é {total:c} dos funcionários\n");

foreach (Funcionario funci in vetF)
    funci.MostrarAtributos();
