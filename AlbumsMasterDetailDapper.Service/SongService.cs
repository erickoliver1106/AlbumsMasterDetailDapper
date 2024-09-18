using AlbumsMasterDetailDapper.Data;
using AlbumsMasterDetailDapper.Model;

namespace AlbumsMasterDetailDapper.Service
{
    public class SongService : ISongService
    {
        private ISongRepository _repository;
        public SongService()
        {
            _repository = new SongRepository();
        }
        public bool DeleteSong(Song song)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongs()
        {
            throw new NotImplementedException();
        }

        public bool SaveSong(Song song)
        {
            bool ok;

            if (song.Id == Guid.Empty)
                ok = _repository.InsertSong(song);
            else
                ok = _repository.UpdateSong(song);

            return ok;
        }
    }
}
