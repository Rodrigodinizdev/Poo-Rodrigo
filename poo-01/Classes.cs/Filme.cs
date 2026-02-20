namespace poo_01.Classes;

public class Filme : Conteudo
{
    public string NomeDiretor { get; set; }

    public override void Reproduzir()
    {
        System.Console.WriteLine($"Cine: {Titulo} | Diretor: {NomeDiretor}");
    }
}