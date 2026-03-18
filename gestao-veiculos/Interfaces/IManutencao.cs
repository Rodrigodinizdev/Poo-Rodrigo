namespace gestao_veiculos.Interfaces;

public interface IManutencao
{
    public int ProximaManutencao { get; set; }
    void RealizarManutencao();
}
