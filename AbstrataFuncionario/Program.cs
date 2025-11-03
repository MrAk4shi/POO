using AbstrataFuncionario;

Endereco e = new Endereco("Terezina", 75, "Vila Paulo Roberto", "PP");
e.Mostrar();

Assalariado a1 = new Assalariado(1, "Assalariado 1",e, 1000);
Assalariado a2 = new Assalariado(2, "Assalariado 2",e, 1000);

Comissionado c1 = new Comissionado(3, "Comissionado 1", e, 1000, 20);
Comissionado c2 = new Comissionado(4, "Comissionado 2", e, 1000, 30);

Departamento d1 = new Departamento(11, "TI");
d1.VetF = new List<Funcionario>();
d1.AdmitirFuncionario(a1);
d1.AdmitirFuncionario(c1);
d1.Mostrar();
d1.ListarFuncionarios();

Departamento d2 = new Departamento(12, "RH");
d2.VetF = new List<Funcionario>();
d2.AdmitirFuncionario(a2);
d2.AdmitirFuncionario(c2);
d2.Mostrar();
d2.ListarFuncionarios();