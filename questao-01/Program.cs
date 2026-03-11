using AvaliacaoInstrutoresQuestao_01.Models;

var notificationHandler = new NotificationHandler();
var restaurante = new Restaurante(notificationHandler);
var clienteFactory = new ClienteFactory(notificationHandler);

void MostrarNotificacoes()
{
    foreach (var n in notificationHandler.Notifications)
    {
        Console.WriteLine($"{n.Type}: {n.Message}");
    }

    notificationHandler.ClearNotifications();
}

Console.WriteLine("=== ADICIONANDO MESAS ===");

restaurante.AdicionarMesa(8);
MostrarNotificacoes();

restaurante.AdicionarMesa(6);
MostrarNotificacoes();

restaurante.AdicionarMesa(4);
MostrarNotificacoes();

Console.WriteLine("\n=== CRIANDO CLIENTES ===");

var cliente1 = clienteFactory.CriarCliente(1, "Carlos", "123456789");
MostrarNotificacoes();

var cliente2 = clienteFactory.CriarCliente(2, "Maria", "987654321");
MostrarNotificacoes();

var cliente3 = clienteFactory.CriarCliente(3, "Ana", "123"); // telefone inválido
MostrarNotificacoes();

Console.WriteLine("\n=== RESERVAS ===");

if (cliente2 != null)
{
    restaurante.ReservarMesa(cliente2, 10); // erro esperado
    MostrarNotificacoes();
}

if (cliente1 != null)
{
    restaurante.ReservarMesa(cliente1, 6);
    MostrarNotificacoes();
}

if (cliente2 != null)
{
    restaurante.ReservarMesa(cliente2, 4);
    MostrarNotificacoes();
}

Console.WriteLine("\n=== MESAS CADASTRADAS ===");

foreach (var mesa in restaurante.Mesas)
{
    Console.WriteLine($"Mesa {mesa.Id} - Capacidade: {mesa.CapacidadeDaMesa}");
}

Console.WriteLine("\n=== RESERVAS REALIZADAS ===");

foreach (var reserva in restaurante.Reservas)
{
    Console.WriteLine($"Reserva {reserva.Id} | Cliente: {reserva.IdCliente} | Mesa: {reserva.IdMesa} | Data: {reserva.DataReserva}");
}