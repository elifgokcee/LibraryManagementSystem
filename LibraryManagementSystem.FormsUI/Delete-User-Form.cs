using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.Core.Utilities.Auth;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.DependencyResolvers.Ninject;
using LibraryManagementSystem.Entities.Concrete;
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
    public partial class Delete_User_Form : Form
    {
        
        public Delete_User_Form()
        {
            InitializeComponent();
           
        }
        public UserService _userService;
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (deleteUserNameBox.Text == "" || deleteUserpasswordBox.Text == "")
            {
                MessageBox.Show("Please complete all required fields");
            }
            else if (!_userService.Login(deleteUserNameBox.Text, deleteUserpasswordBox.Text))
            {
                MessageBox.Show("Username exists");
            }
            else

            {
                try {
                    _userService.Delete(_userService.GetUser(deleteUserNameBox.Text, deleteUserpasswordBox.Text));

                    MessageBox.Show("Deleted");
                }
                catch{ 
                }
            }
           
            deleteUserNameBox.Text = "";
                deleteUserpasswordBox.Text = "";
                this.Close();
            }

        private void Delete_User_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
