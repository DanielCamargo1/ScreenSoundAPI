using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void adicionarMusicas(Musica musica) 
    {
        ListaDeMusicasFavoritas.Add(musica);

    }
    public void ExibirMusica()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} De {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });

        string NomeDoArquivo = $"Musicas Favoritas de - {Nome}.json";
        File.WriteAllText(NomeDoArquivo, json);
        Console.WriteLine($"Json Criado com Sucesso {Path.GetFullPath(NomeDoArquivo)}");
    }
}
