using teste.Enums;
using teste.Models;

Usuario usuario = new Usuario(1, PerfilAcessoEnum.Administrador, "João", "joao@email.com");

usuario.AtualizarSenha("Rodrigo123");

System.Console.WriteLine(usuario.ToString()); 
