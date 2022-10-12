using LibraryManagamentSystem.FormsUI.Auth;
using LibraryManagamentSystem.FormsUI.Tools;
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

namespace LibraryManagementSystem.FormsUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            _userService=InstanceFactory.GetInstance<UserService>();    
        }

        private UserService _userService;   
       

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            PaintTool.DrawGroupBox(box, e.Graphics, Color.Tan, Color.Tan);
        }
        
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginUserNameBox.Text == "" || loginPasswordBox.Text == "")
            {
                MessageBox.Show("Please complete all required fields");
            }
            else
            {
                string userName = loginUserNameBox.Text.ToString().Trim();
                string password= loginPasswordBox.Text.ToString().Trim();
                var result =  _userService.Login(userName,password);
                if (result)
                {
                    Session session = new Session {
                        UserName = loginUserNameBox.Text,
                        Password = loginPasswordBox.Text.ToString().Trim(),
                        Role = _userService.GetRole(userName,password)
                    };
                    BuildForm.Home(session);
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
           
        }
    }
}
