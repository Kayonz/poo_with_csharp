using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Album
    {
        private List<Musica> musicaList = new List<Musica>();
        private List<Musica> artistList = new List<Musica>();
        public string NameAlbum { get; set; }
        public int durationTotal => musicaList.Sum(m => m.Duration);

        public void AddMusic(Musica musica)
        {
            musicaList.Add(musica);
        }

        public void ShowAlbumMusic()
        {
            Console.WriteLine($"All The best songs of {NameAlbum}: \n");
            foreach (var musica in musicaList)
            {
                Console.WriteLine($"Music: {musica.NameMusic}");
            }
            Console.WriteLine($" \n For listen this Album you need {durationTotal}/seconds");
        }
    }
}
