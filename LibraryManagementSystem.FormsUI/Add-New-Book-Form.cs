using LibraryManagementSystem.FormsUI.Tools;
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
using System.Web.ModelBinding;

namespace LibraryManagementSystem.FormsUI
{
    public partial class Add_New_Book_Form : Form
    {
        private BookService _bookService;
        private AuthorService _authorService;
        private LanguageService _languageService;
        private CategoryService _categoryService;
        private PublisherService _publisherService;
       
        public Add_New_Book_Form()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<BookService>();
            _authorService = InstanceFactory.GetInstance<AuthorService>();
            _languageService = InstanceFactory.GetInstance<LanguageService>();
            _categoryService = InstanceFactory.GetInstance<CategoryService>();
            _publisherService = InstanceFactory.GetInstance<PublisherService>();

        }

        private void Add_New_Book_Form_Load(object sender, EventArgs e)
        {
            LoadTool.LoadCategoriesWithoutAll(_categoryService, addBookCategoryComboBox, "CategoryName", "CategoryID");
            LoadTool.LoadLanguagesWithoutAll(_languageService, addBookLanguageComboBox, "LanguageName", "LanguageID");
            LoadTool.LoadAuthorsWithoutAll(_authorService, addBookAuthorComboBox, "NameAndSurName", "AuthorID");
            LoadTool.LoadPublishersWithoutAll(_publisherService, addBookPublisherComboBox, "PublisherName", "PublisherID");
           
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if ( publicationYearBox.Text == ""|| addBookTitleBox.Text=="")
            {
                MessageBox.Show("Please complete all required fields ");
            }
            else
            {
                try
                {
                    var result = _bookService.Add(
             new Book
             {
                 AuthorID = Convert.ToInt32(addBookAuthorComboBox.SelectedValue),
                 LanguageID = Convert.ToInt32(addBookLanguageComboBox.SelectedValue),
                 CategoryID = Convert.ToInt32(addBookCategoryComboBox.SelectedValue),
                 PublisherID = Convert.ToInt32(addBookPublisherComboBox.SelectedValue),
                 Title = addBookTitleBox.Text.ToString(),
                 PublicationYear = new DateTime().
                 AddYears(Convert.
                 ToInt32(publicationYearBox.Text.ToString()) - 1)
             }
             );
                    addBookTitleBox.Clear();
                    publicationYearBox.Clear();


                    if (result != null)
                    {
                        MessageBox.Show("Added");
                        Form.ActiveForm.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               

            }
         
          

        }

        private void publicationYearBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(publicationYearBox.Text, "[^0-9]") || publicationYearBox.Text.Length > 4)
            {

                publicationYearBox.Text = publicationYearBox.Text.Remove(publicationYearBox.Text.Length - 1);
            }
        }
    }
}
