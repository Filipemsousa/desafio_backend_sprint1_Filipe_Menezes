class ContaEmpresarial: ContaBancaria
{
    private const decimal limiteExtra = 500m;
    public ContaEmpresarial(string numeroConta, string titular, decimal saldoInicial) : base(numeroConta, titular, saldoInicial)
    {
    }

    //metodo so para emprestimo

    public override void Sacar(decimal valor)
    {
        decimal valorTotal = valor;

        if (valor > 0 && Saldo >= valorTotal)
        {
            Saldo -= valorTotal;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso! Limite de empréstimo extra: R$ {limiteExtra}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque com a taxa ou valor inválido.");
        }
    }



    public void Detalhe_Empresarial()
    {
        Console.WriteLine("--- Detalhes da Conta Empresarial ---");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo Atual: R$ {Saldo}");
        Console.WriteLine($"Limite de empréstimo extra: R$ {limiteExtra}");

    }
}
