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
        contas .Add(new ContaPoupanca("54321", "Maria", 5000.00m));
        contas .Add(new ContaEmpresarial("6789", "Ford", 10000.00m));


        int loginNumeroConta = 0;
        int opcao = 0;

        ExibirLogo();

        void ExibirMenu()
        {

            

            Console.WriteLine("\nMenu de opções:");
            Console.WriteLine("1 - Acessar conta corrente");
            Console.WriteLine("2 - Acessar conta poupança");
            Console.WriteLine("3 - Acessar conta empresarial");
            Console.WriteLine("4 - Sacar dinheiro");
            Console.WriteLine("5 - Depositar dinheiro");
            Console.WriteLine("6 - Consultar saldo");
            Console.WriteLine("7 - Realizar empréstimo");
            Console.WriteLine("8 - Calcular Rendimento (Exclusivo para conta poupança)");
            Console.WriteLine("9 - Sair");

            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você escolheu a opção {opcao}");
        }

        while (opcao != 9)
        {
            try
            {

            
            ExibirMenu();

                Console.Clear();

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

                            else
                            {
                                Console.WriteLine("Conta não encontrada. Por favor, verifique o número da conta e o nome do titular.");
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


                    foreach (var conta in contas)
                    {
                        if (conta is ContaPoupanca)
                        {
                            if (conta.NumeroConta == NumeroContaP.ToString() && conta.Titular == TitularP)
                            {
                                loginNumeroConta = NumeroContaP;

                                Console.WriteLine("Conta encontrada:");
                                ((ContaPoupanca)conta).Detalhe_Poupanca();
                            }

                            else
                            {
                                Console.WriteLine("Conta não encontrada. Por favor, verifique o número da conta e o nome do titular.");
                            }
                        }
                    }

                    break;

                case 3:
                    Console.WriteLine("Acessando conta empresarial...");

                    Console.WriteLine("Digite o numero da conta");
                    int NumeroContaE = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do titular da conta");
                    string TitularE = Console.ReadLine();


                    foreach (var conta in contas)
                    {
                        if (conta is ContaEmpresarial)
                        {
                            if (conta.NumeroConta == NumeroContaE.ToString() && conta.Titular == TitularE)
                            {
                                loginNumeroConta = NumeroContaE;

                                Console.WriteLine("Conta encontrada:");
                                ((ContaEmpresarial)conta).Detalhe_Empresarial();
                            }

                            else
                            {
                                Console.WriteLine("Conta não encontrada. Por favor, verifique o número da conta e o nome do titular.");
                            }
                        }
                    }

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
                               
                                Console.WriteLine($"Saldo atual: {conta.valorTotal:C}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma conta acessada. Por favor, acesse uma conta primeiro.");
                    }

                   

                    break;

                case 5:
                    Console.WriteLine("Depósito de dinheiro...");

                    if (loginNumeroConta != 0)
                    {
                        Console.WriteLine("Digite o valor do depósito:");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());
                        foreach (var conta in contas)
                        {
                            if (conta.NumeroConta == loginNumeroConta.ToString())
                            {
                                conta.Depositar(valorDeposito);
                               
                                
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma conta acessada. Por favor, acesse uma conta primeiro.");
                    }




                    break;

                case 6:
                    Console.WriteLine("Consulta de saldo...");

                    if (loginNumeroConta != 0)
                    {
                        foreach (var conta in contas)
                        {
                            if (conta.NumeroConta == loginNumeroConta.ToString())
                            {
                                Console.WriteLine($"Saldo atual: {conta.valorTotal:C}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma conta acessada. Por favor, acesse uma conta primeiro.");
                    }
                    break;


                case 7:
                    Console.WriteLine("Realizando empréstimo...");


                        if (loginNumeroConta != 0)
                        {
                            Console.WriteLine("Digite o valor do Empréstimo. Conta Empresárial tem limite extra para até R$ 5000, demais contas até R$ 2000:");
                            decimal valorEmprestimo = decimal.Parse(Console.ReadLine());
                            foreach (var conta in contas)
                            {
                                if (conta.NumeroConta == loginNumeroConta.ToString())
                                {
                                    conta.Emprestimo(valorEmprestimo);
                                   
                                    
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma conta acessada. Por favor, acesse uma conta primeiro.");
                        }




                        break;

                case 8:
                    Console.WriteLine("Calculando Redimento.....");

                      
                        if (loginNumeroConta != 0)
                        {
                            
                         
                            var contasPoupanca = contas.Where((x) => x.GetType() == typeof(ContaPoupanca)).ToList();
                            foreach (ContaPoupanca conta in contasPoupanca)
                            {

                                if (conta.NumeroConta == loginNumeroConta.ToString())
                                {
                                    //conta.calcularRendimento(valorRedimento);
                                    conta.calcularRendimento();


                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Somente para contas do tipo poupança");
                                }
                             }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma conta acessada. Por favor, acesse uma conta primeiro.");
                        }

                        break;

                case 9:
                    Console.WriteLine("Saindo do programa....");
                    break;

                default:

                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");

                
            }




        }

    }


}

