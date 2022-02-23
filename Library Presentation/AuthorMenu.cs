using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Library_Domain.Objects;
using Library_Service.Builders;
using Library_Service.UOW;
using Library_Service.dbAccess;


namespace Library_Presentation
{
    public partial class AuthorMenu : UserControl
    {
        private AuthorBuilder _author = new AuthorBuilder();
        private List<Author> _listAuthors = new List<Author>();


        public AuthorMenu()
        {
            InitializeComponent();
            ToggleButtons(false);
            DisplayAuthors();
        }

        void LoadAuthors() 
        {
            _listAuthors = Authors.Load();
        }

        void DisplayAuthors()
        {
            try
            {
                LoadAuthors();
                dataGridView1.DataSource = _listAuthors;
                dataGridView1.Columns["AuthorID"].Visible = false;
                dataGridView1.Columns["Books"].Visible = false;
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
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
            _author.Reset();
            dataGridView1.ClearSelection();
            textBoxFirstName.Clear();
            textBoxMiddleName.Clear();
            textBoxLastName.Clear();
            TextBoxSearch.Clear();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Authors.Add(BuildAuthor());
                Clear();

            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            DisplayAuthors();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Authors.Update(BuildAuthor());
                Clear();

            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            ToggleButtons(false);
            DisplayAuthors();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Authors.Remove(BuildAuthor());
                Clear();

            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            ToggleButtons(false);
            DisplayAuthors();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            DisplayAuthors();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBoxSearch.Text.ToString()))
            {
                var searchAuthors = 
                    _listAuthors.Where(a => a.FirstName.ToLower().Contains(TextBoxSearch.Text.ToLower()) 
                || a.MiddleName.ToLower().Contains(TextBoxSearch.Text.ToLower())
                || a.LastName.ToLower().Contains(TextBoxSearch.Text.ToLower()));

                dataGridView1.DataSource = searchAuthors.ToList();
            }
            else
            {
                Clear();
                DisplayAuthors();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //_author.AuthorID(long.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            //_author.FirstName(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            //_author.MiddleName(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            //_author.LastName(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            //textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textBoxMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //textBoxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //EnableButtons();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                _author.AuthorID(long.Parse(dataGridView1.Rows[a].Cells["AuthorID"].Value.ToString()));
                _author.FirstName(dataGridView1.Rows[a].Cells["FirstName"].Value.ToString());
                _author.MiddleName(dataGridView1.Rows[a].Cells["MiddleName"].Value.ToString());
                _author.LastName(dataGridView1.Rows[a].Cells["MiddleName"].Value.ToString());
                textBoxFirstName.Text = dataGridView1.Rows[a].Cells["FirstName"].Value.ToString();
                textBoxMiddleName.Text = dataGridView1.Rows[a].Cells["MiddleName"].Value.ToString();
                textBoxLastName.Text = dataGridView1.Rows[a].Cells["LastName"].Value.ToString();
                ToggleButtons(true);
            }
            DisplayAuthors();
        }

        Author BuildAuthor() 
        {
            _author.FirstName(textBoxFirstName.Text.Trim());
            _author.MiddleName(textBoxMiddleName.Text.Trim());
            _author.LastName(textBoxLastName.Text.Trim());
            var author = _author.Build();
            return author;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
            ToggleButtons(false);
        }
    }
}
