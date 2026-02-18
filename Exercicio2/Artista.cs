using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public class Artista
    {
        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesOndeAtuou = new List<Filme>();
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> FilmesOndeAtuou { get; set; }        

        public void FilmesAtuando(Filme filme)
        {
            FilmesOndeAtuou.Add(filme);
        }
        
    }
}
