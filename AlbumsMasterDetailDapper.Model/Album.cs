namespace AlbumsMasterDetailDapper.Model
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Song> Songs{ get; set; }

    }
}
