using ClasseConta;//usa os arquivos que estão na mesma pasta/namesapce
//declaração de variável
Conta c1;
//instanciação de objeto
c1 = new Conta();
c1.numero = 1;
c1.titular = "Ana";
c1.saldo = 100;
Console.WriteLine("Número: " + c1.numero);
Console.WriteLine("Titular: " + c1.titular);
Console.WriteLine("Saldo: " + c1.saldo);

//outra instanciação
Conta c2 = new Conta();
Console.Write("Digite o número: ");
c2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular: ");
c2.titular = Console.ReadLine();
Console.Write("Digite o saldo: ");
c2.saldo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Número: " + c2.numero);
Console.WriteLine("Titular: " + c2.titular);
Console.WriteLine("Saldo: " + c2.saldo);
