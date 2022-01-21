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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            BookMenu Book = new BookMenu();
            OpenControlInTab(Book);
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AuthorMenu Author = new AuthorMenu();
            OpenControlInTab(Author);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            GenreMenu Genre = new GenreMenu();
            OpenControlInTab(Genre);
        }



        private void OpenControlInTab(UserControl ctl)
        {
            if (!CheckTabExists(ctl.Name))
            {
                TabPage tab = new TabPage(ctl.Name);
                this.TabControlMainWindow.TabPages.Add(tab);
                tab.Text = ctl.Name;
                tab.Controls.Add(ctl);
            }
                int index = GetTabIndex(ctl.Name);
                this.TabControlMainWindow.SelectTab(index);
        }

        private bool CheckTabExists(string tabName)
        {
            foreach (TabPage tab in TabControlMainWindow.TabPages)
            {
                if (tab.Text == tabName) 
                { return true; }
            }
            return false;
        }

        private int GetTabIndex(string tabName) 
        {
            int index = 0;
            foreach (TabPage tab in TabControlMainWindow.TabPages)
            {
                if (tab.Text == tabName)
                {
                    index = TabControlMainWindow.TabPages.IndexOf(tab);
                    return index;
                }
            }
            return index;
        }

        private void CloseActiveTab_Click(object sender, EventArgs e)
        {
            if(!(this.TabControlMainWindow.SelectedTab==null))
            this.TabControlMainWindow.TabPages.Remove(this.TabControlMainWindow.SelectedTab);
        }
    }
}
