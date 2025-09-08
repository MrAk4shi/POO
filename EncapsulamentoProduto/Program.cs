using EncapsulamentoProduto;

Produto p = new Produto();
p.Codigo = 1; //set
p.Nome = "mouse"; //set
p.Preco = 50;//set

if (p.Preco > 10)//get
    Console.WriteLine("Preço alto" + p.Preco);//get

