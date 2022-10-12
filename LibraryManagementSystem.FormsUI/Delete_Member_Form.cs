using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagamentSystem.FormsUI
{
    public partial class Delete_Member_Form : Form
    {
        public Delete_Member_Form()
        {
            InitializeComponent();
        }
        public MemberService memberService;
        public IBookRezervationService bookRezervationService; 
        private void Delete_Member_Form_Load(object sender, EventArgs e)
        {

        }

        private void deleteMemberIdentityBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(deleteMemberIdentityBox.Text, "[^0-9]") || deleteMemberIdentityBox.Text.Length > 11)
            {

                deleteMemberIdentityBox.Text = deleteMemberIdentityBox.Text.Remove(deleteMemberIdentityBox.Text.Length - 1);
            }
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            if (deleteMemberIdentityBox.Text == String.Empty || deleteMemberIdentityBox.Text == "")
            {
                MessageBox.Show("Please complete all required fields");
            }
            if (deleteMemberIdentityBox.Text.Length != 11)
            {
                MessageBox.Show("Identity number must be 11 digits");
            }
            else
            {
                try
                {
                    Member member = memberService.GetMemberByTCNo(deleteMemberIdentityBox.Text);
               

                    memberService.Delete(member);

                    MessageBox.Show("Silindi");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }
    }
}