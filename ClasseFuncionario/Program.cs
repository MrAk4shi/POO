using ClasseFuncionario;//usando a namespace
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.codigo = 1;
        f1.nome = "Ana";
        f1.salario = 1000;
        f1.MostrarAtributos();
        f1.CalcularAumento();
        f1.MostrarAtributos();
        
        Funcionario f2 = new Funcionario();
        f2.codigo = 2;
        f2.nome = "Bia";
        f2.salario = 200;
        f2.MostrarAtributos();
        f2.CalcularAumento();
        f2.MostrarAtributos();
    }
}