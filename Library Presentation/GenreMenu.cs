﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Library_Domain.Objects;
using Library_Service.Builders;
using Library_Service.dbAccess;

namespace Library_Presentation
{
    public partial class GenreMenu : UserControl
    {
        private GenreBuilder _genre = new GenreBuilder();
        private List<Genre> _listGenres = new List<Genre>();


        public GenreMenu()
        {
            InitializeComponent();
            ToggleButtons(false);
            LoadGenres();
        }

        void LoadGenres()
        {
            try
            {
                _listGenres = Genres.Load();

                dataGridView1.DataSource = _listGenres;
                dataGridView1.Columns["GenreID"].Visible = false;
                dataGridView1.Columns["Books"].Visible = false;
                dataGridView1.Columns["GenreName"].HeaderText = "Genre Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        void ToggleButtons(bool input) 
        {
            DeleteButton.Enabled = input;
            UpdateButton.Enabled = input;
            ClearButton.Enabled = input ? false : true;
        }

        void Clear() 
        {
            _genre.Reset();
            dataGridView1.ClearSelection();
            textBoxSearch.Clear();
            textBoxGenreLabel.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _genre.GenreName(textBoxGenreLabel.Text.Trim());
                var genre = _genre.Build();

                Genres.Add(genre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Clear();
            LoadGenres();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _genre.GenreName(textBoxGenreLabel.Text.Trim());
                var genre = _genre.Build();

                Genres.Update(genre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            Clear();
            LoadGenres();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var genre = _genre.Build();

                Genres.Remove(genre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            Clear();
            LoadGenres();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            LoadGenres();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSearch.Text.ToString()))
            {
                //_searchedList = _searchedList.Where(item => item.GenreName.ToLower().Contains(textBoxSearch.Text.ToLower().ToString()));

                var result = from genre in _listGenres
                             where genre.GenreName.ToLower().Contains(textBoxSearch.Text.ToLower())
                             select genre;
                dataGridView1.DataSource = result.ToList();
            }
            else
            {
                Clear();
                LoadGenres();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                _genre.GenreID(long.Parse(dataGridView1.Rows[a].Cells["GenreID"].Value.ToString()));
                _genre.GenreName(dataGridView1.Rows[a].Cells["GenreName"].Value.ToString());
                textBoxGenreLabel.Text = dataGridView1.Rows[a].Cells["GenreName"].Value.ToString();
                ToggleButtons(true);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
            ToggleButtons(false);
        }
    }
}
