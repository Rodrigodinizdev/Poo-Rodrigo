namespace poo.Models;

public class MontanhaRussa : Atracao
{
    public int VelocidadeMaxima { get; set; }

    public override void Funcionar()
    {
        System.Console.WriteLine($"Subindo e descendo a {VelocidadeMaxima} km/h");
    }

    public override void ExibirDados()
    {
        System.Console.WriteLine($"Atração: {Nome} | Altura Mínima: {AlturaMinima}m | velocidade Maxima: {VelocidadeMaxima}");
    }
}