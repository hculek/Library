using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Domain.Objects;
using Library_Service.Builders;
using Library_Service.dbAccess;

namespace Library_Presentation
{
    public partial class LibraryMemberMenu : UserControl
    {
        private LibraryMemberBuilder _member = new LibraryMemberBuilder();
        private List<LibraryMember> _listMembers = new List<LibraryMember>();

        public LibraryMemberMenu()
        {
            InitializeComponent();
            ToggleButtons(false);
            DisplayMembers();
        }


        private object LoadMembers() 
        {
            _listMembers = LibraryMembers.Load();
            return _listMembers;
        }

        private void DisplayMembers() 
        {
            try
            {
                LoadMembers();
                dataGridViewLibraryMembers.DataSource = _listMembers;
                //dataGridViewLibraryMembers.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }

        }

        private void ToggleButtons(bool input)
        {
            buttonAdd.Enabled = input ? false : true;
            buttonDelete.Enabled = input;
            buttonUpdate.Enabled = input;
            buttonClear.Enabled = input ? false : true;
        }

        private void Clear()
        {
            _member.Reset();
            dataGridViewLibraryMembers.ClearSelection();
            textBoxFirstName.Clear();
            textBoxMiddleName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhoneNumber.Clear();
            textBoxAddress.Clear();
            textBoxMembershipStartDate.Clear();
            //comboBoxMembershipRenewalDate.SelectedIndex = 0;
            textBoxMemberShipExpiryDate.Clear();
            textBoxSearch.Clear();
        }

        private LibraryMember BuildMember() 
        {
            _member.FirstName(textBoxFirstName.Text);
            _member.MiddleName(textBoxMiddleName.Text);
            _member.LastName(textBoxLastName.Text);
            _member.Adress(textBoxAddress.Text);
            _member.Email(textBoxEmail.Text);
            _member.PhoneNumber(textBoxPhoneNumber.Text);
            
            //add logic for membership dates
            //_member.MembershipRenewalDate();
            //_member.MembershipExpiryDate();

            var member = _member.Build();
            return member;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryMembers.Add(BuildMember());
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            Clear();
            DisplayMembers();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ToggleButtons(true);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryMembers.Update(BuildMember());
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            Clear();
            DisplayMembers();
            ToggleButtons(false);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryMembers.Remove(BuildMember());
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            Clear();
            DisplayMembers();
            ToggleButtons(false);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ToggleButtons(false);
            Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
