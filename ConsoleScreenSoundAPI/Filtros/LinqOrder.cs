using ConsoleScreenSoundAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleScreenSoundAPI.Filtros
{
    internal class LinqOrder
    {
        public static void FiltrarArtistasPorNome(List<Musica> musicas)
        {
            var TodosOsArtistas = musicas.OrderBy(artista => artista.Artista).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistass: ");
            foreach(var artista in TodosOsArtistas)
            {
               
                Console.WriteLine($"_ {artista}");
            }
        }

       
    }
}
