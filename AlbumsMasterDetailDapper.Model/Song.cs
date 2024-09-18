namespace AlbumsMasterDetailDapper.Model
{
    public class Song
    {
        public Guid Id { get; set; }
        public Guid AlbumId { get; set; }
        public string Name { get; set; }
        public int Minutes { get; set; }
    }
}
