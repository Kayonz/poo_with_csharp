using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Musica
    {
        public Musica(Band Artist)
        {
            Artist = Artist;
        }

        public string NameMusic { get; set; }
        public string Artist { get; }
        public int Duration { get; set; }
        public bool DisponiblePlan { get; set; }
        public string Slogan
        {
            
            get{
                return $"A música {NameMusic} pertence ao(a) {Artist}";
            }
        }

        public void ExibirListaMusica()
        {
            Console.WriteLine($"Nome: {NameMusic}");
            Console.WriteLine($"Artista: {Artist}");
            Console.WriteLine($"Duração: {Duration}");

            if (DisponiblePlan)
            {
                Console.WriteLine("Disponível no plano. \n");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+ \n");
            }
        }
    }
}
