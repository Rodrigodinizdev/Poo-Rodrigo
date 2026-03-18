using gestao_veiculos.Interfaces;

namespace gestao_veiculos.Models;

public class Carro : Veiculo, IManutencao
{
    public Carro(string placa, double tanqueLitro, int numeroPortas) : base(placa, tanqueLitro)
    {
        NumeroPortas = numeroPortas;
    }
    public int NumeroPortas { get; private set; }
    public int ProximaManutencao { get; set; } = 10000;

    public override double CalcularConsumo()
    {
        return 12.0;
    }

    public void RealizarManutencao()
    {
        Console.WriteLine($"Próxima manutenção em: {ProximaManutencao} km, faltam ({ProximaManutencao - Quilometragem} km)");
    }
}
