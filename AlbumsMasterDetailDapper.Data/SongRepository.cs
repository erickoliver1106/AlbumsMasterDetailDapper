using AlbumsMasterDetailDapper.Model;
using Dapper;

namespace AlbumsMasterDetailDapper.Data
{
    public class SongRepository :GenericRepository, ISongRepository
    {
        public bool DeleteSong(Song song)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongs()
        {
            throw new NotImplementedException();
        }

        public bool InsertSong(Song song)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO Songs(AlbumId,Name,Minutes)
                        VALUES(@AlbumId,@Name,@Minutes)";

            var result = db.Execute(sql,
                new { song.AlbumId, song.Name, song.Minutes });

            return result > 0;

        }

        public bool UpdateSong(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
