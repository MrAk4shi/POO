using AgregacaoVetorConta;

// intancia separada
Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 10000;
c1.VetTitulares = new List<Cliente>(); //intanciar para entrar na classe Cliente
for (int i = 0; i < 3; i++) //precisa de um laço de repetição por ser vetor
{
    //objeto clinete só passa a existe quando é instaciado
    Cliente objetoCliente = new Cliente();
    Console.Write("Digite o nome: ");
    objetoCliente.Nome = Console.ReadLine();
    Console.Write("Digite o RG: ");
    objetoCliente.Rg = Convert.ToInt32(Console.ReadLine());
    c1.VetTitulares.Add(objetoCliente);
}
Console.WriteLine("\n\nApresentação dos sócios\n");

foreach (var cliente in c1.VetTitulares) //var é um tipo implícito, representa o tipo /classe cliente (quano recebe atributo de classe que não conhecemos o tipo)
    cliente.MostrarAtributos();