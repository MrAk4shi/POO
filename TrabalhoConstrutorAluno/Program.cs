using System;

public class Program
{
    public static void Main()
    {
        Aluno a1 = new Aluno("Ana");
        Aluno a2 = new Aluno("Carlos");
        Aluno a3 = new Aluno();

        a1.MostrarAtributos();
        a2.MostrarAtributos();
        a3.MostrarAtributos();

        Console.WriteLine($"\nTotal de alunos cadastrados: {Aluno.Contador}");
    }
}
