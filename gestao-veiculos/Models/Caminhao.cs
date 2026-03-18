using gestao_veiculos.Interfaces;

namespace gestao_veiculos.Models;

public class Caminhao : Veiculo, IManutencao
{
    public Caminhao(string placa, double tanqueLitro, double capacidadeCarga) : base(placa, tanqueLitro)
    {
        CapacidadeCarga = capacidadeCarga;
    }

    public double CapacidadeCarga { get; private set;}
    public int ProximaManutencao { get; set; } = 5000;

    public override double CalcularConsumo()
    {
        return 5.0;
    }

    public void RealizarManutencao()
    {
        Console.WriteLine($"Manutenção a cada {ProximaManutencao} km");
    }
}
