using poo_02.Models;

Velocista heroi1 = new Velocista ("Super rápido", 10, 10);
heroi1.ExibirDados();

System.Console.WriteLine();

Voador heroi2 = new Voador ("super voador", 4, 8);
heroi2.ExibirDados();

System.Console.WriteLine();

Missao missao1 = new Missao("Missao 01", 8);
System.Console.WriteLine($"{missao1.NomeDaMissao} | Nível: {missao1.NivelDeDificuldade}");
missao1.AceitarMissao(heroi1);
missao1.AceitarMissao(heroi2);
