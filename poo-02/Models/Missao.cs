namespace poo_02.Models;

public class Missao
{
    public string NomeDaMissao { get; set; }
    public int NivelDeDificuldade { get; set; }

    public Missao(string nomeDaMissao, int nivelDeDificuldade)
    {
        NomeDaMissao = nomeDaMissao;
        NivelDeDificuldade = nivelDeDificuldade;
    }

    public void AceitarMissao(Heroi heroi)
    {
        if (heroi.NivelDePoder < NivelDeDificuldade)
        {
            System.Console.WriteLine($"⚠️ Perigo! {heroi.Nome}, você precisa treinar mais para esta missão");
            return;
        }
        else
            heroi.Atacar();
    }
}
