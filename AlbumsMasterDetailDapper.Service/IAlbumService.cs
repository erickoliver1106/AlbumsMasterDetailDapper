using AlbumsMasterDetailDapper.Model;

namespace AlbumsMasterDetailDapper.Service
{
    public interface IAlbumService
    {
        List<Album> GetAlbums();
        bool SaveAlbum(Album album);
        bool DeleteAlbum(Album album);
    }
}
