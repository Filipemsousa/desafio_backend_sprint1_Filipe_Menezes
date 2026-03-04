class ContaPoupanca : ContaBancaria
{
    private const decimal Rendimento = 1.500m;
    public ContaPoupanca(string titular, string numeroConta, decimal saldoInicial) : base(titular, numeroConta, saldoInicial)
    {

    }

    public override void Sacar(decimal valor)
    {
        decimal valorTotal = valor;

        if (valor > 0 && Saldo >= valorTotal)
        {
            Saldo -= valorTotal;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso! (Redimento: {Rendimento} %)");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque com a taxa ou valor inválido.");
        }
    }

    public void Detalhe_Poupanca()
    {
        Console.WriteLine("--- Detalhes da Conta Poupança ---");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo Atual: R$ {Saldo}");
        Console.WriteLine($"Rendimento mensal: {Rendimento} %");

    }
}
