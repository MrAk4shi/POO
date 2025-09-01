using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p1 = new Produto();
        Console.Write("Digite o código: ");
        p1.codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome: ");
        p1.nome = Console.ReadLine();
        Console.Write("Digite o preço: ");
        p1.preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o estoque: ");
        p1.estoque = Convert.ToInt32(Console.ReadLine());

        p1.MostrarAtributos();
        Console.Write("Informe a porcentagem de aumento: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        //envio de mensagem - percent é o argumento
        p1.CalcularAumento(percent);//chamada da função
        p1.MostrarAtributos();
        p1.RetirarEstoque(5);
        p1.MostrarAtributos();
        p1.CalcularSubtotal();
        p1.MostrarAtributos();
    }
}