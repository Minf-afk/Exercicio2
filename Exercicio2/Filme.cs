using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Exercicio2
{
    public class Filme
    {
        public Filme(string titulo, int duracao, List<string> elenco)
        {
            Titulo = titulo;
            Duracao = duracao;
            Elenco = elenco;
        }
        public string Titulo { get; }
        public int Duracao { get; }
        public List<string> Elenco { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"O filme: {Titulo} possui duração de: {Duracao} min e tem como elenco: {string.Join(", ", Elenco)}");
        }
        public static void ListarFilmes(List<Filme> filmes)
        {
            foreach (var f in filmes)
                Console.WriteLine($"{f.Titulo} - {f.Duracao} min");
        }

        public void AdicionarFilme()
        {

        }

    }
}
