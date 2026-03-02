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


        void ExibirMenu()
        {
            ExibirLogo();

            Console.WriteLine("\nMenu de opções:");
            Console.WriteLine("1 - Acessar conta corrente");
            Console.WriteLine("2 - Acessar conta poupança");
            Console.WriteLine("3 - Acessar conta empresarial");
            Console.WriteLine("4- Sair");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você escolheu a opção {opcao}");
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Acessando conta corrente...");



                    Console.WriteLine("Digite o numero da conta");
                    int NumeroContaC = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do titular da conta");
                    string TitularC = Console.ReadLine();

                    Console.WriteLine("Digite o saldo inicial da conta");
                    decimal SaldoInicialC = decimal.Parse(Console.ReadLine());

                    

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
                    Console.WriteLine("Saindo do programa....");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

        }
        ExibirMenu();

        




    }
    

}

