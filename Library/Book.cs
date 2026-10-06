namespace Library
{
    class Book
    {
        private string Title;  //Private field
        private string Author;
        private string ISBN;

        //Title property allows access
        //to the title private field
        public string Title
        {
            get { return Title; } //Get method
            set { Title = value; } //Set method
        }
        public string Author
        {
            get { return Author; }
            set { Author = value; }
        }
        oublic string ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        //Constructor to add a new book

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        //Method to display information about a book
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

    }
}
