using ConsoleScreenSoundAPI.Filtros;
using ConsoleScreenSoundAPI.Modelos;
using System.Text.Json;
using OpenAI_API;

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


        LinqFiltros.ExibirResumodeUmaBanda(musicas,"Coldplay");



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema : {ex.Message}");
    }
}


