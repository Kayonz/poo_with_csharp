using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Band
    {

        private List<Album> albums = new List<Album>();

        public string Name { get; set; }

        public void ShowAlbums(Album album)
        {
            albums.Add(album);
        }

        public void ShowDiscography()
        {
            Console.WriteLine($" Discography of {Name}");
            foreach (Album album in albums)
            {
                Console.WriteLine($"Album: {album.NameAlbum} ({album.durationTotal}/Seconds)");
            }
        }
    }
}
