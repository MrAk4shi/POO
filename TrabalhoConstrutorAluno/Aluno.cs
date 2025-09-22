using System;

public class Aluno
{
    public long Ra { get; set; }
    public string Nome { get; set; }
    public static int Contador { get; private set; }

    public Aluno()
    {
        Ra = 1570482413000 + Contador;
        Nome = "";
        Contador += 1;
    }

    public Aluno(string nome)
    {
        Ra = 15704824130000 + Contador;
        Nome = nome;
        Contador += 1;
    }

    // Método para mostrar atributos
    public void MostrarAtributos()
    {
        Console.WriteLine($"RA: {Ra} - Nome: {Nome}");
    }
}
