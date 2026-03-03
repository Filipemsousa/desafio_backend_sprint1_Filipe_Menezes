using System.Security.Cryptography.X509Certificates;

abstract class ContaBancaria
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

    public void Depositar(decimal valor)
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
    public void Sacar(decimal valor)
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
}



