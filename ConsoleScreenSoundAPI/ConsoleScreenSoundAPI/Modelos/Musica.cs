using System.Text.Json.Serialization;

namespace ConsoleScreenSoundAPI.Modelos;

internal class Musica
{
    private string[] tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
};

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string tonalidade { 
        get 
        {
            return tonalidades[Key];
        }
    }

    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Artista: {Genero}");
        Console.WriteLine($"Tonalidade: {tonalidade}");
    }
}
