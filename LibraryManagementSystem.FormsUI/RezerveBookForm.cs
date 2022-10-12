using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.Utilites;
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
using LibraryManagamentSystem.FormsUI.Tools;
using LibraryManagementSystem.FormsUI.Tools;
using LibraryManagamentSystem.Business.Abstract;

namespace LibraryManagementSystem.FormsUI
{
    public partial class RezerveBookForm : Form
    {
      
        public IBookRezervationService _service;
        public MemberService _memberservice;
        public string _getBookName { get; set; }    
        public int _getBookId { get; set; }
        public DateTime _getCreatedDate { get; set; }
        public RezerveBookForm()
        {
           
            
        InitializeComponent();
          
            
    }
       

        private void RezerveBookForm_Load(object sender, EventArgs e)
        {
           
            bookName.Text = _getBookName;   
            createdDate.Text=_getCreatedDate.ToString("dd MMM yyyy");
            rezerveNumber.Text = CreateReservationNumber.CreateReservation(_service).ToString();

        }
        private void bookReservation_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            PaintTool.DrawGroupBox(box, e.Graphics, Color.Transparent, Color.AntiqueWhite);
        }

        private void bookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rezervePersonTCNoBox.Text==String.Empty||rezervePersonTCNoBox.Text=="") {
                MessageBox.Show("Please complete all required fields");
            }
           else  if (rezervePersonTCNoBox.Text.Length!=11)
            {
                MessageBox.Show("Identity number must be 11 digits");
            }
            else if (_memberservice.GetIdByTCNo(rezervePersonTCNoBox.Text)==0)
            {
                MessageBox.Show("Member exists");
            }
            else {
                try
                {
                    var result = _service.Add(new Entities.Concrete.BookRezervation
                    {
                        RezervationNumber = Convert.ToInt32(rezerveNumber.Text),
                        BookID = _getBookId,
                        CreatedDate = _getCreatedDate,
                        IsActive = 0,
                        RezervePersonId = _memberservice.GetIdByTCNo(rezervePersonTCNoBox.Text)


                    });
                    if (result != null)
                    {
                        result.IsActive = 1;
                        _service.Update(result);
                        MessageBox.Show("Rezerve edildi");

                        this.Close();

                    }
                }
                catch (Exception ex) {
                   
                   
                        MessageBox.Show(ex.Message);

                    
                }
                
             
            }
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bookRezervation_Enter(object sender, EventArgs e)
        {

        }

        private void rezervePersonTCNoBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rezervePersonTCNoBox.Text, "[^0-9]") || rezervePersonTCNoBox.Text.Length > 11)
            {

                rezervePersonTCNoBox.Text = rezervePersonTCNoBox.Text.Remove(rezervePersonTCNoBox.Text.Length - 1);
            }
        }
    }
}
