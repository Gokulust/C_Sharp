using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace Assessment_2_Book_Management_System
{
    internal class Program
    {
        enum Option
        {
            AddBook=1,
            ViewAllBooks,
            SearchBookByAuthor,
            RemoveAllBooks,
            Exit
        }
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Amacon Book Management System");
            do
            {
                try
                {
                    Console.Write("\n1.Add a book \n2.View all books available in bookstore \n3.Search books by author \n4.Remove all books \n5.Exit \n");
                    Console.Write("Select an option :");
                    if (int.TryParse(Console.ReadLine(), out int userChoice))
                    {
                        if (userChoice == (int)Option.AddBook)
                        {
                            Console.Write("Enter the Book Title: ");
                            string title = Console.ReadLine();
                            Validation.ValidString(title,"Title");
                            Console.Write("Enter the name of the author: ");
                            string author = Console.ReadLine();
                            Validation.ValidString(author,"Author Name");
                            Console.Write("Enter the rating ot the book: ");
                            string stringRating = Console.ReadLine();
                            Validation.ValidDouble(stringRating, "Rating");
                            double rating = Convert.ToDouble(stringRating);
                            Console.Write("Enter the price of the book: ");
                            string stringPrice = Console.ReadLine();
                            Validation.ValidDouble(stringPrice, "Price");
                            double price = Convert.ToDouble(stringPrice);
                            Book book = new Book() { Title = title, Author = author, Rating = rating, Price = price };
                            BooksManagement.Addbook(book);
                            Console.WriteLine("Book added successfully");

                        }
                        else if(userChoice==(int)Option.ViewAllBooks)
                        {
                            DisplayBooks(BooksManagement.ViewAllBooks());
                        }
                        else if(userChoice== (int)Option.SearchBookByAuthor)
                        {
                            Console.Write("enter the author name: ");
                            string author = Console.ReadLine();
                            Validation.ValidString(author,"Author Name");
                            DisplayBooks(BooksManagement.SearchBooksByAuthour(author));
                        }
                        else if(userChoice==(int)Option.RemoveAllBooks)
                        {
                            BooksManagement.RemoveAllBooks();
                            Console.WriteLine("All books removed successfully");
                        }
                        else if(userChoice==(int)Option.Exit)
                        {
                            choice = 1;
                        }
                        else
                        {
                            Console.WriteLine("invalid option");
                        }
                    }
                    else
                    {
                        throw new CustomException("Invalid Option");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }while(choice == 0);
        }
        public static void DisplayBooks(List<Book> bookList)
        {
            if(bookList.Any())
            {
                foreach(Book book in bookList)
                {
                    Console.WriteLine($"Book Id = {book.Id},Book Title = {book.Title},Book Author = {book.Author}, Book Rating = {book.Rating}, Book Price = {book.Price}");
                }
            }
            else
            {
                throw new CustomException("No Book Records Found");
            }
        }
    }
}