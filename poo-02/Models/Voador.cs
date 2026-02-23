namespace poo_02.Models;

public class Voador : Heroi
{
    public double AltitudeMaxima { get; set; }
    
    public Voador(string nome, int nivelDePoder, double altitudeMaxima) : base(nome, nivelDePoder)
    {
        AltitudeMaxima = altitudeMaxima;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacando os céus a {AltitudeMaxima} metros");
    }
}