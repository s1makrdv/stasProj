using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basedata_13
{
    

    public partial class Form1 : Form
    {
        private static List<Book> books = new List<Book>();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            books.Add(new Book(titleBox.Text, 
                               authorNameBox.Text, 
                               Convert.ToInt32(publicationYearBox.Text), 
                               bookPublisherNameBox.Text, 
                               Convert.ToInt32(priceBox.Text), 
                               conditionBox.Text, 
                               issuedBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Book book in books)
            {
                dataGridView1.Rows.Add(book.Title, book.Author, book.PublicationYear, book.BookPublisherName, book.Price, book.Condition, book.IssueDate );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //open file
            string line;
            int succesBooksParsed = 0;
            int failedBooksParsed = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"d:\test.txt");
            books.Clear();
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                if (words.Length == 7)
                {
                    books.Add(new Book(words[0], 
                                       words[1], 
                                       Convert.ToInt32(words[2]), 
                                       words[3], 
                                       Convert.ToInt32(words[4]), 
                                       words[5], 
                                       words[6]));
                    ++succesBooksParsed;
                }
                else
                {
                    ++failedBooksParsed;
                }
            }
            toolStripStatusLabel1.Text = "Loaded " + Convert.ToString(succesBooksParsed) + " and " + Convert.ToString(failedBooksParsed) + " Failed";
            file.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 0;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"d:\test.txt");
            foreach(Book book in books)
            {
                file.WriteLine(book.Title + ',' + book.Author + ',' +  book.PublicationYear + ',' + book.BookPublisherName + ',' + book.Price + ',' + book.Condition + ',' + book.IssueDate);
                ++counter;
            }
            file.Close();
            toolStripStatusLabel1.Text = Convert.ToString(counter) + " books was saved to file";
        }
    }
}
