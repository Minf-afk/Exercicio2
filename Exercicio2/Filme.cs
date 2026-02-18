using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Exercicio2
{
    public class Filme
    {
        public Filme(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
            Elenco = new List<Artista>();
        }
        public string Titulo { get; }
        public int Duracao { get; }
        public List<Artista> Elenco { get; }

        public void AdicionarElenco(Artista artista)
        {
            Elenco.Add(artista);
        }
        public static void ListarFilmes(List<Filme> filmes)
        {
            foreach (var f in filmes)
                Console.WriteLine($"{f.Titulo} - {f.Duracao} min");
        }


    }
}
