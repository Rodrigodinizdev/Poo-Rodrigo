namespace Conta_bacaria.Models;

public class ContaBancaria
{
    public ContaBancaria(string numeroConta, Usuario usuario, DateTime data)
    {
        NumeroConta = numeroConta;
        Usuario = usuario;
        Saldo = 0;
        Data = data;
    }
    public string NumeroConta { get; private set; }
    public Usuario Usuario { get; private set; }
    public decimal Saldo { get; private set; }

    public DateTime Data { get; private set; }


    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Depósito inválido");
            return;
        }

        Saldo += valor;
        Console.WriteLine($"Depósito na conta de {valor:C} efetuado com sucesso");
    }

    public void Sacar(decimal valor)
    {
        if (valor < 5)
        {
            Console.WriteLine("Valor inválido");
            return;
        }

        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }

        Saldo -= valor;
        Console.WriteLine($"Saque de {valor:C} efetuado com sucesso");
    }

    public string ExibirSaldo() => $"Conta: {NumeroConta} | {Usuario.Nome} | Saldo de: {Saldo:C} | {Data}";
}
