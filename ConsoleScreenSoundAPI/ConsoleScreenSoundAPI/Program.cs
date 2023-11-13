using ConsoleScreenSoundAPI.Filtros;
using ConsoleScreenSoundAPI.Modelos;
using ConsoleScreenSoundAPI.OpenAiApi;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFiltros.FilterTodosOsGenerosMusicais(musicas);
        //LinqOrder.FiltrarArtistasPorNome(musicas);
        //LinqFiltros.FiltarArtistaPorGenero(musicas, "hip hop");
        //LinqFiltros.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFiltros.FiltrarMusicasPorAno(musicas, 2020);


        //var musicasPerferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPerferidasDoDaniel.ExibirMusica();
        //musicasPerferidasDoDaniel.GerarArquivoJson();


        //LinqFiltros.FiltrarPorNota(musicas);


        //ExinbindoResumo.ExibirResumodeUmaBanda(musicas, "Coldplay");
        Console.WriteLine(musicas.Count);



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema : {ex.Message}");
    }
}


