using AlbumsMasterDetailDapper.Model;

namespace AlbumsMasterDetailDapper.Service
{
    public interface ISongService
    {
        List<Song> GetSongs();

        bool SaveSong(Song song);
        bool DeleteSong(Song song); 
    }
}
