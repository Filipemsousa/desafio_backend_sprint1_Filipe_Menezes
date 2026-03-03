class ContaEmpresarial: ContaBancaria
{

    public ContaEmpresarial(string numeroConta, string titular, decimal saldoInicial) : base(numeroConta, titular, saldoInicial)
    {
    }
    public void Detalhe_Empresarial()
    {
        Console.WriteLine("Bem-vindo ao sistema de conta empresarial!");
        int limiteEmprestimo = 5000;
       
    }
}
