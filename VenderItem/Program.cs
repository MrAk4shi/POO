using System;
using System.Collections.Generic;
using System.Globalization;

namespace VenderItem
{   
    class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
            bool sair = false;
            SeedProdutos();

            while (!sair)
            {
                Console.WriteLine("=== Sistema de Vendas (caixa) ===");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Iniciar venda");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                var opt = Console.ReadLine();
                Console.WriteLine();

                switch (opt)
                {
                    case "1":
                        CadastrarProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        IniciarVenda();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void SeedProdutos()
        {
            produtos.Add(new Produto(1001, "Caneta", 2.50, 200));
            produtos.Add(new Produto(1002, "Caderno", 12.00, 100));
            produtos.Add(new Produto(1003, "Lápis", 1.20, 500));
        }

        static void CadastrarProduto()
        {
            Console.Write("Código (numérico): ");
            long codigo = long.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(codigo, nome, preco, estoque));
            Console.WriteLine("Produto cadastrado.");
        }

        static void ListarProdutos()
        {
            Console.WriteLine("Produtos disponíveis:");
            foreach (var p in produtos)
                Console.WriteLine(p.ToString());
        }

        static Produto BuscarProdutoPorCodigo(long codigo)
        {
            return produtos.Find(p => p.Codigo == codigo);
        }

        static void IniciarVenda()
        {
            var venda = new Venda();
            bool adicionando = true;

            while (adicionando)
            {
                ListarProdutos();
                Console.Write("Informe o código do produto (ou 0 para encerrar itens): ");
                long cod = long.Parse(Console.ReadLine());
                if (cod == 0) break;

                var prod = BuscarProdutoPorCodigo(cod);
                if (prod == null)
                {
                    Console.WriteLine("Produto não encontrado.");
                    continue;
                }

                Console.Write($"Quantidade (estoque {prod.Estoque}): ");
                int qtd = int.Parse(Console.ReadLine());
                if (qtd <= 0)
                {
                    Console.WriteLine("Quantidade inválida.");
                    continue;
                }
                if (qtd > prod.Estoque)
                {
                    Console.WriteLine("Estoque insuficiente.");
                    continue;
                }

                var item = new ItemVenda(prod, qtd);
                venda.AdicionaItem(item);
                Console.WriteLine("Item adicionado.");

                Console.Write("Deseja adicionar mais itens? (s/n): ");
                string resp = Console.ReadLine().ToLower();
                if (resp != "s") adicionando = false;
            }

            if (venda.Itens.Count == 0)
            {
                Console.WriteLine("Venda cancelada (nenhum item).");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Resumo da venda:");
            Console.WriteLine(venda.ToString());

            Console.WriteLine("Formas de pagamento:");
            Console.WriteLine("1 - Espécie");
            Console.WriteLine("2 - Cheque");
            Console.WriteLine("3 - Cartão");
            Console.Write("Escolha: ");
            var escolha = Console.ReadLine();

            Pagamento pagamento = null;
            double total = venda.TotalLiquido();

            switch (escolha)
            {
                case "1":
                    Console.Write($"Valor recebido (R$): ");
                    double quantia = double.Parse(Console.ReadLine());
                    pagamento = new Especie(total, quantia);
                    break;
                case "2":
                    Console.Write("Número do cheque: ");
                    long numero = long.Parse(Console.ReadLine());
                    Console.Write("Data depósito (yyyy-mm-dd): ");
                    DateTime dataDep = DateTime.Parse(Console.ReadLine());
                    pagamento = new Cheque(total, numero, dataDep);
                    break;
                case "3":
                    Console.Write("Dados transação (simulação): ");
                    string dados = Console.ReadLine();
                    pagamento = new Cartao(total, dados);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Venda cancelada.");
                    return;
            }

            bool ok = pagamento.ProcessaPagamento();
            if (!ok)
            {
                Console.WriteLine("Pagamento não autorizado. Venda cancelada.");
                return;
            }

            // finalizar venda: reduzir estoque
            venda.Finalizar();

            Console.WriteLine("Pagamento processado com sucesso:");
            Console.WriteLine(pagamento.ToString());
            Console.WriteLine("Venda concluída:");
            Console.WriteLine(venda.ToString());
        }
    }
}