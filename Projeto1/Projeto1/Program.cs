
using Projeto1;

Band Eden = new Band();
Eden.Name = "Eden";

Album albumDoEden =  new Album();
albumDoEden.NameAlbum = " I think you think too much of me";

Musica musica1 = new Musica(Eden);
musica1.NameMusic = "Sex";
musica1.Duration = 120;

Musica musica2 = new Musica(Eden);
musica2.NameMusic = "Rock + Roll";
musica1.Duration = 120;

albumDoEden.AddMusic(musica1);
albumDoEden.AddMusic(musica2);

albumDoEden.ShowAlbumMusic();


Eden.ShowAlbums(albumDoEden);
Eden.ShowDiscography();

 