namespace Exercicio2
{
    public class Filme
    {
        public Filme(string titulo, int duracao, List<Artista> elenco)
        {
            Titulo = titulo;
            Duracao = duracao;
            Elenco = new List<Artista>();

            if (elenco != null)
            {
                foreach (var artista in elenco)
                    AdicionarElenco(artista);
            }
        }

        public string Titulo { get; }
        public int Duracao { get; }
        public List<Artista> Elenco { get; }

        public void AdicionarElenco(Artista artista)
        {
            if (Elenco.Contains(artista)) return;

            Elenco.Add(artista);
            if (!artista.FilmesOndeAtuou.Contains(this))
                artista.AdicionarFilme(this);

            Console.WriteLine($"{artista.Nome} adicionado/a ao elenco de {Titulo}.");
        }

        public void ListarElenco()
        {
            if (Elenco.Count == 0)
            {
                Console.WriteLine("Elenco vazio.");
                return;
            }

            Console.WriteLine($"Elenco de {Titulo}...");
            foreach (var artista in Elenco)
                Console.WriteLine($"- {artista.Nome} ({artista.Idade} anos)");
        }
    }
}
