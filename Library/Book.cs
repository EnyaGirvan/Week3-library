using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    string Title;
    string Author;
    string ISBN;

    //Example of a constructuor that allows us to "construct" a new
    //Book object 
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        this.Title = bookTitle;
        this.Author = bookAuthor;
        this.ISBN = bookISBN;
    }

    void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

}
