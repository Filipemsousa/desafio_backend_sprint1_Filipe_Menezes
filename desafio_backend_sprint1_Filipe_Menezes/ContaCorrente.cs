class ContaCorrente : ContaBancaria
{
    public ContaCorrente(string numeroConta, string titular, decimal saldoInicial) : base(numeroConta, titular, saldoInicial)
    {
      

    }

    public void Detalhe_Corrente()
    {
        Console.WriteLine("Bem-vindo ao sistema de conta Corrente!");
        int taxaMensal = 10;

    }
}
