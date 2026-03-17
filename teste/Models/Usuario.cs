using teste.Enums;
namespace teste.Models;

public class Usuario
{
    public Usuario(PerfilAcessoEnum perfilAcesso, string nome, string email, DateTime dataNascimento)
    {
        Id = Guid.NewGuid().ToString();
        PerfilAcesso = perfilAcesso;
        Email = email;
        Senha = GerarSenhaAleatoria();
        Colaborador = CriarColaborador(perfilAcesso, nome, dataNascimento);

    }
    public string Id { get; }
    public PerfilAcessoEnum PerfilAcesso { get; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public Colaborador Colaborador { get; private set; }


    public void AtualizarDadosCadastrais(string nome, DateTime dataNascimento, string email)
    {
        Email = email;
        Colaborador.AtualizarDadosPessoais(nome, dataNascimento);
    }

    public void DefinirSuperiorDiretoDoColaborador(Colaborador colaborador) => Colaborador.DefinirSuperiorDireto(Colaborador);

    private string GerarSenhaAleatoria() => Guid.NewGuid().ToString().Substring(1, 7);

    public override string ToString()
    {
        return Colaborador?.Superior is not null
            ? $"Nome: {Colaborador.Nome} | Email: {Email}"
            : $"Nome: {Colaborador.Nome} | Email: {Email} | Código do Gestor: {Colaborador.Superior.Nome}";

    }

    public void AtualizarSenha(string novaSenha)
    {
        if (string.IsNullOrEmpty(novaSenha) || novaSenha.Length < 6)
        {
            Console.Error.WriteLine("Senha deve ter pelo menos 6 caracteres");
            return;
        }

        Senha = novaSenha;
    }

    private Colaborador CriarColaborador(PerfilAcessoEnum perfilAcesso, string nome, DateTime dataNascimento)
    {
        return perfilAcesso switch
        {
            PerfilAcessoEnum.Gerente => new Gerente(Id, nome, dataNascimento),
            PerfilAcessoEnum.Funcionario => new Funcionario(Id, nome, dataNascimento),
            _ => null
        };
    }
}
