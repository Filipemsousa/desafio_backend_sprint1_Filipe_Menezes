class ContaEmpresarial: ContaBancaria
{
    private const decimal limiteExtra = 5000m;
    public ContaEmpresarial(string numeroConta, string titular, decimal saldoInicial) : base(numeroConta, titular, saldoInicial)
    {
    }

    //metodo so para emprestimo

    public override void Sacar(decimal valor)
    {
        decimal valorTotal = valor;

        if (valor > 0 && base.valorTotal >= valorTotal)
        {
            base.valorTotal -= valorTotal;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso! Limite de empréstimo extra: R$ {limiteExtra}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque com a taxa ou valor inválido.");
        }
    }


    public override void Emprestimo(decimal valor)
    {
        // Verifica se o valor é positivo E se não ultrapassa o limite de 2000
        if (valor > 0 && valor <= limiteExtra)
        {
            valorTotal += valor;
            Console.WriteLine($"O Empréstimo de R${valor} realizado com sucesso. Novo saldo: R${valorTotal}");
        }
        else if (valor > 2000)
        {
            Console.WriteLine("Operação negada: O valor máximo para empréstimo com uso do limite extra é de R$5000.");
        }
        else
        {
            Console.WriteLine("Valor de Empréstimo deve ser positivo.");
        }
    }





    public void Detalhe_Empresarial()
    {
        Console.WriteLine("--- Detalhes da Conta Empresarial ---");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo Atual: R$ {valorTotal}");
        Console.WriteLine($"Limite de empréstimo extra: R$ {limiteExtra}");

    }
}
