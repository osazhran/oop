using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Advanced03.Program;

namespace C_Advanced03
{
    public delegate string BookDeleget(Book b);

    // Book Class
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title,
                    string[] _Authors, DateTime _PublicationDate,
                    decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN {ISBN}Title {Title}Authors {Authors}PublicationDate {PublicationDate}Price {Price}" ;
        }
    }

    // BookFunctions Class
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            if (B == null&&B.Title==null)
                return "enter valid ";
            return B.Title;

        }

        public static string GetAuthors(Book B)
        {
            if (B == null && B.Authors == null)
               
                return "enter valid ";
          string result = string.Join(", ", B.Authors);

            return result;
        }

        public static string GetPrice(Book B)
        {
            if (B == null )
                return "enter valid ";
            return Convert.ToString(B.Price);

        }
    }

    // LibraryEngine ClaLibrarss
    public class yEngine
    {

        public static void ProcessBooks(List<Book> bList, BookDeleget fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }

}
