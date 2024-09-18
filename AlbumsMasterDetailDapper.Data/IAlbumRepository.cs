using AlbumsMasterDetailDapper.Model;

namespace AlbumsMasterDetailDapper.Data
{
    public interface IAlbumRepository
    {
        List<Album> GetAlbums();
        bool InsertAlbum(Album album);
        bool UpdateAlbum(Album album);
        bool DeleteAlbum(Album album);
    }
}
