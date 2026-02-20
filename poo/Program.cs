using poo.Models;

List<Atracao> MeuParque = new List<Atracao>();

MeuParque.Add(new MontanhaRussa
{
    Nome = "Mountain",
    AlturaMinima = 1.40m,
    VelocidadeMaxima = 120
});

MeuParque.Add(new Carrossel
{
    Nome = "Cavalos Encantados",
    AlturaMinima = 1.00m,
    Tema = "Cavalinhos"
});

 Visitante visitante = new Visitante
 {
     Nome = "Rodrigo",
     Altura = 1.70m
 };

 foreach (var atracao in MeuParque)
{
    if (atracao.ConferirAltura(visitante))
    {
        atracao.ExibirDados();
        Console.WriteLine(" Pode entrar!");
        atracao.Funcionar();
    }
}
