using gestao_veiculos.Models;

Carro carro1 = new Carro("PZV5C02", 55.0, 5);

Console.WriteLine("================ Dados do veículo =================");
Console.WriteLine($"\nPlaca: {carro1.Placa} | Km: {carro1.Quilometragem} | Combustivel: {carro1.PercentualCombustivel:F2}%");
Console.WriteLine($"Consumo do veiculo: {carro1.CalcularConsumo()} km/l");
Console.WriteLine("\n===================================================");

System.Console.WriteLine();
carro1.Abastecer(55);
carro1.Dirigir(300);
carro1.ExibirPainel();

System.Console.WriteLine();
System.Console.Write($"Carro: {carro1.Placa}"); carro1.RealizarManutencao();