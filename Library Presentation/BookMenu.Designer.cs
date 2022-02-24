namespace Library_Presentation
{
    partial class BookMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.AddGenreButton = new System.Windows.Forms.Button();
            this.RemoveAuthorButton = new System.Windows.Forms.Button();
            this.RemoveGenreButton = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearchAuthors = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearchGenres = new System.Windows.Forms.TextBox();
            this.dataGridViewAuthorsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewBookAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridViewBookGenres = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewGenreList = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthorsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenreList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book title:";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(22, 430);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(237, 20);
            this.textBoxBookTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of pages:";
            // 
            // textBoxNumberPages
            // 
            this.textBoxNumberPages.Location = new System.Drawing.Point(275, 430);
            this.textBoxNumberPages.Name = "textBoxNumberPages";
            this.textBoxNumberPages.Size = new System.Drawing.Size(91, 20);
            this.textBoxNumberPages.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Authors list:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genre list:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Book genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 693);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Book authors:";
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(22, 646);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorButton.TabIndex = 16;
            this.AddAuthorButton.Text = "Add Author";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // AddGenreButton
            // 
            this.AddGenreButton.Location = new System.Drawing.Point(481, 646);
            this.AddGenreButton.Name = "AddGenreButton";
            this.AddGenreButton.Size = new System.Drawing.Size(75, 23);
            this.AddGenreButton.TabIndex = 17;
            this.AddGenreButton.Text = "Add Genre";
            this.AddGenreButton.UseVisualStyleBackColor = true;
            this.AddGenreButton.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // RemoveAuthorButton
            // 
            this.RemoveAuthorButton.Location = new System.Drawing.Point(103, 646);
            this.RemoveAuthorButton.Name = "RemoveAuthorButton";
            this.RemoveAuthorButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveAuthorButton.TabIndex = 18;
            this.RemoveAuthorButton.Text = "Remove Author";
            this.RemoveAuthorButton.UseVisualStyleBackColor = true;
            this.RemoveAuthorButton.Click += new System.EventHandler(this.buttonRemoveAuthor_Click);
            // 
            // RemoveGenreButton
            // 
            this.RemoveGenreButton.Location = new System.Drawing.Point(562, 646);
            this.RemoveGenreButton.Name = "RemoveGenreButton";
            this.RemoveGenreButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveGenreButton.TabIndex = 19;
            this.RemoveGenreButton.Text = "Remove Genre";
            this.RemoveGenreButton.UseVisualStyleBackColor = true;
            this.RemoveGenreButton.Click += new System.EventHandler(this.buttonRemoveGenre_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(184, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(265, 359);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(346, 359);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClear.Location = new System.Drawing.Point(508, 359);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Search books:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Search authors:";
            // 
            // textBoxSearchAuthors
            // 
            this.textBoxSearchAuthors.Location = new System.Drawing.Point(252, 478);
            this.textBoxSearchAuthors.Name = "textBoxSearchAuthors";
            this.textBoxSearchAuthors.Size = new System.Drawing.Size(120, 20);
            this.textBoxSearchAuthors.TabIndex = 28;
            this.textBoxSearchAuthors.TextChanged += new System.EventHandler(this.textBoxSearchAuthors_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search genre:";
            // 
            // textBoxSearchGenres
            // 
            this.textBoxSearchGenres.Location = new System.Drawing.Point(711, 478);
            this.textBoxSearchGenres.Name = "textBoxSearchGenres";
            this.textBoxSearchGenres.Size = new System.Drawing.Size(120, 20);
            this.textBoxSearchGenres.TabIndex = 30;
            this.textBoxSearchGenres.TextChanged += new System.EventHandler(this.textBoxSearchGenres_TextChanged);
            // 
            // dataGridViewAuthorsList
            // 
            this.dataGridViewAuthorsList.AllowUserToAddRows = false;
            this.dataGridViewAuthorsList.AllowUserToDeleteRows = false;
            this.dataGridViewAuthorsList.AllowUserToResizeColumns = false;
            this.dataGridViewAuthorsList.AllowUserToResizeRows = false;
            this.dataGridViewAuthorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthorsList.Location = new System.Drawing.Point(22, 504);
            this.dataGridViewAuthorsList.MultiSelect = false;
            this.dataGridViewAuthorsList.Name = "dataGridViewAuthorsList";
            this.dataGridViewAuthorsList.ReadOnly = true;
            this.dataGridViewAuthorsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAuthorsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAuthorsList.Size = new System.Drawing.Size(399, 136);
            this.dataGridViewAuthorsList.TabIndex = 34;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeColumns = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(22, 57);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1064, 255);
            this.dataGridViewBooks.TabIndex = 35;
            // 
            // dataGridViewBookAuthors
            // 
            this.dataGridViewBookAuthors.AllowUserToAddRows = false;
            this.dataGridViewBookAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewBookAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookAuthors.Location = new System.Drawing.Point(22, 710);
            this.dataGridViewBookAuthors.Name = "dataGridViewBookAuthors";
            this.dataGridViewBookAuthors.ReadOnly = true;
            this.dataGridViewBookAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookAuthors.Size = new System.Drawing.Size(399, 150);
            this.dataGridViewBookAuthors.TabIndex = 36;
            // 
            // dataGridViewBookGenres
            // 
            this.dataGridViewBookGenres.AllowUserToAddRows = false;
            this.dataGridViewBookGenres.AllowUserToDeleteRows = false;
            this.dataGridViewBookGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookGenres.Location = new System.Drawing.Point(481, 710);
            this.dataGridViewBookGenres.Name = "dataGridViewBookGenres";
            this.dataGridViewBookGenres.ReadOnly = true;
            this.dataGridViewBookGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookGenres.Size = new System.Drawing.Size(350, 150);
            this.dataGridViewBookGenres.TabIndex = 37;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(103, 359);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 38;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(427, 359);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewGenreList
            // 
            this.dataGridViewGenreList.AllowUserToAddRows = false;
            this.dataGridViewGenreList.AllowUserToDeleteRows = false;
            this.dataGridViewGenreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenreList.Location = new System.Drawing.Point(481, 504);
            this.dataGridViewGenreList.Name = "dataGridViewGenreList";
            this.dataGridViewGenreList.ReadOnly = true;
            this.dataGridViewGenreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGenreList.Size = new System.Drawing.Size(350, 136);
            this.dataGridViewGenreList.TabIndex = 40;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(22, 359);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 41;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // BookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridViewGenreList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewBookGenres);
            this.Controls.Add(this.dataGridViewBookAuthors);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.dataGridViewAuthorsList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSearchGenres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSearchAuthors);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.RemoveGenreButton);
            this.Controls.Add(this.RemoveAuthorButton);
            this.Controls.Add(this.AddGenreButton);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumberPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookMenu";
            this.Size = new System.Drawing.Size(1108, 900);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthorsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumberPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.Button AddGenreButton;
        private System.Windows.Forms.Button RemoveAuthorButton;
        private System.Windows.Forms.Button RemoveGenreButton;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearchAuthors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearchGenres;
        private System.Windows.Forms.DataGridView dataGridViewAuthorsList;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridView dataGridViewBookAuthors;
        private System.Windows.Forms.DataGridView dataGridViewBookGenres;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewGenreList;
        private System.Windows.Forms.Button buttonCreate;
    }
}
