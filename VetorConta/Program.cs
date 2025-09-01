using VetorConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração do vetor
        Conta[] vetContas = new Conta[3];
        //o laço de repetição realizará o cadastro das contas
        for (int i = 0; i < vetContas.Length; i++)
        {
            //instanciação de CADA índice
            vetContas[i] = new Conta();
            Console.Write("Digite o número: ");
            vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o titular: ");
            vetContas[i].titular = Console.ReadLine();
            Console.Write("Digite o saldo: ");
            vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        //aprensentação das contas com for
        for (int i = 0; i < vetContas.Length; i++)
            vetContas[i].MostrarAtributos();
        // aprensentação das contas com foreach
        // o foreach APENAS pode ser usado para
        // vetor que tenha conteúdo
        foreach (Conta c in vetContas)
            c.MostrarAtributos();
    }
}