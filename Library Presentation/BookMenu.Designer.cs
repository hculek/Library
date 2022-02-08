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
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxSearchAuthors = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxSearchGenres = new System.Windows.Forms.TextBox();
            this.comboBoxGenresList = new System.Windows.Forms.ComboBox();
            this.dataGridViewAuthorsList = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewBookAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridViewBookGenres = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthorsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookGenres)).BeginInit();
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
            // 
            // AddGenreButton
            // 
            this.AddGenreButton.Location = new System.Drawing.Point(481, 531);
            this.AddGenreButton.Name = "AddGenreButton";
            this.AddGenreButton.Size = new System.Drawing.Size(75, 23);
            this.AddGenreButton.TabIndex = 17;
            this.AddGenreButton.Text = "Add Genre";
            this.AddGenreButton.UseVisualStyleBackColor = true;
            // 
            // RemoveAuthorButton
            // 
            this.RemoveAuthorButton.Location = new System.Drawing.Point(103, 646);
            this.RemoveAuthorButton.Name = "RemoveAuthorButton";
            this.RemoveAuthorButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveAuthorButton.TabIndex = 18;
            this.RemoveAuthorButton.Text = "Remove Author";
            this.RemoveAuthorButton.UseVisualStyleBackColor = true;
            // 
            // RemoveGenreButton
            // 
            this.RemoveGenreButton.Location = new System.Drawing.Point(562, 531);
            this.RemoveGenreButton.Name = "RemoveGenreButton";
            this.RemoveGenreButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveGenreButton.TabIndex = 19;
            this.RemoveGenreButton.Text = "Remove Genre";
            this.RemoveGenreButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(103, 359);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(184, 359);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(265, 359);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.Location = new System.Drawing.Point(427, 359);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
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
            // TextBoxSearchAuthors
            // 
            this.TextBoxSearchAuthors.Location = new System.Drawing.Point(252, 478);
            this.TextBoxSearchAuthors.Name = "TextBoxSearchAuthors";
            this.TextBoxSearchAuthors.Size = new System.Drawing.Size(120, 20);
            this.TextBoxSearchAuthors.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search genre:";
            // 
            // TextBoxSearchGenres
            // 
            this.TextBoxSearchGenres.Location = new System.Drawing.Point(727, 478);
            this.TextBoxSearchGenres.Name = "TextBoxSearchGenres";
            this.TextBoxSearchGenres.Size = new System.Drawing.Size(120, 20);
            this.TextBoxSearchGenres.TabIndex = 30;
            // 
            // comboBoxGenresList
            // 
            this.comboBoxGenresList.FormattingEnabled = true;
            this.comboBoxGenresList.Location = new System.Drawing.Point(481, 504);
            this.comboBoxGenresList.Name = "comboBoxGenresList";
            this.comboBoxGenresList.Size = new System.Drawing.Size(237, 21);
            this.comboBoxGenresList.TabIndex = 33;
            this.comboBoxGenresList.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // dataGridViewAuthorsList
            // 
            this.dataGridViewAuthorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthorsList.Location = new System.Drawing.Point(22, 504);
            this.dataGridViewAuthorsList.Name = "dataGridViewAuthorsList";
            this.dataGridViewAuthorsList.Size = new System.Drawing.Size(399, 136);
            this.dataGridViewAuthorsList.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 255);
            this.dataGridView2.TabIndex = 35;
            // 
            // dataGridViewBookAuthors
            // 
            this.dataGridViewBookAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookAuthors.Location = new System.Drawing.Point(22, 710);
            this.dataGridViewBookAuthors.Name = "dataGridViewBookAuthors";
            this.dataGridViewBookAuthors.Size = new System.Drawing.Size(399, 150);
            this.dataGridViewBookAuthors.TabIndex = 36;
            // 
            // dataGridViewBookGenres
            // 
            this.dataGridViewBookGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookGenres.Location = new System.Drawing.Point(481, 710);
            this.dataGridViewBookGenres.Name = "dataGridViewBookGenres";
            this.dataGridViewBookGenres.Size = new System.Drawing.Size(350, 150);
            this.dataGridViewBookGenres.TabIndex = 37;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(22, 359);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 38;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(346, 359);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 39;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridViewBookGenres);
            this.Controls.Add(this.dataGridViewBookAuthors);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewAuthorsList);
            this.Controls.Add(this.comboBoxGenresList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxSearchGenres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxSearchAuthors);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
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
            this.Size = new System.Drawing.Size(902, 900);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthorsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookGenres)).EndInit();
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
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxSearchAuthors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxSearchGenres;
        private System.Windows.Forms.ComboBox comboBoxGenresList;
        private System.Windows.Forms.DataGridView dataGridViewAuthorsList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridViewBookAuthors;
        private System.Windows.Forms.DataGridView dataGridViewBookGenres;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
