using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqDemo.ClassLibrary;

namespace LinqDemo
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        List<Book> books;
        //Book types:
        //1 = Fiction
        //2 = Non-Fiction
        //3 = Biography

        #region Form Events
        private void Form1_Load(object sender, EventArgs e)
        {
            //These books are hard-coded for demo purposes
            books = new List<Book>()
            {
                new Book{Book_ID=1, Book_Title="The Hunt for Red October", Type_ID=1, Authr_Last_Name="Clancy", Author_First_Name="Tom"},
                new Book{Book_ID=2, Book_Title="Patriot Games", Type_ID=1, Authr_Last_Name="Clancy", Author_First_Name="Tom"},
                new Book{Book_ID=3, Book_Title="Red Storm Rising", Type_ID=1, Authr_Last_Name="Clancy", Author_First_Name="Tom"},
                new Book{Book_ID=4, Book_Title="The Client", Type_ID=1, Authr_Last_Name="Grisham", Author_First_Name="John"},
                new Book{Book_ID=5, Book_Title="The Chamber", Type_ID=1, Authr_Last_Name="Grisham", Author_First_Name="John"},
                new Book{Book_ID=6, Book_Title="The Firm", Type_ID=1, Authr_Last_Name="Grisham", Author_First_Name="John"},
                new Book{Book_ID=7, Book_Title="C#7 and .Net Core 2.0", Type_ID=2, Authr_Last_Name="Nagel", Author_First_Name="Christian"},
                new Book{Book_ID=8, Book_Title="Pro ASP.NET MVC 5", Type_ID=2, Authr_Last_Name="Freeman", Author_First_Name="Adam"},
                new Book{Book_ID=9, Book_Title="C# 7.0 in a Nutshell", Type_ID=2, Authr_Last_Name="Freeman", Author_First_Name="John"},
                new Book{Book_ID=10, Book_Title="Steve Jobs", Type_ID=3, Authr_Last_Name="Issacson", Author_First_Name="Walter"},
                new Book{Book_ID=11, Book_Title="Bill Gates: A Biography", Type_ID=3, Authr_Last_Name="Becraft", Author_First_Name="Michael"},
                new Book{Book_ID=12, Book_Title="Hard Drive", Type_ID=3, Authr_Last_Name="Wallace", Author_First_Name="James"}
            };
        }

        #endregion
        #region Button Events

        private void btnsimplelinq_Click(object sender, EventArgs e)
        {
            var query = from item in books //This is a simple LINQ query without Lambdas  The query variable is of type Enumerable.  Be aware that the LINQ query is not executed here!
                        where item.Type_ID == 1
                        select item;
            foreach(Book bk in query)  //The foreach loop executes the query.  This is called "Deferred Execution"
            {                          //Each result is put into bk and the Book_Title is added to the textbox.
                txtResults.Text += $"{bk.Book_Title}\r\n";
            }
        }

        private void btnextensionmethod_Click(object sender, EventArgs e)
        {
            string demo = "";
            MessageBox.Show(demo.NewStringMethod());
        }

        private void btnlinqwithlambdas_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //Notice that instead of using LINQ syntax, whe can use extension methods to build queries 
            //right off of the List<Book> object
            var query = books.Where(x => x.Type_ID == 1); 
            foreach(Book bk in query) //This is the same as the last example
            {
                txtResults.Text += $"{bk.Book_Title}\r\n";
            }
                      
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //This Where extension method contains a compund condition.  The && means that both conditions must be true
            //before that record is added to the results
            var query = books.Where(x => x.Authr_Last_Name == "Clancy" && x.Author_First_Name == "Tom");
            foreach(Book bk in query)
            {
                txtResults.Text += $"{bk.Book_Title}\r\n";
            }
        }

        private void btnorderby_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //This query is similar to the last one except we added the OrderBy extensioon method.  When you add more than one
            //extenion method, it's called "Chaining"
            var query = books.Where(x => x.Authr_Last_Name == "Clancy" && x.Author_First_Name == "Tom")
                .OrderBy(x => x.Book_Title);
            foreach(Book bk in query)
            {
                txtResults.Text += $"{bk.Book_Title}\r\n";
            }
        }

        private void btnthenby_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //This query adds the ThenBy extension method to add a secondary sort
            var query = books.Where(b => b.Type_ID == 2)
                .OrderBy(b => b.Authr_Last_Name)
                .ThenBy(x => x.Author_First_Name);
            foreach(Book bk in query)
            {
                txtResults.Text += $"{bk.Book_Title }, {bk.Author_First_Name} {bk.Authr_Last_Name}\r\n";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //This query only selets the book titles, so in the forech loop, there's no need to specify a property
            //to print the titles out
            var query = books.Where(type => type.Type_ID == 1)
                .OrderBy(title => title.Book_Title)
                .Select(title => title.Book_Title);
            foreach(var title in query)
            {
                txtResults.Text += $"{title}\r\n";
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)

        {
            txtResults.Text = "";
            //This query gets all of the biographies and converts the results to a List<Book>
            var titles = books.Where(t => t.Type_ID == 1)
                .OrderBy(t => t.Book_Title).ToList();

            //This uses the ForEach extension method to loop through the results.
            //This works because List<T> has a ForEach extension method, so you have to use the ToList extension method
            //in order to do this, unless you write your own ForEach extension method
            titles.ForEach(t => txtResults.Text += $"{t.Book_Title}\r\n");
        }

        private void btnAllBiographies_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //This query gets all of the biographies and converts the results to a list
            var query = books.Where(w => w.Type_ID == 3).ToList();
            //Again, this ForEach extension method works because query is converted to List<Book> type
            query.ForEach(t => txtResults.Text += $"{t.Book_Title}\r\n");
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            //This query gets all of the biographies as before, but uses the First() extension method 
            //to return just the first book
            var query2 = books.Where(x => x.Type_ID == 3)
                .ToList()
                .First();
            txtResults.Text = $"{query2.Book_Title}";
        }




        #endregion
        #region Extension Methods

        


        #endregion

       
    }
}
