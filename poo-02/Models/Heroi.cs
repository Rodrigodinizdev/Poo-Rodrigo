namespace poo_02.Models;

public abstract class Heroi
{
    public string Nome { get; set; }

    public int NivelDePoder { get; set; }
public Heroi (string nome, int nivelDePoder)
    {
        Nome = nome;
        NivelDePoder = nivelDePoder;
    }

public void ExibirDados()
    {
        System.Console.WriteLine($"Nome: {Nome} | Nível de poder: {NivelDePoder}");
    }

public abstract void Atacar();
}
