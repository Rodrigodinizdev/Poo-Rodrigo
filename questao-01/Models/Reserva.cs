namespace AvaliacaoInstrutoresQuestao_01.Models;

public class Reserva
{
    public Reserva(int id, Cliente cliente, Mesa mesa)
    {
        Id = id;
        IdCliente = cliente.Id;
        IdMesa = mesa.Id;
        DataReserva = DateTime.Now;
    }

    public int Id { get; }
    public int IdCliente { get; }
    public int IdMesa { get; }
    public DateTime DataReserva { get; }
}
