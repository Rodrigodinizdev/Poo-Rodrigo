namespace poo_02.Models;

public class Velocista : Heroi
{
    public decimal VelocidadeMaxima { get; set; }

    public Velocista(string nome, int nivelDePoder, decimal velocidadeMaxima) : base(nome, nivelDePoder)
    {
        VelocidadeMaxima = velocidadeMaxima;
    }

        public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacando os céus a {VelocidadeMaxima} Km/h");
    }
}