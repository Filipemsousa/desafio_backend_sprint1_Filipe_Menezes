class ContaCorrente : ContaBancaria
{
    // Definindo uma taxa fixa para cada saque
    private const decimal TaxaSaque = 2.00m;

    public ContaCorrente(string numeroConta, string titular, decimal saldoInicial)
        : base(numeroConta, titular, saldoInicial)
    {
        
    }

    // Sobrescrevendo o método de Saque para incluir a lógica da taxa
    public override void Sacar(decimal valor)
    {
        decimal valorTotal = valor + TaxaSaque;

        if (valor > 0 && base.valorTotal >= valorTotal)
        {
            base.valorTotal -= valorTotal;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso! (Taxa: R$ {TaxaSaque})");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque com a taxa ou valor inválido.");
        }
    }


    public void Detalhe_Corrente()
    {
        Console.WriteLine("--- Detalhes da Conta Corrente ---");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo Atual: R$ {valorTotal}");
        Console.WriteLine($"Taxa de Saque: R$ {TaxaSaque}");
    }
}