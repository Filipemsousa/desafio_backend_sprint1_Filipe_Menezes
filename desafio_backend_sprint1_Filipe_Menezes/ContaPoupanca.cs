using desafio_backend_sprint1_Filipe_Menezes;

class ContaPoupanca : ContaBancaria , IRendimento

{
    private const decimal valorRendimento = 0.015m;
    public ContaPoupanca(string titular, string numeroConta, decimal saldoInicial) : base(titular, numeroConta, saldoInicial)
    {

    }

    public override void Sacar(decimal valor)
    {
        decimal valorTotal = valor;

        if (valor > 0 && base.valorTotal >= valorTotal)
        {
            base.valorTotal -= valorTotal;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso! (Redimento: {valorRendimento} %)");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque com a taxa ou valor inválido.");
        }
    }


    public  decimal calcularRendimento()
    {
        // 1. Calcula o novo valor e atualiza a variável de instância
        valorTotal = valorTotal + (valorTotal * valorRendimento);

        // 2. Retorna o valor total atualizado (ou o lucro, dependendo da sua intenção)
        Console.WriteLine($"O valor após o rendimento foi {valorTotal}");
        return valorTotal;
        
    }

    public void Detalhe_Poupanca()
    {
        Console.WriteLine("--- Detalhes da Conta Poupança ---");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo Atual: R$ {valorTotal}");
        Console.WriteLine($"Rendimento mensal: {valorRendimento} %");
        

    }
}
