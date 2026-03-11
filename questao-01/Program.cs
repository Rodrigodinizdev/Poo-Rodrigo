using AvaliacaoInstrutoresQuestao_01.Models;

var notificationHandler = new NotificationHandler();
var restaurante = new Restaurante(notificationHandler);
var clienteFactory = new ClienteFactory(notificationHandler);

restaurante.AdicionarMesa(capacidadeDaMesa: 8);
if (notificationHandler.HasErrors())
    notificationHandler.GetAndClearErrors();

restaurante.AdicionarMesa(capacidadeDaMesa: 6);
if (notificationHandler.HasErrors())
    notificationHandler.GetAndClearErrors();

var cliente1 = clienteFactory.CriarCliente(id: 1, nome: "Carlos", telefoneValue: "123456789");
if (notificationHandler.HasErrors())
    notificationHandler.GetAndClearErrors();

var cliente2 = clienteFactory.CriarCliente(id: 2, nome: "Maria", telefoneValue: "987654321");
if (notificationHandler.HasErrors())
    notificationHandler.GetAndClearErrors();

restaurante.ReservarMesa(cliente: cliente2, numeroDePessoas: 10);
if (notificationHandler.HasErrors())
    notificationHandler.GetAndClearErrors();

restaurante.ReservarMesa(cliente: cliente1, numeroDePessoas: 6);
if (notificationHandler.HasErrors())
    notificationHandler.GetAndClearErrors();


