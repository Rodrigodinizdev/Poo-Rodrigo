namespace poo.Models;

public class Carrossel : Atracao
{
    public string Tema { get; set;}

    public override void Funcionar()
    {
        System.Console.WriteLine($"Girando suavemente com o tema {Tema}!");
    }

    public override void ExibirDados()
    {
        System.Console.WriteLine($"Atração: {Nome} | Altura Mínima: {AlturaMinima}m | Tema: {Tema}");
    }
}