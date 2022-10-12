using LibraryManagementSystem.Business.DependencyResolvers.Ninject;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.FormsUI.Tools;
using LibraryManagementSystem.Entities.Concrete;
using System.Data.Entity.Infrastructure;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using LibraryManagamentSystem.FormsUI.Tools;
using LibraryManagementSystem.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using LibraryManagementSystem.Core.Aspects.LogAspects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Web.UI.WebControls;
using LibraryManagamentSystem.FormsUI.Auth;
using LibraryManagamentSystem.FormsUI.DependencyResolvers.Ninject;
using LibraryManagamentSystem.FormsUI;
using LibraryManagamentSystem.Business.Abstract;

namespace LibraryManagementSystem.FormsUI
{
    public partial class Home : Form
    {

        public Home(Session session)
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<BookService>();
            _authorService = InstanceFactory.GetInstance<AuthorService>();
            _languageService = InstanceFactory.GetInstance<LanguageService>();
            _categoryService = InstanceFactory.GetInstance<CategoryService>();
            _reservationService = InstanceFactory.GetInstance<IBookRezervationService>();
            _publisherService = InstanceFactory.GetInstance<PublisherService>();
            _sessionService= InstanceFactoryForms.GetInstance<SessionService>();
            _userService=InstanceFactory.GetInstance<UserService>();
            _memberService = InstanceFactory.GetInstance<MemberService>();

            _session = session;


     

        }
        private BookService _bookService;
        private AuthorService _authorService;
        private LanguageService _languageService;
        private CategoryService _categoryService;
        private IBookRezervationService _reservationService;
        private PublisherService _publisherService;
        private SessionService _sessionService;
        private MemberService _memberService;
        private UserService _userService;


        public Session _session { get; set; }    
        
        private void Home_Load(object sender, EventArgs e)
        {
            
            LoadTool.LoadNonReservedBooks(_bookService, dgwBookList);

            LoadTool.LoadAuthors(_authorService, authorsComboBox, "NameAndSurName", "AuthorID");


            LoadTool.LoadCategories(_categoryService, categoryBox, "CategoryName", "CategoryID");

            LoadTool.LoadLanguages(_languageService, languageBox, "LanguageName", "LanguageID");
            LoadTool.LoadPublishers(_publisherService, publisherComboBox, "PublisherName", "PublisherID");
            LoadTool.LoadYears(pymin, pymax);
            LoadTool.LoadActiveReservations(_reservationService, dgwBookReservation);
            ChangeMakeReserveButtonEnabled();
            ChangeNonReserveButtonEnable();

            if (_session.Role == "user")
            {
                addNewItemBox.Visible = false;
                manageBookBox.Location=new Point(21,12); 


            }



            if (this.dgwBookList.Rows.Count > 0)
            {
                this.dgwBookList.Columns[0].Visible = false;
                dgwBookList.Columns[8].Visible = false;
            
            }
            if(this.dgwBookReservation.Rows.Count>0)
            {
                this.dgwBookReservation.Columns[0].Visible = false;
                this.dgwBookReservation.Columns[1].Visible = false;

            }
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            PaintTool.DrawGroupBox(box, e.Graphics, Color.Tan, Color.Tan);
        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            PaintTool.DrawGroupBox(box, e.Graphics, Color.Tan, Color.Tan);
        }


        private void dgwBookList_DataSourceChange(object sender, System.EventArgs e)
        {
            ChangeMakeReserveButtonEnabled();
        }
        private void dgwReserveList_DataSourceChange(object sender, System.EventArgs e)
        {
            ChangeNonReserveButtonEnable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addBookForm = new Add_New_Book_Form();
            addBookForm.ShowDialog();
            this.Visible = true;
            LoadTool.LoadNonReservedBooks(_bookService, dgwBookList);
            ChangeMakeReserveButtonEnabled();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgwBookList.CurrentRow != null)
            {
                try
                {
                    _reservationService.DeleteByBookId(Convert.ToInt32(dgwBookList.CurrentRow.Cells[0].Value));
                    _bookService.Delete(
                        new Book
                        {
                            BookID = Convert.ToInt32(dgwBookList.CurrentRow.Cells[0].Value)
                        }
                        );
                    MessageBox.Show("silindi");

                    LoadTool.LoadBooks(_bookService, dgwBookList);
                    ChangeMakeReserveButtonEnabled();

                }
                catch (DbUpdateException exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Logout", "Logout", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                this.Hide();

                _sessionService.DeadSessionn(_session);
                BuildForm.Login();

            }
        }

        private void dgwBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeMakeReserveButtonEnabled();
        }

    
        private void Filter()
        {
            int minYear = Convert.ToInt32(pymin.Text);
            int maxYear = Convert.ToInt32(pymax.Text);


            if (minYear < maxYear)
            {
                var result = _bookService.DoAllFilter(
                     bookNameBox.Text,
                     Convert.ToInt32(authorsComboBox.SelectedValue),
                     Convert.ToInt32(publisherComboBox.SelectedValue),
                     Convert.ToInt32(languageBox.SelectedValue),
                     minYear,
                     maxYear,
                     Convert.ToInt32(categoryBox.SelectedValue)






                     );
                dgwBookList.DataSource = result;
            }
            else
            {
                MessageBox.Show("please select a year greater than the start year");
            }
            ChangeMakeReserveButtonEnabled();
            
        }
        private void yearFilterButton_Click(object sender, EventArgs e)
        {Filter();  

        }
        private void dgwBookList_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeMakeReserveButtonEnabled();
        }


        private void clearFilterButtıon_Click(object sender, EventArgs e)
        {
            LoadTool.LoadNonReservedBooks(_bookService, dgwBookList);
            LoadTool.LoadYears(pymin,pymax);

            bookNameBox.Text = "";
            publisherComboBox.SelectedIndex =publisherComboBox.Items.Count-1;
          
          authorsComboBox.SelectedIndex = authorsComboBox.Items.Count - 1;
            languageBox.SelectedIndex = languageBox.Items.Count - 1;
            categoryBox.SelectedIndex = categoryBox.Items.Count - 1;

            ChangeMakeReserveButtonEnabled();
        }

        private void rezerveButton_Click(object sender, EventArgs e)
        {
            Form reserveForm = new RezerveBookForm
            {
            
                _getBookName = dgwBookList.CurrentRow.Cells[1].Value.ToString(),
                _getBookId = Convert.ToInt32(dgwBookList.CurrentRow.Cells[0].Value),
                _getCreatedDate = DateTime.Now,
                _service=_reservationService,
                _memberservice=_memberService


            };
            reserveForm.ShowDialog();
            LoadTool.LoadNonReservedBooks(_bookService, dgwBookList);
            LoadTool.LoadActiveReservations(_reservationService, dgwBookReservation);
            ChangeMakeReserveButtonEnabled();
            ChangeNonReserveButtonEnable();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgwBookReservation.DataSource = _reservationService.GetActiverezervations();
            if (dgwBookReservation.Rows.Count > 0)
            {
                ChangeNonReserveButtonEnable();
            }

        }

        private void nonRezerveButton_Click(object sender, EventArgs e)
        {
            if (dgwBookReservation.CurrentRow != null)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Remove reservation", "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    int bookId = Convert.ToInt32(dgwBookReservation.CurrentRow.Cells[1].Value);

                    int reserveId = _reservationService.GetBookReservationByBookId(bookId).Id;
                    _bookService.NotRezerve(bookId);
                    

                    _reservationService.Dead(reserveId);
                    MessageBox.Show("Reservation removed");
                    dgwBookList.DataSource = _bookService.GetNonReservedBooks();
                    dgwBookReservation.DataSource = _reservationService.GetActiverezervations();
                    ChangeMakeReserveButtonEnabled();
                    ChangeNonReserveButtonEnable();

                }
            }


        }

        private void getAllBooks_Click(object sender, EventArgs e)
        {
            dgwBookList.DataSource = _bookService.GetBookDetails();
            if (dgwBookList.Rows.Count>0) {
                dgwBookList.Columns[8].Visible = false;
                dgwBookList.Columns[0].Visible = false;
               
            }
           
            ChangeMakeReserveButtonEnabled();

        }

        private void dgwBookReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeNonReserveButtonEnable();

        }
        private void dgwBookReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeNonReserveButtonEnable();

        }
        private void ChangeNonReserveButtonEnable()
        {

            if (dgwBookReservation.CurrentRow != null)
            {
                dgwBookReservation.Columns[5].Visible = false;
                int bookId = Convert.ToInt32(dgwBookReservation.CurrentRow.Cells[1].Value);

                Book book = _bookService.GetById(bookId);
                if (_bookService.GetById(bookId) != null)
                {
                    int isReserved = book.IsRezerved;
                    if (isReserved == 1)
                    {
                        nonRezerveButton.Enabled = true;
                       

                    }
                    else
                    {
                        nonRezerveButton.Enabled = false;
                       
                    }
                }
            }
            else
            {
                nonRezerveButton.Enabled = false;
            }

        }

        private void ChangeMakeReserveButtonEnabled()
        {
            dgwBookList.Columns[8].Visible = false;
            dgwBookList.Columns[0].Visible = false;
            if (dgwBookList.CurrentRow != null)
            {
                int bookId = Convert.ToInt32(dgwBookList.CurrentRow.Cells[0].Value);

                Book book = _bookService.GetById(bookId);
                if (_bookService.GetById(bookId) != null)
                {
                    int isReserved = book.IsRezerved;

                    if (isReserved == 0)
                    {
                        reserveButton.Enabled = true;
                    }
                    else
                    {
                        reserveButton.Enabled = false;
                    }

                }
            }

        }

        private void reserveSearchButton_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(reserveSearchButton.Text, "[a-zA-Z]") ||reserveSearchButton.Text.Length>6)
                {
                 
                reserveSearchButton.Text = reserveSearchButton.Text.Remove(reserveSearchButton.Text.Length - 1);
                }
            
            if (!String.IsNullOrEmpty(reserveSearchButton.Text))
            {
                dgwBookReservation.DataSource = _reservationService
                    .GetBookReservationDetailsByReserveNumber(Convert.ToInt32(reserveSearchButton.Text),1);


            }
            else
            {
                dgwBookReservation.DataSource = _reservationService.GetActiverezervations();

            }
            ChangeMakeReserveButtonEnabled();

        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            Form addLanguageForm = new Add_Language_Form();
            addLanguageForm.ShowDialog();
            this.Visible = true;

            LoadTool.LoadLanguages(_languageService, languageBox, "LanguageName", "LanguageID");
            ChangeMakeReserveButtonEnabled();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            Form addPublisherForm = new Add_Publisher_Form();
            addPublisherForm.ShowDialog();
            this.Visible = true;
            LoadTool.LoadPublishers(_publisherService, publisherComboBox, "PublisherName", "PublisherID");
            ChangeMakeReserveButtonEnabled();
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            Form addAuthorForm = new Add_Author_Form();
            addAuthorForm.ShowDialog();
            this.Visible = true;
            LoadTool.LoadAuthors(_authorService, authorsComboBox, "NameAndSurName", "AuthorID");
            ChangeMakeReserveButtonEnabled();
        }

        private void bookNameBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            dgwBookReservation.DataSource = _reservationService.GetBookReservationDetails();
            ChangeNonReserveButtonEnable();

        }

        private void getNonReservedBooks_Click(object sender, EventArgs e)
        {
           dgwBookList.DataSource= _bookService.GetNonReservedBooks();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            Form addUserForm = new Add_User_Form
            {
                _userService=_userService
            };
            
            addUserForm.ShowDialog();
            this.Visible = true;

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            Form deleteUser = new Delete_User_Form();
            deleteUser.ShowDialog();
            this.Visible = true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            Form addMemberForm = new Add_Member_Form
            {
                _memberService = _memberService,

            };
            addMemberForm.ShowDialog();
            this.Visible = true;
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {

            Form deleteMemberForm = new Delete_Member_Form
            {
                memberService = _memberService,
                bookRezervationService=_reservationService
            };
            deleteMemberForm.ShowDialog();
            this.Visible = true;
        }

        private void getMembersButton_Click(object sender, EventArgs e)
        {

            Form getMembersForm = new Get_Members_Form
            {
                _memberService = _memberService,
                _session = _session
                
               
            };
            getMembersForm.ShowDialog();
            this.Visible = true;
        }
    }
}