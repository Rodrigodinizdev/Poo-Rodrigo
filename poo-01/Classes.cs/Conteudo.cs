namespace poo_01.Classes;

public abstract class Conteudo
{
    public string Titulo { get; set; }
    public int Ano { get; set; }
    public int ClassificacaoIndicativa { get; set; }
    public virtual void ExibirConteudo()
    {
        System.Console.WriteLine($"Titulo: {Titulo} | Ano: {Ano} | Classificação indicativa: {ClassificacaoIndicativa} anos");
    }

    public abstract void Reproduzir();

    public void ConferirIdade(Usuario usuario)
    {
        if (usuario.Idade < ClassificacaoIndicativa)
        {
            Console.WriteLine($"{usuario.Nome} não pode acessar o conteúdo {Titulo}");
            return;
        }
        else
            Reproduzir();
    }
}
