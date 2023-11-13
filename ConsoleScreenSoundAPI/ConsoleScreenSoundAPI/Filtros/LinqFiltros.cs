using ConsoleScreenSoundAPI.Modelos;
using System;
using System.Linq;
namespace ConsoleScreenSoundAPI.Filtros;

internal class LinqFiltros
{
    public static void FilterTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in TodosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artista pelo genero: {genero}");
        if(artistasPorGenero.Count > 0)
        {
            foreach(var artista in artistasPorGenero)
            {
                  Console.WriteLine($"Artista : {artista}");
            }
        }
        else
        {
            Console.WriteLine("Nada encontrado!");
        }
         Console.WriteLine($"Ao todo são {artistasPorGenero.Count} artistas registrados para {genero} ");
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicaDeUmArtista = musicas.Where(musica => musica.Artista.Contains(nomeArtista)).Distinct().ToList();
        if(musicaDeUmArtista.Count > 0)
        {
            Console.WriteLine($"Exibindo musicas de {nomeArtista}");
            foreach(var musica in musicaDeUmArtista)
            {
            
                Console.WriteLine($"Musica : {musica.Nome}");
            }
        }
        else
        {
            Console.WriteLine($"Não encontrado musicas para: {nomeArtista}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine($"Exibindo musicas de {ano}");
        if(musicasPorAno.Count > 0)
        {
            foreach(var musica in musicasPorAno)
            {
                Console.WriteLine($"Musica: {musica.Nome}");
            }
        }
        else
        {
            Console.WriteLine($"Não encontrado musicas para: {ano}");
        }
    }

    public static void FiltrarPorNota(List<Musica> musicas)
    {
        var musicaPorNota = musicas.Where(musica => musica.Key == 1).OrderBy(musicas => musicas.Nome).ToList();
        foreach(var musica in musicaPorNota)
        {
            Console.WriteLine($"Musica -{musica.Nome}:   Tocada em  {musica.tonalidade}");
        }
        
    }

}
    