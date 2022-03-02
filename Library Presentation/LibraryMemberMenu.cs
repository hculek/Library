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
        private DateTime _dateRenewal = new DateTime();
        private DateTime _dateStart = new DateTime();

        public LibraryMemberMenu()
        {
            InitializeComponent();
            ToggleControls(false);
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
            labelMembershipStartDate.Text = "";
            textBoxMemberShipExpiryDate.Clear();
            textBoxSearch.Clear();
        }

        private LibraryMember BuildNewMember() 
        {
            _member.FirstName(textBoxFirstName.Text.ToString());
            _member.MiddleName(textBoxMiddleName.Text.ToString());
            _member.LastName(textBoxLastName.Text.ToString());
            _member.Adress(textBoxAddress.Text.ToString());
            _member.Email(textBoxEmail.Text.ToString());
            _member.PhoneNumber(textBoxPhoneNumber.Text.ToString());
            _member.MemberShipStartDate(!String.IsNullOrEmpty(_dateStart.ToString()) ? _dateStart : _dateRenewal);
            _member.MembershipRenewalDate(_dateRenewal);
            _member.MembershipExpiryDate(_dateRenewal.AddDays(365));

            var member = _member.Build();
            return member;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryMembers.Add(BuildNewMember());
                Clear();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.InnerException);
            }
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
                LibraryMembers.Update(BuildNewMember());
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
                LibraryMembers.Remove(BuildNewMember());
                Clear();
                DisplayMembers();
                ToggleButtons(false);
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            
        }

        private void ToggleControls(bool input)
        {
            ToggleButtons(input);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _dateRenewal= DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
        }
    }
}
