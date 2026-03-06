using System.Security.Cryptography.X509Certificates;

abstract class ContaBancaria
{
    public string NumeroConta { get; private set; }
    public string Titular { get; private set; }
    public decimal Saldo { get; protected set; }
    public ContaBancaria(string numeroConta, string titular, decimal saldoInicial)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public virtual void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso. Novo saldo: R${Saldo}");
        }
        else
        {
            Console.WriteLine("Valor de depósito deve ser positivo.");
        }
    }
    public virtual void Sacar(decimal valor)
    {
        if (valor > 0)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso. Novo saldo: R${Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }

        }
        else
        {
            Console.WriteLine("Valor de saque deve ser positivo.");
        }
    }

    public virtual void Emprestimo(decimal valor)
    {
        // Verifica se o valor é positivo E se não ultrapassa o limite de 2000
        if (valor > 0 && valor <= 2000)
        {
            Saldo += valor;
            Console.WriteLine($"O Empréstimo de R${valor} realizado com sucesso. Novo saldo: R${Saldo}");
        }
        else if (valor > 2000)
        {
            Console.WriteLine("Operação negada: O valor máximo para empréstimo é de R$2000.");
        }
        else
        {
            Console.WriteLine("Valor de Empréstimo deve ser positivo.");
        }
    }
}



