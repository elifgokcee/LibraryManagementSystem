

using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Core.Entities.Abstract;
using LibraryManagementSystem.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.FormsUI.Tools
{
    public static class LoadTool
    { 
        public static void LoadAuthors(AuthorService service,ComboBox comboBox,string name,string id)
        {
            List<Author> authors = service.GetAll();
            authors.Add(new Author{ AuthorID=-1,AuthorName="All"});
            comboBox.DataSource = authors;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
            comboBox.SelectedIndex = authors.Count - 1;

        }
        public static void LoadAuthorsWithoutAll(AuthorService service, ComboBox comboBox, string name, string id)
        {
            List<Author> authors = service.GetAll();
            
            comboBox.DataSource = authors;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
           

        }
        public static void LoadPublishers(PublisherService service, ComboBox comboBox, string name, string id)
        {
            List<Publisher> publishers = service.GetAll();
            publishers.Add(new Publisher { PublisherName = "All" ,PublisherID=-1});
            comboBox.DataSource = publishers;   
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
            comboBox.SelectedIndex = publishers.Count - 1;
        }
        public static void LoadPublishersWithoutAll(PublisherService service, ComboBox comboBox, string name, string id)
        {
            List<Publisher> publishers = service.GetAll();
        
            comboBox.DataSource = publishers;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
           
        }
        public static   void LoadLanguages(LanguageService service, ComboBox comboBox, string name, string id)
        {
          
            List<Language> languages = service.GetAll();
            languages.Add(new Language { LanguageName = "All" ,LanguageID=-1});
            comboBox.DataSource = languages;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
            comboBox.SelectedIndex = languages.Count - 1;
        }
        public static void LoadLanguagesWithoutAll(LanguageService service, ComboBox comboBox, string name, string id)
        {

            List<Language> languages = service.GetAll();
            comboBox.DataSource = languages;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
           
        }
        public static void LoadBooks(BookService service, DataGridView dgw)
        {
            dgw.DataSource = service.GetBookDetails();
           
         
        }
        public static void LoadNonReservedBooks(BookService service, DataGridView dgw)
        {
            dgw.DataSource = service.GetNonReservedBooks();
       


        }
        public static void LoadCategories( CategoryService service, ComboBox comboBox, string name, string id)
        {
            List<Category> categories = service.GetAll();
            categories.Add(new Category { CategoryName = "All" ,CategoryID=-1});
            comboBox.DataSource = categories;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
            comboBox.SelectedIndex = categories.Count-1;
        }
        public static void LoadCategoriesWithoutAll(CategoryService service, ComboBox comboBox, string name, string id)
        {
            List<Category> categories = service.GetAll();
            comboBox.DataSource = categories;
            comboBox.DisplayMember = name;
            comboBox.ValueMember = id;
           
        }
        public static void LoadActiveReservations(IBookRezervationService service, DataGridView dgw)
        {
            dgw.DataSource = service.GetActiverezervations();
            if (dgw.Rows.Count > 0)
            {
               dgw.Columns[0].Visible = false;
                dgw.Columns[1].Visible = false;

            }

        }
        public static void LoadYears(ComboBox minBox, ComboBox maxBox)
        {
            for (int i = 1200; i <=DateTime.Now.Year; i++)
            {
                minBox.Items.Add(i.ToString());
                maxBox.Items.Add(i.ToString());
                minBox.ValueMember = i.ToString();
                maxBox.ValueMember = i.ToString();

            }
            minBox.SelectedIndex = 0;
            maxBox.SelectedIndex = minBox.Items.Count - 1;

        }



}
   

}