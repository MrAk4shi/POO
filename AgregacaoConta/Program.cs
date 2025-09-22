using AgregacaoConta;

Cliente cli = new Cliente();
cli.Nome = "Danilo";
cli.Rg = 100;

// 1ª forma de relação entre as classes
Conta c1 = new Conta(); //instanciamento
c1.Numero = 1;
c1.Saldo = 1000;
// a relação de agregação foi efetivada na atribuição no armazenamento
// no atributo Titular que agora passa a ser um objeto Cliente do objeto cliente (cliente) 
c1.Titular = cli  

// 2ª forma de relação entre as classes
Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = "2000";
c2.Titular = new Cliente();
c2.Titular.Nome = "Leo";
c2.Titular.Rg = 200;