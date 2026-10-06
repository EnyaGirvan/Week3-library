namespace Library
{
    class Book
    {
        private string title;  //Private field
        private string author;
        private string isbn;

        //Title property allows access
        //to the title private field
        public string Title
        {
            get { return title; } //Get method
            set { title = value; } //Set method
        }
        public string Author
        {
            get { return author; }
            set
            {
                //Checks if any charatcer in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }
        public string ISBN
        {
            get { return isbn; }
            set
            {
                //Checks that the incoming stirng is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
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
