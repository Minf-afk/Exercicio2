using Exercicio2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var jamie = new Artista("Jamie Foxx", 56);
        var waltz = new Artista("Christoph Waltz", 67);

        var uma = new Artista("Uma Thurman", 53);
        var lucy = new Artista("Lucy Liu", 55);

        var brody = new Artista("Adrien Brody", 50);
        var kretschmann = new Artista("Thomas Kretschmann", 61);

        var alex = new Artista("Alexandre Rodrigues", 41);
        var leandro = new Artista("Leandro Firmino", 45);

        var wagner = new Artista("Wagner Moura", 47);
        var andre = new Artista("André Ramiro", 42);

        var django = new Filme("Django Livre", 165, new List<Artista> { jamie, waltz });
        var killbill = new Filme("Kill Bill - Vol. 1", 111, new List<Artista> { uma, lucy });
        var pianista = new Filme("O Pianista", 150, new List<Artista> { brody, kretschmann });
        var cidade = new Filme("Cidade de Deus", 130, new List<Artista> { alex, leandro });
        var tropa = new Filme("Tropa de Elite", 115, new List<Artista> { wagner, andre });

        var filmes = new List<Filme> { django, killbill, pianista, cidade, tropa };

        Console.WriteLine("\n=== FILMES ===");
        foreach (var f in filmes)
            Console.WriteLine($"{f.Titulo} - {f.Duracao} min");

        Console.WriteLine("\n=== ELENCOS ===");
        foreach (var f in filmes)
        {
            f.ListarElenco();
            Console.WriteLine();
        }

        Console.WriteLine("\n=== FILMES DO ARTISTA (teste) ===");
        jamie.MostrarFilmesAtuados();

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}
