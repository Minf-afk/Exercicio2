using Exercicio2;
using System.Reflection.Metadata;

Console.WriteLine("Bem vindo ao CineMark\n");
Console.WriteLine("Digite 1 para artista a um filme: \n");
Console.WriteLine("Digite 2 para Listar todos os filmes: \n");
Console.WriteLine("Digite 3 para Avaliar um filme: \n");
Console.WriteLine("Digite 0 para sair...");

int opcao = int.Parse(Console.ReadLine());


do
{
    switch (opcao)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            break;
    }
}
while (opcao == 0);

Filme django = new("Django Livre", 165, new List<string>() { "Jamie Foxx", "Cristoph Waltz" });
Filme killbill = new("Kill Bill - Vol.1", 111, new List<string>() { "Uma Thurman", "Lucy Liu" });
Filme pianista = new("O Pianista", 150, new List<string>() { "Adrien Brody", "Cristoph Waltz" });
Filme cidade = new("Cidade de Deus", 130, new List<string>() { "Alexandre Rodrigues", "Leandro Firmino" });
Filme tropa = new("Tropa de Elite", 115, new List<string>() { "Wagner Moura", "André Ramiro" });

var minhaLista = new List<Filme> { django, killbill, pianista, cidade, tropa };

Filme.ListarFilmes(minhaLista);
