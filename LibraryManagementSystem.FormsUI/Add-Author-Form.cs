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

namespace LibraryManagementSystem.FormsUI
{
    public partial class Add_Author_Form : Form
    {
        public Add_Author_Form()
        {
            InitializeComponent();
            _authorService = InstanceFactory.GetInstance<AuthorService>();
        }
        private AuthorService _authorService;

        private void Add_Author_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void addAuthorButton_Click(object sender, EventArgs e)

        {
            
            if (addAuthorNameBox.Text == "")
            {
                MessageBox.Show("Please complete all required fields ");
            }
            else
            {
                if (_authorService.IsAlreadyBeen(addAuthorNameBox.Text, addAuthorSurNameBox.Text)==false)
                {
                    MessageBox.Show("Author already been");

                }
                else
                {
                    var result = _authorService.Add(new Author
                    {
                        AuthorName = addAuthorNameBox.Text,
                        AuthorSurName = addAuthorSurNameBox.Text,
                    });
                    if (result != null)
                    {
                        MessageBox.Show("Added");
                    }
                    addAuthorNameBox.Text = "";
                    addAuthorSurNameBox.Text = "";
                    Form.ActiveForm.Close();
                }

            }

        }
    }
}
