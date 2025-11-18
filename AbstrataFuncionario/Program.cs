using AbstrataFuncionario;

Endereco e = new Endereco("Terezina", 75, "Vila Paulo Roberto", "PP");
e.Mostrar();

//funcionários
Assalariado a1 = new Assalariado(1, "Assalariado 1", e, 1000);
Assalariado a2 = new Assalariado(2, "Assalariado 2", e, 1000);

Comissionado c1 = new Comissionado(3, "Comissionado 1", e, 1000, 20);
Comissionado c2 = new Comissionado(4, "Comissionado 2", e, 1000, 30);

//dependentes criados
Dependente dA1_1 = new Dependente(1, "João", 10);
Dependente dA1_2 = new Dependente(2, "Ana", 15);

Dependente dC1_1 = new Dependente(3, "Pedro", 20);
Dependente dC2_1 = new Dependente(4, "Lucas", 17);

//adicionando dependentes aos funcionários
a1.AdicionarDependente(dA1_1);
a1.AdicionarDependente(dA1_2);
c1.AdicionarDependente(dC1_1);
c2.AdicionarDependente(dC2_1);

//departamentos
Departamento d1 = new Departamento(1, "TI");
d1.VetF = new List<Funcionario>();
d1.AdmitirFuncionario(a1);
d1.AdmitirFuncionario(c1);

Departamento d2 = new Departamento(2, "RH");
d2.VetF = new List<Funcionario>();
d2.AdmitirFuncionario(a2);
d2.AdmitirFuncionario(c2);


Console.WriteLine("\n--- Funcionários do Departamento TI ---");
d1.ListarFuncionarios();

Console.WriteLine("\n--- Funcionários do Departamento RH ---");
d2.ListarFuncionarios();


Console.WriteLine("\n--- Dependentes do Assalariado 1 ---");
a1.ListarDependentes();

Console.WriteLine("\n--- Dependentes do Comissionado 1 ---");
c1.ListarDependentes();

Console.WriteLine("\nQuantidade de dependentes de A1:");
a1.MostrarQtdeDependentesFuncionario();

Console.WriteLine("\nQuantidade de dependentes de C2:");
c2.MostrarQtdeDependentesFuncionario();

Console.WriteLine("\nFim da execução.");
