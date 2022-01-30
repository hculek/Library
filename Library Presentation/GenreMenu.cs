using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_DTO;
using Library_Domain.Objects.Genre;
using Library_Persistence.UnitOfWork;

namespace Library_Presentation
{
    public partial class GenreMenu : UserControl
    {
        public GenreMenu()
        {
            InitializeComponent();
            LoadGenres();
        }

        void LoadGenres()
        {
            var context = new Library_Persistence.ApplicationContext();
            using (var uow = new UnitOfWork(context))
            {
                //var genres = uow.Genres.GetAll();
                //if (!(genres == null)) listBox1.DataSource = genres;
                listBox1.DataSource = uow.Genres.GetAll();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //using (var uow = UnitOfWorkFactory.Create()) 
            //{
            //    Genre genre = new Genre();
            //    genre.GenreName = textBox1.Text.ToString();
            //    uow.Genres.Add(genre);
            //}

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
