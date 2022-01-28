using Library_Domain.Genre;
using Library_Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Presentation
{
    public partial class GenreMenu : UserControl
    {
        private GenreController _genreController = new GenreController();
        private Genre _genre = new Genre();
        public GenreMenu()
        {
            InitializeComponent();
            Refresh();
        }

        private Genre Genre() 
        { 
            _genre.GenreName = TextBox.Text.ToString();
            return _genre;
        }

        private void Refresh() 
        {
            TextBox.Clear();
            listBox1.SelectedItems.Clear();
            listBox1.DataSource = _genreController.GetAll();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            _genreController.Add(Genre());
            Refresh();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _genreController.Update(Genre());
            Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _genreController.Remove(Genre());
            Refresh();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
