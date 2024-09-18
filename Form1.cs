using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumsMasterDetailDapper
{
    private Album _album;
    private IAlbumService _albumService;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _album = new Album();
            _albumService = new AlbumService();
        }

        private void btnSongAdd_Click(object sender, EventArgs e)
        {
            AddSong();
            grdSongs.AutoGenerateColums = false;

            BindingSource bs = new BindingSource();
            bs.DataSource = _album.Songs;
            grdSongs.DataSource = bs;

            ClearSong();
        }

        private void AddSong()
        {
            Song song = new Song();

            song.Name = txtSongName.Text;
            song.Minutes = txtMinutes.Text != string.Empty
                ? int.Parse(txtMinutes.Text)
                : 0;

            if (_album.Songs == null)
                _album.Songs = new List<Song>();

            _album.Songs.Add(song);

        }

        private void ClearSong()
        {
            txtSongName.Text = string.Empty;
            txtMinutes.Text = string.Empty;
        }

        private void SaveALbum()
        {
            _album.Name=txtAlbumName.Text;
            _album.Author=txtAuthor.Text;
            _album.ReleaseDate=txt
        }
    }

}
