namespace AvaliacaoInstrutoresQuestao_01.Models;

public class Cliente(int id, string nome, Telefone telefone)
{
    public int Id { get; } = id;
    public string Nome { get; } = nome;
    public Telefone Telefone { get; } = telefone;
}
