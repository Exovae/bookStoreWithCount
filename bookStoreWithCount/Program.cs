using bookStore;
using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        public book()
        {

        }

        public book(int Id, string Title, string Author)
        {
            _Id = Id;
            _Title = Title;
            _Author = Author;
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetTitle(string Title)
        {
            _Title = Title;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetAuthor(string Author)
        {
            _Author = Author;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }
    }
}

class myStore
{
    static void Main(string[] args)
    {
        book book1 = new book();
        book1.SetId(1);
        book1.SetTitle("The Great Gatsby");
        book1.SetAuthor("F. Scott Fitzgerald");
        book1.SetTrans();

        book book2 = new book();
        Console.WriteLine("Please enter the book ID: ");
        book2.SetId(int.Parse(Console.ReadLine()));
        Console.WriteLine("Please enter the book title: ");
        book2.SetTitle(Console.ReadLine());
        Console.WriteLine("Please enter the author name: ");
        book2.SetAuthor(Console.ReadLine());
        book2.SetTrans();

        book book3 = new book(3, "Pride and Prejudice", "Jane Austen");
        book3.SetTrans();

        Console.WriteLine("Please enter the book ID: ");
        int tempID = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the book title: ");
        string tempTitle = Console.ReadLine();
        Console.WriteLine("Please enter the author name: ");
        string tempAuthor = Console.ReadLine();
        book book4 = new book(tempID, tempTitle, tempAuthor);
        book4.SetTrans();

        Console.WriteLine("The book store has " + book4.GetTrans() + " new books");
        displayBooks(book1);
        displayBooks(book2);
        displayBooks(book3);
        displayBooks(book4);
    }

    static void displayBooks(book book)
    {
        Console.WriteLine("Here's the book information");
        Console.WriteLine($"Book ID: {book.GetId()}");
        Console.WriteLine($"Book Title: {book.GetTitle()}");
        Console.WriteLine($"Author: {book.GetAuthor()}");
    }
}
