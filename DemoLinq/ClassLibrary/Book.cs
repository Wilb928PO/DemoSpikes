using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.ClassLibrary
{
    public class Book
    {
        //Properties for each field in the Books table in the database
        public int Book_ID { get; set; }
        public int Type_ID { get; set; }
        public string Book_Title { get; set; }
        public string Authr_Last_Name { get; set; }
        public string Author_First_Name { get; set; }
    }
}
