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
                    break;
                case 2:
                    Console.WriteLine("Acessando conta poupança...");
                    break;
                case 3:
                    Console.WriteLine("Acessando conta empresarial...");
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

