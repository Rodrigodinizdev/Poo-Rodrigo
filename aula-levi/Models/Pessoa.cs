namespace aula.levi.Models;

public class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public DateTime DataAniversario {get; private set;}

    public Pessoa(string nome, int idade, DateTime dataAniversario)
    {
        Nome = nome;
        Idade = idade;
        DataAniversario = DateTime.Now;
    }

}