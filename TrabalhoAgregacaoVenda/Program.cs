// See https://aka.ms/new-console-template for more information
using TrabalhoAgregacaoVenda;

Comprador comprador = new Comprador();
comprador.Nome = "Danilo";
comprador.Verba = 2000;

Vendedor vendedor = new Vendedor();
vendedor.Nome = "Marcos";

// produtos
Produto p1 = new Produto("Notebook", 1500);
Produto p2 = new Produto("Mouse", 100);

// primeira venda
Venda v1 = new Venda();
v1.Cliente = comprador;
v1.Funcionario = vendedor;
v1.Produtos.Add(p1);
v1.Produtos.Add(p2);

comprador.MostrarAtributos();
vendedor.MostrarAtributos();
p1.MostrarAtributos();
p2.MostrarAtributos();

v1.RealizarVenda();

Console.WriteLine("\nApós a venda:");
comprador.MostrarAtributos();
vendedor.MostrarAtributos();

// segunda venda
Produto p3 = new Produto("Teclado", 200);

Venda v2 = new Venda();
v2.Cliente = comprador;
v2.Funcionario = vendedor;
v2.Produtos.Add(p3);

v2.RealizarVenda();

Console.WriteLine("\nApós a segunda venda:");
comprador.MostrarAtributos();
vendedor.MostrarAtributos();
