using AlbumsMasterDetailDapper.Model;

namespace AlbumsMasterDetailDapper.Data
{
    public interface ISongRepository
    {
        List<Song> GetSongs();

        bool InsertSong(Song song);
        bool UpdateSong(Song song);
        bool DeleteSong(Song song);
    }
}
