namespace AvaliacaoInstrutoresQuestao_01.Models;

public class Telefone
{
    public Telefone(string value)
    {
        Value = value;
        DDD = ObterDDD();
    }

    protected string Value { get; }
    public string DDD { get; }

    public override string ToString()
    {
        return Value;
    }

    public bool IsValid()
    {
        return Value.Length == 9 && Value.All(char.IsDigit);
    }

    public string ObterDDD()
    {
        if (Value.Length >= 2)
        {
            return Value.Substring(0, 2);
        }
        return string.Empty;
    }
}
