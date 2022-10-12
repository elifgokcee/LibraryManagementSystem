using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.FormsUI.Auth;
using LibraryManagamentSystem.FormsUI.Utilites.ExportTools;
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
    public partial class Get_Members_Form : Form
    {
        public Get_Members_Form()
        {
            InitializeComponent();
        }
        public MemberService _memberService;
   
        public Session _session { get; set; }

        private void Get_Members_Form_Load(object sender, EventArgs e)
        {
            dgwMemberList.DataSource = _memberService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result=ConvertToPDF.ConvertToPDF_(dgwMemberList,_session.UserName);
                if (result) { MessageBox.Show("Added");
                    this.Close();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
          
        }
    }
}
