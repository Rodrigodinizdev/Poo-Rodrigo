namespace poo.Models;

public abstract class Atracao
{
    public string Nome { get; set; }

    public decimal AlturaMinima { get;set; } 

    public abstract void ExibirDados();

    public abstract void Funcionar();

     public bool ConferirAltura(Visitante visitante)
    {
        if (visitante.Altura < AlturaMinima)
        {
            System.Console.WriteLine($"Você não tem a altura mínima para ir na atração {Nome}!");
            return false;
        }  

        return true;
    }
}
