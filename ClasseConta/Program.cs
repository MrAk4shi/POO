using ClasseConta;//usa os arquivos que estão na mesma pasta/namesapce
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração de variável
        Conta c1;
        //instanciação de objeto
        c1 = new Conta();
        c1.numero = 1;
        c1.titular = "Ana";
        c1.saldo = 100;
        c1.MostrarAtributos();
        c1.Sacar(10);
        c1.MostrarAtributos();
        //outra instanciação
        Conta c2 = new Conta();
        Console.Write("Digite o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o titular: ");
        c2.titular = Console.ReadLine();
        Console.Write("Digite o saldo: ");
        c2.saldo = Convert.ToDouble(Console.ReadLine());
        c2.MostrarAtributos();
        c2.Depositar(120);
        c2.MostrarAtributos();

        Conta c3 = new Conta();
        c3.MostrarAtributos();
    }
}