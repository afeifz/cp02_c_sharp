using CP02.Model;
using CP02.Utils;

string resposta;

do
{
    Console.Clear();
    Menu.ExibirMenu();

    if (byte.TryParse(Console.ReadLine(), out byte opcao))
    {
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o valor do pagamento:");
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out decimal valorCartao))
                {
                    Console.WriteLine("Valor inválido.");
                    break;
                }

                Console.WriteLine("Informe o número do cartão:");
                string numeroCartao = Console.ReadLine();

                try
                {
                    PagamentoCartao pagamento = new PagamentoCartao(valorCartao, numeroCartao);
                    Console.WriteLine(pagamento.ProcessarPagamento());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                break;

            case 2:
                Console.WriteLine("Digite o valor do pagamento:");
                input = Console.ReadLine();

                if (!decimal.TryParse(input, out decimal valorBoleto))
                {
                    Console.WriteLine("Valor inválido.");
                    break;
                }

                Console.WriteLine("Informe o código de barras:");
                string codigo = Console.ReadLine();

                try
                {
                    PagamentoBoleto pagamento = new PagamentoBoleto(valorBoleto, codigo);
                    Console.WriteLine(pagamento.ProcessarPagamento());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                break;

            case 3:
                Console.WriteLine("Saindo...");
                return;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida.");
    }

    Console.WriteLine("\nDeseja realizar outra operação (S/N)?");
    resposta = Console.ReadLine().Trim().ToUpper();

} while (resposta == "S");