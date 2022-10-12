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
    public partial class Add_Publisher_Form : Form
    {
        public Add_Publisher_Form()
        {
            InitializeComponent();
            _publisherService = InstanceFactory.GetInstance<PublisherService>();
        }
        private PublisherService _publisherService;

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            if (_publisherService.IsAlreadyBeen(addPublisherNameBox.Text)) {
                if (addPublisherNameBox.Text == "")
                {
                    MessageBox.Show("Please complete all required fields ");
                }
                else
                {
                   var result= _publisherService.Add(new Publisher
                    {
                        PublisherName = addPublisherNameBox.Text,

                    });
                    MessageBox.Show("Publisher added");
                }
               
                Form.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Publisher already been");
            }
           
        }

        private void Add_Publisher_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
