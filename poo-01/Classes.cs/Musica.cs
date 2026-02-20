namespace poo_01.Classes;
public class Musica : Conteudo
{
    public string NomeArtista { get; set; }

    public override void Reproduzir()
    {
        System.Console.WriteLine($"Som: {Titulo} | Artista: {NomeArtista}");
    }
}
