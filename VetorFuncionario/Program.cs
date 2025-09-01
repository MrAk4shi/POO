using VetorFuncionario;

//declaração do vetor
Funcionario[] vetF = new Funcionario[3];
double total = 0;

for (int i = 0; i < vetF.Length; i++)
        {
            //instanciação de CADA índice
            vetF[i] = new Funcionario();
            Console.Write("Digite o código: ");
            vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome: ");
            vetF[i].nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            vetF[i].salario = Convert.ToDouble(Console.ReadLine());
            total = total + vetF[i].salario;
        }
Console.WriteLine($"\nO salário total é {total:c} dos funcionários\n");
        
foreach (Funcionario c in vetF)
    c.MostrarAtributos();