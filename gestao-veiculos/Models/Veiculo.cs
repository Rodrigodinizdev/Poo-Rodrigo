namespace gestao_veiculos.Models;

using System.Text.RegularExpressions;

public abstract class Veiculo
{
    public Veiculo(string placa, double tanqueLitro)
    {
        if (tanqueLitro <= 0)
        {
            Console.Error.WriteLine("Capacidade do tanque deve ser maior que zero.");
            return;
        }

        Placa = ValidarPlaca(placa);
        TanqueLitro = tanqueLitro;
        Quilometragem = 0;
        CombustivelAtual = 0;
    }

    public string Placa { get; private set; }
    public int Quilometragem { get; private set; }
    public double TanqueLitro { get; private set; }
    public double CombustivelAtual { get; private set; }
    public double PercentualCombustivel => CombustivelAtual / TanqueLitro * 100;

    public abstract double CalcularConsumo();

    public void Abastecer(double litros)
    {
        if (litros <= 0)
        {
            Console.Error.WriteLine("Quantidade deve ser maior que zero.");
            return;
        }

        if (litros > TanqueLitro - CombustivelAtual)
        {
            Console.Error.WriteLine($"Espaço disponível: {TanqueLitro - CombustivelAtual:F1}L");
            return;
        }

        CombustivelAtual += litros;
        Console.WriteLine($"Abastecido com {litros}L. Tanque: {PercentualCombustivel:F1}%");
    }

    public virtual void ExibirPainel()
    {
        System.Console.WriteLine($"Dirigiu {Quilometragem} Km | Combustível restante: {PercentualCombustivel:F2}%");
    }

    public void Dirigir(int km)
    {
        if (km <= 0)
        {
            Console.Error.WriteLine("km inválida");
            return;
        }

        double consumo = CalcularConsumo();
        double necessario = km / consumo;

        if (necessario > CombustivelAtual)
        {
            Console.Error.WriteLine("Combustível insuficiente");
            return;
        }

        CombustivelAtual -= necessario;

        Quilometragem += km;
    }

    private static string ValidarPlaca(string placa)
    {
        var antigoFormato = new Regex(@"^[A-Z]{3}-\d{4}$");
        var mercosulFormato = new Regex(@"^[A-Z]{3}\d[A-Z]\d{2}$");

        if (!antigoFormato.IsMatch(placa) && !mercosulFormato.IsMatch(placa))
            throw new ArgumentException($"Placa inválida: {placa}. Use ABC-1234 ou ABC1D23");

        return placa;
    }
}
