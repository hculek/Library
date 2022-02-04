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
            //TabControlMainWindow.DrawMode = TabDrawMode.OwnerDrawFixed;
            //TabControlMainWindow.SizeMode = TabSizeMode.Fixed;
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }




        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.TabControlMainWindow.TabPages[e.Index];
                var tabRect = this.TabControlMainWindow.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                //var closeImage = new Bitmap(Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Images\\Close.jpg");
                //e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                //TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
                e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
                e.Graphics.DrawString(this.TabControlMainWindow.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = TabControlMainWindow.GetTabRect(this.TabControlMainWindow.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {
                this.TabControlMainWindow.TabPages.Remove(this.TabControlMainWindow.SelectedTab);
            }
        }
    }
}
