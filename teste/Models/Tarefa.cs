namespace teste.Models;
using teste.Enums;

public class Tarefa
{
    public Tarefa(string titulo, string descricao, TipoTarefaEnum tipo)
    {
        Id = Guid.NewGuid().ToString().Substring(1, 7);
        Titulo = titulo;
        Descricao = descricao;
        Tipo = tipo;
        DataCriacao = DateTime.Today;
        Status = TarefaStatusEnum.Cadastrada;
    }

    public string Id { get; }
    public string Titulo { get; }
    public TarefaStatusEnum Status { get; private set; }
    public string Descricao { get; }
    public TipoTarefaEnum Tipo { get; }
    public DateTime DataCriacao { get; }
    public DateTime DataFinalizacao { get; private set; }
  

    public void Consluir()
    {
        Status = TarefaStatusEnum.Concluida;
        DataFinalizacao = DateTime.Today;
    }
    public override string ToString()
    {
        return $"Título: {Titulo} | Descrição: {Descricao} | Tipo: {Tipo} | Data Criação: {DataCriacao} | Conluida: {TarefaStatusEnum.Cadastrada}";
    }
}
