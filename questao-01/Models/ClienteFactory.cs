namespace AvaliacaoInstrutoresQuestao_01.Models;

public class ClienteFactory(NotificationHandler notificationHandler)
{
    public Cliente CriarCliente(int id, string nome, string telefoneValue)
    {
        var telefone = new Telefone(telefoneValue);

        if (!telefone.IsValid())
        {
            notificationHandler.AddError("Telefone inválido. O número deve conter 9 dígitos.");
            return null;
        }

        var cliente = new Cliente(id, nome, telefone);
        notificationHandler.AddSuccess($"Cliente {nome} criado com sucesso.");
        return cliente;
    }
}
