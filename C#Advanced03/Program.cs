using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace C_Advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> { new Book("osa123", "heep", ["x", "y", "z"], DateTime.Now, 18),
                                                new Book("ochd93", "stack", ["mo", "os", "zkh"], DateTime.Now, 148) };
         
            Book book1 = new Book("osa123", "heep", ["x", "y", "z"], DateTime.Now, 18);

            #region a. User Defined Delegate Datatype to get titles for all books in my list
            
            BookDeleget titleDelegate = BookFunctions.GetTitle;
            yEngine.ProcessBooks(books, titleDelegate);// استخدام User Defined Delegate
           
            #endregion

            #region b. BCL Delegates

            Func<Book, string> func = BookFunctions.GetTitle;
            Console.WriteLine(func(book1));

            func = BookFunctions.GetPrice;
            Console.WriteLine(func(book1));

            func = BookFunctions.GetAuthors;
            Console.WriteLine(func(book1));
            #endregion

            #region c. Anonymous Method (GetISBN)
            //this method take Book And Return String It Will Be Func I Can Use Last Func
            func = delegate (Book book1) { return book1.ISBN; };
            Console.WriteLine($"ISBN is A {func(book1)}");

            #endregion

            #region d. Lambda Expression (GetPublicationDate)
            //this method take Book And Return DT It Will create New  Func 
            Func<Book, DateTime> func2 = BookFunctions =>book1.PublicationDate;
            Console.WriteLine($"PublicationDate Is A{func2(book1)}");
           // func2=boo
            #endregion

        }
    }
}
