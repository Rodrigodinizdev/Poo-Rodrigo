// Exemplo 01

Pessoa obj1 = new Pessoa();
obj1.Nome = "Ralf";
obj1.apresentação();

// Exemplo 02

Pessoa obj2 = new();
obj2.Nome = "Estella";
obj2.apresentação();

// Exemplo 03

Pessoa obj3 = new()
{
    Nome = "Ricardo",
    Idade = 23
};
string retorno = obj3.VerificarIdade();
System.Console.WriteLine(retorno);