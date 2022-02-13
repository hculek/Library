using Library_DTO.Builders;
using Library_DTO.UOW;
using Library_Domain.Objects.Author;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            LoadAuthors();
        }


        void LoadAuthors()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listAuthors = uow.Authors.GetAll().OrderBy(a => a.LastName).ToList();
                    dataGridView1.DataSource = _listAuthors;
                    dataGridView1.Columns["AuthorID"].Visible = false;
                    dataGridView1.Columns["Books"].Visible = false;
                    dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                    dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
                    dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                    dataGridView1.ClearSelection();
                }
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
                _author.FirstName(textBoxFirstName.Text.Trim());
                _author.MiddleName(textBoxMiddleName.Text.Trim());
                _author.LastName(textBoxLastName.Text.Trim());
                var author = _author.Build();

                if  (!(
                    _listAuthors.Exists(a => a.FirstName == author.FirstName) 
                    && _listAuthors.Exists(a => a.MiddleName == author.MiddleName) 
                    && _listAuthors.Exists(a => a.LastName == author.LastName)))
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Authors.Add(author);
                        uow.Save();
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error!" +
                        "\n Author with that name exists.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LoadAuthors();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _author.FirstName(textBoxFirstName.Text.Trim());
                _author.MiddleName(textBoxMiddleName.Text.Trim());
                _author.LastName(textBoxLastName.Text.Trim());
                var author = _author.Build();

                using (var uow = UnitOfWorkFactory.Create())
                {
                    uow.Authors.Update(author);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            Clear();
            LoadAuthors();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _author.FirstName(textBoxFirstName.Text.Trim());
                _author.MiddleName(textBoxMiddleName.Text.Trim());
                _author.LastName(textBoxLastName.Text.Trim());

                using (var uow = UnitOfWorkFactory.Create())
                {
                    var author = _author.Build();
                    uow.Authors.Remove(author);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            Clear();
            LoadAuthors();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            LoadAuthors();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBoxSearch.Text.ToString()))
            {
                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("first_name LIKE %'{1}'%", TextBoxSearch.Text);

                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("first_name LIKE '%{0}%' OR middle_name LIKE '%{0}%' OR last_name LIKE '%{0}%'", TextBoxSearch.Text);
                DataView dv = (dataGridView1.DataSource as DataTable).DefaultView;
                dv.RowFilter = string.Format("FirstName LIKE '%{0}%' OR MiddleName LIKE '%{0}%' OR LastName LIKE '%{0}%'", TextBoxSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            else
            {
                Clear();
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
            LoadAuthors();
        }
    }
}
