using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Book_Management_System
{
    internal class BooksManagement
    {
       public static List<Book> bookList=new List<Book>();
        public static void Addbook(Book book)
        {
           var matchedBooks = bookList.Find(books => books.Title==book.Title && books.Author==book.Author);
            if (matchedBooks==null)
            {
                int bookId = bookList.Any() ? bookList.Max(x => x.Id) + 1 : 500;
                book.Id = bookId;
                bookList.Add(book);
            }
            else
                {
                throw new Exception("Book Already Exist");
            }
           
        }

        public static List<Book> ViewAllBooks()
        {
            return bookList;
        }
        public static List<Book> SearchBooksByAuthour(string autor) { 

            List<Book> sortedList = bookList.FindAll(book=>book.Author==autor);
            return sortedList;
        }

        public static bool RemoveAllBooks()
        {
            if(bookList.Any())
            {
                bookList.Clear();
                return true;
            }
            else
            {
                throw new Exception("Book Records Are alredy empty");
            }
            
        }
    }
}
