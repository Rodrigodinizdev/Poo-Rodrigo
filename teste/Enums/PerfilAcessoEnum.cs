using System.ComponentModel;

namespace teste.Enums
{
    public enum PerfilAcessoEnum
    {
        [Description("Administrador")]
        Administrador = 1,
        [Description("Fucionário")]
        Funcionario = 2,
        [Description("Gerente")]
        Gerente = 3,
    }
}
