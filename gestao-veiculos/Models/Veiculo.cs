namespace gestao_veiculos.Models;
using System.Text.RegularExpressions;

public abstract class Veiculo
{
    public Veiculo(string placa, double tanqueLitro)
    {
        Placa = validarPlaca(placa);
        TanqueLitro = tanqueLitro;
        Quilometragem = 0;
        CombustivelAtual = 0;
    }

    public virtual string validarPlaca(string placa)
    {
        var antigoFormato = new Regex(@"^[A-Z]{3}-\d{4}$");
        var mercosulFormato = new Regex(@"^[A-Z]{3}\d[A-Z]\d{2}$");

        if (!antigoFormato.IsMatch(placa) && !mercosulFormato.IsMatch(placa))
            throw new ArgumentException($"Placa inválida: {placa}. Use ABC-1234 ou ABC1D23");

        return placa;        
    }

    public string Placa { get; private set; }
    public int Quilometragem { get; private set; }
    public double TanqueLitro { get; private set; }
    public double CombustivelAtual { get; private set; }
    public double PercentualCombustivel => CombustivelAtual / TanqueLitro * 100;

    public abstract double CalcularConsumo();

    public void Abastecer(double litros)
    {
        if (litros > (TanqueLitro - CombustivelAtual) || litros <= 0)
        {
            Console.Error.WriteLine("Quantidade incompátivel com o tanque do veículo");
            return;
        }

        CombustivelAtual += litros;
        Console.WriteLine($"Abastecimento de {litros} litros efetuado com sucesso");
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

    public virtual void ExibirPainel()
    {
        System.Console.WriteLine($"{Quilometragem} Km");
        System.Console.WriteLine($"Nível combustível: {PercentualCombustivel}%");
    }

}
