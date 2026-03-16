using teste.Enums;
using teste.Models;

Usuario usuarioGestor = new Usuario(PerfilAcessoEnum.Funcionario, "arthur lanches", "arthur@lanches.com");
Usuario usuarioSubordinado = new Usuario(PerfilAcessoEnum.Funcionario, "João", "joao@email.com");

// Console.WriteLine(usuarioGestor.ToString()); 
// Console.WriteLine(usuarioSubordinado.ToString()); 

usuarioSubordinado.DefinirSuperiorDiretoDoColaborador(usuarioGestor.Id);

Console.WriteLine(usuarioGestor);
Console.WriteLine(usuarioSubordinado);
