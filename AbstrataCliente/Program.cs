using AbstrataCliente;
// instância correta, mas quando usamos a palavra
// abstract NÃO EXECUTARÁ 
//Cliente c = new Cliente(); 

ClienteFisico cf = new ClienteFisico(1, "Ana", 18, 100);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(2,"Empresa", 46, 222);
cj.Mostrar();

Teste t = new Teste();
t.AvaliarIdadeCliente(cf);

t.AvaliarIdadeCliente(cj);