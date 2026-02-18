namespace Exercicio2
{
    public class Artista
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> FilmesOndeAtuou { get; set; }
        public int QuantidadeDeFilme => FilmesOndeAtuou.Count;

        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesOndeAtuou = new List<Filme>();
        }

        public void AdicionarFilme(Filme filme)
        {
            if (FilmesOndeAtuou.Contains(filme)) return;

            FilmesOndeAtuou.Add(filme);
            if (!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
        }

        public void MostrarFilmesAtuados()
        {
            if (FilmesOndeAtuou.Count == 0)
            {
                Console.WriteLine($"Nenhum filme encontrado na base para {Nome}");
                return;
            }

            Console.WriteLine($"Filmes de {Nome}...");
            foreach (var filme in FilmesOndeAtuou)
                Console.WriteLine($"- {filme.Titulo}");
        }
    }
}
