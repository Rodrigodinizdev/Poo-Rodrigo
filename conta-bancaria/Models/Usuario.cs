namespace Conta_bacaria.Models;

public class Usuario
{
    public Usuario(string nome, string telefone, string cpf)
    {
        ValidarNome(nome);
        ValidarTelefone(telefone);
        ValidarCpf(cpf);
    }
    public string Nome { get; private set; }
    public string Telefone { get; private set; }
    public string Cpf { get; private set; }

    public void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser vazio");
            return;
        }

        Nome = nome;
    }

    public void ValidarTelefone(string telefone)
    {
        if (telefone.Length != 11)
        {
            Console.WriteLine("Telefone inválido");
            return;
        }

        Telefone = telefone;
    }

    public void ValidarCpf(string cpf)
    {
        if (cpf.Length != 11)
        {
            Console.WriteLine("Cpf inválido");
            return;
        }

        Cpf = cpf;
    }
}
