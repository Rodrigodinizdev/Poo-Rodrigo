using Conta_bacaria.Models;

List<ContaBancaria> contasBanco = new List<ContaBancaria>();

int opcaoPrincipal = -1;

while (opcaoPrincipal != 0)
{
    Console.WriteLine("\n=== BANCO ===");
    Console.WriteLine("1 - Cadastrar nova conta");
    Console.WriteLine("2 - Acessar conta");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    if (!int.TryParse(Console.ReadLine(), out opcaoPrincipal))
    {
        Console.WriteLine("Opção inválida.");
        continue;
    }
    
    if (opcaoPrincipal == 1)
    {
        Console.WriteLine("\n=== Cadastro da Conta ===");

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser nulo");
            nome = Console.ReadLine();
        }

        Console.WriteLine("Digite seu CPF: ");
        string cpf = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
        {
            Console.WriteLine("CPF não pode ser nulo e deve ter 11 dígitos");
            cpf = Console.ReadLine();
        }

        Console.WriteLine("Digite seu Telefone: ");
        string telefone = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(telefone) || telefone.Length != 11)
        {
            Console.WriteLine("Telefone não pode ser vazio e deve ter 11 dígitos");
            telefone = Console.ReadLine();
        }

        Console.WriteLine("Digite o número da conta: ");
        string numeroConta = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(numeroConta) ||
               contasBanco.Any(c => c.NumeroConta == numeroConta))
        {
            Console.WriteLine("Número da conta inválido ou já existente");
            numeroConta = Console.ReadLine();
        }

        Usuario usuario = new Usuario(nome, telefone, cpf);
        ContaBancaria conta = new ContaBancaria(numeroConta, usuario, DateTime.Now);

        contasBanco.Add(conta);

        Console.WriteLine("Conta cadastrada com sucesso!");
    }

    else if (opcaoPrincipal == 2)
    {
        Console.WriteLine("Digite o número da conta: ");
        string numeroBusca = Console.ReadLine();

        ContaBancaria contaEncontrada =
            contasBanco.FirstOrDefault(c => c.NumeroConta == numeroBusca);

        if (contaEncontrada == null)
        {
            Console.WriteLine("Conta não encontrada.");
            continue;
        }

        int opcaoConta = -1;

        while (opcaoConta != 0)
        {
            Console.WriteLine("\n=== CAIXA ELETRÔNICO ===");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Exibir saldo");
            Console.WriteLine("0 - Voltar");
            Console.Write("Escolha: ");

            if (!int.TryParse(Console.ReadLine(), out opcaoConta))
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            if (opcaoConta == 1)
            {
                Console.Write("Valor do depósito: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
                {
                    contaEncontrada.Depositar(deposito);
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
            }
            else if (opcaoConta == 2)
            {
                Console.Write("Valor do saque: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal saque))
                {
                    contaEncontrada.Sacar(saque);
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
            }
            else if (opcaoConta == 3)
            {
                Console.WriteLine(contaEncontrada.ExibirSaldo());
            }
            else if (opcaoConta == 0)
            {
                Console.WriteLine("Voltando ao menu principal...");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }

    else if (opcaoPrincipal == 0)
    {
        Console.WriteLine("Encerrando sistema...");
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}





// System.Console.WriteLine("=== Cadastro da Conta ===");

// System.Console.WriteLine("Digite seu nome: ");
// string nome = Console.ReadLine();
// while (string.IsNullOrWhiteSpace(nome))
// {
//     System.Console.WriteLine("nome não pode ser nulo");
//     nome = Console.ReadLine();
// }

// System.Console.WriteLine("Digite seu CPF: ");
// string cpf = Console.ReadLine();
// while (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
// {
//     System.Console.WriteLine("Cpf não pode ser nulo e deve ter 11 digitos");
//     cpf = Console.ReadLine();
// }

// System.Console.WriteLine("Digite seu Telefone: ");
// string telefone = Console.ReadLine();
// while (string.IsNullOrWhiteSpace(telefone) || telefone.Length != 11)
// {
//     System.Console.WriteLine("telefone não pode ser vazio e deve ter 11 digitos");
//     telefone = Console.ReadLine();
// }

// Usuario usuario = new Usuario(nome, telefone, cpf);

// System.Console.WriteLine("Digite o número da conta: ");
// string numeroConta = Console.ReadLine();
// while (string.IsNullOrWhiteSpace(numeroConta))
// {
//     System.Console.WriteLine("Número da conta não pode ser vazio");
//     numeroConta = Console.ReadLine();
// }

// ContaBancaria conta = new ContaBancaria(numeroConta, usuario, DateTime.Now);

// int opcao = -1;

// while (opcao != 0)
// {
//     Console.WriteLine("\n=== CAIXA ELETRÔNICO ===");
//     Console.WriteLine("1 - Depositar");
//     Console.WriteLine("2 - Sacar");
//     Console.WriteLine("3 - Exibir saldo");
//     Console.WriteLine("0 - Sair");
//     Console.Write("Escolha: ");

//     if (!int.TryParse(Console.ReadLine(), out opcao))
//     {
//         Console.WriteLine("Opção inválida.");
//         continue;
//     }

//     if (opcao == 1)
//     {
//         Console.Write("Valor do depósito: ");
//         if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
//         {
//             conta.Depositar(deposito);
//         }
//         else
//         {
//             Console.WriteLine("Valor inválido.");
//         }
//     }
//     else if (opcao == 2)
//     {
//         Console.Write("Valor do saque: ");
//         if (decimal.TryParse(Console.ReadLine(), out decimal saque))
//         {
//             conta.Sacar(saque);
//         }
//         else
//         {
//             Console.WriteLine("Valor inválido.");
//         }
//     }
//     else if (opcao == 3)
//     {
//         Console.WriteLine(conta.ExibirSaldo());
//     }
//     else if (opcao == 0)
//     {
//         Console.WriteLine("Encerrando...");
//     }
//     else
//     {
//         Console.WriteLine("Opção inválida.");
//     }





// Usuario usuario1 = new Usuario("Rodrigo", "83996267777", "70555045332");

// Usuario usuario2 = new Usuario("Arthur", "83999999999", "00000000000");

// ContaBancaria conta1 = new ContaBancaria("0001", usuario1, DateTime.Now);
// ContaBancaria conta2 = new ContaBancaria("0002", usuario2, DateTime.Now);

// contasBanco.Add(conta1);
// contasBanco.Add(conta2);

// conta1.Depositar(100);
// conta1.Sacar(35);
// conta2.Depositar(500);
// conta2.Sacar(20);

// foreach (var conta in contasBanco)
//     System.Console.WriteLine($"{conta.ExibirSaldo()}");