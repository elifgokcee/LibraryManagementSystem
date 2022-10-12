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
    public partial class Add_Language_Form : Form
    {
        public Add_Language_Form()
        {
            InitializeComponent();
            _languageService=InstanceFactory.GetInstance<LanguageService>();    
        }
        private LanguageService _languageService;
        private void Add_Language_Form_Load(object sender, EventArgs e)
        {

        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            if (_languageService.IsAlreadyBeen(addLanguageBox.Text))
            {
                if (addLanguageBox.Text == "")
                {
                    MessageBox.Show("Please complete all required fields ");
                }
                else
                {
                    var result =_languageService.Add(new Language
                    {
                        LanguageName = addLanguageBox.Text,


                    });
                    MessageBox.Show("Language added");
                }
              
                Form.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Language already been");
            }
        }
    }
}
