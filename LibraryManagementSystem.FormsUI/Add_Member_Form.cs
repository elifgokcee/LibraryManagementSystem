using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.DependencyResolvers.Ninject;
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
    public partial class Add_Member_Form : Form
    {
        public Add_Member_Form()
        {
            InitializeComponent();
        }

        private void Add_Member_Form_Load(object sender, EventArgs e)
        {
            
        }

        public MemberService _memberService;

        private void addMemberButton_Click(object sender, EventArgs e)
        {

            if (addFirstNameBox.Text == "" || lastNameBox.Text == ""||addMemberIdentityBox.Text=="")
            {
                MessageBox.Show("Please complete all required fields");
            }
            if (!_memberService.isAlreadyBeen(addMemberIdentityBox.Text))
            {
                MessageBox.Show("Member already exists");
            }
            else
            {

                try
                {

                    _memberService.Add(new Member
                    {
                        DateOfBirth = Convert.ToDateTime(dateOfBirth.Text),
                        FirstName = addFirstNameBox.Text,
                        LastName = lastNameBox.Text,
                        TcNo = addMemberIdentityBox.Text


                    });
                    MessageBox.Show("Added");
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
