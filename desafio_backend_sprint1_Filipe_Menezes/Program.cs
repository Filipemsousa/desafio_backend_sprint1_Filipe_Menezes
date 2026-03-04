class Program
{
    static void Main()
    {
        string mensagemDeBoasVindas = "Boas vindas ao Menezes Bank";

        void ExibirLogo()
        {
            Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗███████╗███████╗███████╗░██████╗  ██████╗░░█████╗░███╗░░██╗██╗░░██╗
████╗░████║██╔════╝████╗░██║██╔════╝╚════██║██╔════╝██╔════╝  ██╔══██╗██╔══██╗████╗░██║██║░██╔╝
██╔████╔██║█████╗░░██╔██╗██║█████╗░░░░███╔═╝█████╗░░╚█████╗░  ██████╦╝███████║██╔██╗██║█████═╝░
██║╚██╔╝██║██╔══╝░░██║╚████║██╔══╝░░██╔══╝░░██╔══╝░░░╚═══██╗  ██╔══██╗██╔══██║██║╚████║██╔═██╗░
██║░╚═╝░██║███████╗██║░╚███║███████╗███████╗███████╗██████╔╝  ██████╦╝██║░░██║██║░╚███║██║░╚██╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝╚══════╝╚══════╝╚══════╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
            Console.WriteLine(mensagemDeBoasVindas);
        }


        List<ContaBancaria> contas = new List<ContaBancaria>();

        contas .Add(new ContaCorrente("12345", "Filipe", 1000.00m));
        contas .Add(new ContaPoupanca("54321", "Maria ", 5000.00m));
        contas .Add(new ContaEmpresarial("6789", "FORD", 10000.00m));


        int loginNumeroConta = 0;
        int opcao = 0;

        void ExibirMenu()
        {
            ExibirLogo();

            Console.WriteLine("\nMenu de opções:");
            Console.WriteLine("1 - Acessar conta corrente");
            Console.WriteLine("2 - Acessar conta poupança");
            Console.WriteLine("3 - Acessar conta empresarial");
            Console.WriteLine("4 - Sacar dinheiro");
            Console.WriteLine("5 - Depositar dinheiro");
            Console.WriteLine("6 - Consultar saldo");
            Console.WriteLine("7 - Sair");

            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você escolheu a opção {opcao}");
        }

        while (opcao != 7)
        {

            ExibirMenu();

            switch (opcao)
            {
                case 1:
       
                    Console.WriteLine("Acessando conta corrente...");
                   
                

                    Console.WriteLine("Digite o numero da conta");
                    int NumeroContaC = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do titular da conta");
                    string TitularC = Console.ReadLine();


                    foreach (var conta in contas)
                    {
                        if (conta is ContaCorrente)
                        {
                            if(conta.NumeroConta == NumeroContaC.ToString() && conta.Titular == TitularC)
                            {
                                loginNumeroConta = NumeroContaC;

                                Console.WriteLine("Conta encontrada:");
                                ((ContaCorrente)conta).Detalhe_Corrente();
                            }
                        }
                    }

                    break;

                case 2:
                    Console.WriteLine("Acessando conta poupança...");




                    Console.WriteLine("Digite o numero da conta");
                    int NumeroContaP = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do titular da conta");
                    string TitularP = Console.ReadLine();

                    Console.WriteLine("Digite o saldo inicial da conta");
                    decimal SaldoInicialP = decimal.Parse(Console.ReadLine());




                    break;

                case 3:
                    Console.WriteLine("Acessando conta empresarial...");




                    Console.WriteLine("Digite o numero da conta");
                    int NumeroContaÈ = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do titular da conta");
                    string TitularE = Console.ReadLine();

                    Console.WriteLine("Digite o saldo inicial da conta");
                    decimal SaldoInicialE = decimal.Parse(Console.ReadLine());




                    break;

                case 4:
                    Console.WriteLine("Saque de dinheiro...");
                    if (loginNumeroConta != 0)
                    {
                        Console.WriteLine("Digite o valor do saque:");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());
                        foreach (var conta in contas)
                        {
                            if (conta.NumeroConta == loginNumeroConta.ToString())
                            {
                                conta.Sacar(valorSaque);
                                Console.WriteLine($"Saque de {valorSaque:C} realizado com sucesso.");
                                Console.WriteLine($"Saldo atual: {conta.Saldo:C}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma conta corrente acessada. Por favor, acesse uma conta corrente primeiro.");
                    }

                   

                    break;

                case 5:
                    Console.WriteLine("Depósito de dinheiro...");
                    break;

                case 6:
                    Console.WriteLine("Consulta de saldo...");
                    break;


                case 7:
                    Console.WriteLine("Saindo do programa....");
                    break;

                default:

                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

     
    }

    }


}

