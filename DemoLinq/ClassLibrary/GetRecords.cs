using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinqDemo.ClassLibrary
{
    public static class GetRecords
    {
        //Gets all of the book types in the Book Types table and stores them in a List of BookTypes
        public static List<BookType> BookTypes(string constring)
        {
            List<BookType> types = new List<BookType>(); //List of BookTypes to hold the records from the BookTypes table
            string strsql = "SELECT * FROM booktype";  //SQL that will be used to get all of the records from the BookTypes table
            using (SqlConnection cn = new SqlConnection(constring)) //Holds the connection to the database.  The using statement ensures the connection is automatically closed when you're finished with it
            {
                cn.Open();  //Opens the connection to the database
                using (SqlCommand cmd = new SqlCommand(strsql, cn))  //Sets up a Command object that will be used to execute the SQL query
                {
                    SqlDataReader rdr = cmd.ExecuteReader(); //This executes the SQL query and stores the results in a DataReader object so the records can be accessed
                    while(rdr.Read()) //This loop will read one record at a time and will end wheen the last record is read
                    {
                        types.Add(new BookType()  //This adds a record to the List of BookTypes
                        {
                            Type_ID=int.Parse(rdr["typeid"].ToString()),
                            Type_Name=rdr["Typename"].ToString()
                        });
                    }
                }
            }
            return types; //This returns the List of BookTypes to the caller
        }

        //Gets all of the books in the Books table and stores them in a List of Books
        public static List<Book> Books(string constring)
        {
            List<Book> books = new List<Book>(); //List of Books used to hold the records from the Books table
            string strsql = "SELECT * FROM books"; //SQL that will be used to get all of the records from the Books table
            using (SqlConnection cn = new SqlConnection(constring)) //Connection object that holds the connection to the database.  The using statement is used to automatically close the database connection when the object goes out of scope
            {
                cn.Open(); //Opens the database connection
                using (SqlCommand cmd = new SqlCommand(strsql, cn)) //Command object that's used to execute the SQL query
                {
                    SqlDataReader rdr = cmd.ExecuteReader(); //Executes the query and stores the results ina DataReader object 
                    while(rdr.Read()) //This loop reads one record at a time and ends after the 
                    {
                        books.Add(new Book() //Adds the current record to the List of Books
                        {
                            Book_ID = int.Parse(rdr["bookid"].ToString()),
                            Type_ID = int.Parse(rdr["typeid"].ToString()),
                            Book_Title = rdr["booktitle"].ToString(),
                            Authr_Last_Name = rdr["authorlastname"].ToString(),
                            Author_First_Name=rdr["authorfirstname"].ToString()
                        });
                    }
                }
            }
            return books; //Returns the List of Books to the caller
        }
    }
}
