namespace AvaliacaoInstrutoresQuestao_01.Models;

public class ClienteFactory(NotificationHandler notificationHandler)
{
    public Cliente CriarCliente(int id, string nome, string telefoneValue)
    {
        var telefone = ObterTelefone(telefoneValue);

        if (notificationHandler.HasErrors())
            return null;

        return new Cliente(id, nome, telefone);
    }

    public Telefone ObterTelefone(string numero)
    {
        var telefone =  new Telefone(numero);
        if (!telefone.IsValid())
        {
            notificationHandler.AddError("Telefone inválido. O número deve conter 9 dígitos.");
            return null;
        }

        return telefone;
    }
}
