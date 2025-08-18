using ClasseFuncionario;

//funcionario 1
Funcionario f1 = new Funcionario();
Console.Write("Digite o código: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.nome = Console.ReadLine();
Console.Write("Digite o salario: ");
f1.salario = Convert.ToDouble(Console.ReadLine()); 
f1.MostrarAtributos();
f1.CalcAumento();
f1.MostrarAtributos();

//funcionario 2
Funcionario f2 = new Funcionario();
Console.Write("Digite o código: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f2.nome = Console.ReadLine();
Console.Write("Digite o salario: ");
f2.salario = Convert.ToDouble(Console.ReadLine()); 
f2.MostrarAtributos();
f2.CalcAumento();
f2.MostrarAtributos();