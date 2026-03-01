class ContaBancaria
{
    public string NumeroConta { get; private set; }
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }
    public ContaBancaria(string numeroConta, string titular, decimal saldoInicial)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldoInicial;
    }
    
}



