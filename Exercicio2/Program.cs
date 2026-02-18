using Exercicio2;
using System.Reflection.Metadata;

Filme django = new("Django Livre", 165, new List<string>() { "Jamie Foxx", "Cristoph Waltz" });
Filme killbill = new("Kill Bill - Vol.1", 111, new List<string>() { "Uma Thurman", "Lucy Liu" });
Filme pianista = new("O Pianista", 150, new List<string>() { "Adrien Brody", "Cristoph Waltz" });
Filme cidade = new("Cidade de Deus", 130, new List<string>() { "Alexandre Rodrigues", "Leandro Firmino" });
Filme tropa = new("Tropa de Elite", 115, new List<string>() { "Wagner Moura", "André Ramiro" });

var minhaLista = new List<Filme> { django, killbill, pianista, cidade, tropa };

Filme.ListarFilmes(minhaLista);
