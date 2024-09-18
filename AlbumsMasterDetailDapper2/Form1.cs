using AlbumsMasterDetailDapper.Model;
using AlbumsMasterDetailDapper.Service;

namespace AlbumsMasterDetailDapper2
{
    public partial class Form1 : Form
    {
        private Album _album;
        private IAlbumService _albumService;
        public Form1()
        {
            InitializeComponent();
            _album = new Album();
            _albumService = new AlbumService();
        }

        private void btnSongAdd_Click(object sender, EventArgs e)
        {

            AddSong();
            grdSongs.AutoGenerateColumns = false;

            BindingSource bs = new BindingSource();
            bs.DataSource = _album.Songs;
            grdSongs.DataSource = bs;

            ClearSong();
        }

        private void AddSong()
        {
            Song song = new Song();


            song.Name = txtSongName.Text;

            try

            {
                song.Minutes = txtMinutes.Text != string.Empty
                    ? int.Parse(txtMinutes.Text)
                    : 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_album.Songs == null)
                _album.Songs = new List<Song>();

            _album.Songs.Add(song);

        }

        private void ClearSong()
        {
            txtSongName.Text = string.Empty;
            txtMinutes.Text = string.Empty;
        }
        private void ClearAlbum()
        {
            txtAlbumName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtReleaseDate.Value = DateTime.Now;
        }

        private void SaveAlbum()
        {
            _album.Name = txtAlbumName.Text;
            _album.Author = txtAuthor.Text;
            _album.ReleaseDate = txtReleaseDate.Value;

            _albumService.SaveAlbum(_album);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAlbum();
            ClearAlbum();
        }

    }
}
