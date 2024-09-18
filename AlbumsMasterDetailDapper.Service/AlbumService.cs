using AlbumsMasterDetailDapper.Data;
using AlbumsMasterDetailDapper.Model;
using System.Reflection.PortableExecutable;
using System.Transactions;

namespace AlbumsMasterDetailDapper.Service
{
    public class AlbumService : IAlbumService
    {
        private IAlbumRepository _repository;
        private ISongService _songService;
        public AlbumService()
        {
            _repository = new AlbumRepository();
            _songService = new SongService();

        }

        public bool DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public bool SaveAlbum(Album album)
        {
            bool ok = false;
            using (TransactionScope ts = new TransactionScope())
            {

                if (album.Id == Guid.Empty)
                {
                    album.Id = Guid.NewGuid();
                    ok = _repository.InsertAlbum(album);

                    if (ok)
                    {
                        foreach (Song song in album.Songs)
                        {
                            song.AlbumId = album.Id;
                            _songService.SaveSong(song);
                        }
                    }
                    ts.Complete();
                }
                return ok;
                
            }
        }
    }
}
