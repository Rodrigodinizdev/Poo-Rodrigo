namespace AvaliacaoInstrutoresQuestao_01.Models;

public class Restaurante(NotificationHandler notificationHandler)
{
    public List<Mesa> Mesas { get; } = [];
    public List<Reserva> Reservas { get; } = [];

    public void AdicionarMesa(int capacidadeDaMesa)
    {
        if (capacidadeDaMesa <= 0)
        {
            notificationHandler.AddError("A capacidade da mesa deve ser maior que zero.");
            return;
        }

        var proximoId = Mesas.Max(m => m.Id) + 1;

        Mesas.Add(new Mesa(proximoId, capacidadeDaMesa));
        notificationHandler.AddSuccess($"Mesa com capacidade para {capacidadeDaMesa} pessoas adicionada com sucesso.");
    }

    public void ReservarMesa(Cliente cliente, int numeroDePessoas)
    {
        var temMesaDisponivel = Mesas.Any(m => m.CapacidadeDaMesa >= numeroDePessoas);

        if (!temMesaDisponivel)
        {
            notificationHandler.AddError("Não há mesas disponíveis para o número de pessoas informado.");
            return;
        }

        var mesaDisponivel = Mesas.First(m => m.CapacidadeDaMesa >= numeroDePessoas);
        var idProximaReserva = Reservas.Count > 0 ? Reservas.Max(r => r.Id) + 1 : 1;
        var reserva = new Reserva(idProximaReserva, cliente, mesaDisponivel);
        Reservas.Add(reserva);

        notificationHandler.AddSuccess($"Mesa reservada com sucesso para {cliente.Nome}.");
    }
}
