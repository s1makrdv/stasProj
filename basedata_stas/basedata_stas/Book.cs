using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basedata_stas
{
    class Book
    {
        public string Title;
        public string Author;
        public int    PublicationYear;
        public string BookPublisherName;
        public int    Price;
        public string Condition;
        public string IssueDate;

        public Book(string Title, string Author, int PublicationYear, string BookPublisherName, int Price, string Condition, string IssueDate)
        {
            this.Title =             Title;
            this.Author =            Author;
            this.PublicationYear =   PublicationYear;
            this.BookPublisherName = BookPublisherName;
            this.Price =             Price;
            this.Condition =         Condition;
            this.IssueDate =         IssueDate;
        }
        
    }

}
