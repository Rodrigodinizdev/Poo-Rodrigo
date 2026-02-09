class Pessoa
{
    // atributos
    public string Nome;
    public int Idade;

    // método de apresentação

    public void apresentação()
    {
        System.Console.WriteLine($"Olá, meu nome é {Nome}");
    }

    // Método para retornar idade
    
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
}