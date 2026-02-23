using poo_01.Classes;

List<Conteudo> playlist = new List<Conteudo>();

Filme filme1 = new Filme
{
    Titulo = "Velozes e furiosos",
    Ano = 2019,
    ClassificacaoIndicativa = 16,
    NomeDiretor = "Rodrigo"
};

playlist.Add(new Musica
{
    Titulo = "aaa",
    Ano = 2015,
    ClassificacaoIndicativa = 10,
    NomeArtista = "Indefinido"
});

Musica musica1 = new Musica
{
    Titulo = "tuh tuh",
    Ano = 2026,
    ClassificacaoIndicativa = 18,
    NomeArtista = "Indefinido"
};

playlist.Add(filme1);
playlist.Add(musica1);

Usuario usuario1 = new Usuario
{
    Nome = "João",
    Idade = 17
};


foreach (var conteudo in playlist)
{
    conteudo.ConferirIdade(usuario1);
}


System.Console.WriteLine("\nConteudos após 2020");
foreach (var conteudo in playlist)
{
    if (conteudo.Ano > 2020)
        conteudo.ExibirConteudo();
}
