using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.Core.Utilities.Auth;
using LibraryManagamentSystem.Entities.Concrete;
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
    public partial class Add_User_Form : Form
    {
        public Add_User_Form()
        {
            InitializeComponent();
          
        }
        public UserService _userService;   
        public RoleService _roleService;    

        private void Add_User_Form_Load(object sender, EventArgs e)
        {
            addUserRolecomboBox.DataSource = _roleService.GetAll();
            addUserRolecomboBox.DisplayMember = "RoleName";
            addUserRolecomboBox.ValueMember = "Id";
            
           
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (addUsernameBox.Text==""||addUserPasswordBox.Text=="")
            {
                MessageBox.Show("Please complete all required fields");
            }
            else if (!_userService.IsUserNameAlredyBeen(addUsernameBox.Text)) {
                MessageBox.Show("Username already has been");
            }
            else
            
            {
                var result=_userService.Add(new User
                {
                    UserName = addUsernameBox.Text, 
                    Password=VerifyUser.HashPassword(addUserPasswordBox.Text),   
                    Role=_roleService.GetById(Convert.ToInt32(addUserRolecomboBox.SelectedValue)).RoleName,
                    RoleId= Convert.ToInt32(addUserRolecomboBox.SelectedValue)

                });
                if (result != null)
                {
                    MessageBox.Show("Added");
                }
                addUsernameBox.Text = "";
                addUserPasswordBox.Text = "";
                this.Close();
            }
        }
        
    }
}
