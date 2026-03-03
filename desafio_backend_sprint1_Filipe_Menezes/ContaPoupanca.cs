class ContaPoupanca : ContaBancaria
{
    
    public ContaPoupanca(string titular, string numeroConta, decimal saldoInicial) : base(titular, numeroConta, saldoInicial)
    {

    }


    public void Detalhe_Poupanca()
    {
        Console.WriteLine("Bem-vindo ao sistema de conta Poupança!");
        int rendimentoMensal = 2;

    }
}
