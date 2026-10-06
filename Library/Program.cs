using Library;

class Program
{
    static void Main(string[] args)
    {
        //Create a new instance (object) of the Book class
        //Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#", "Steve Jobs", "7654321");
        book.DisplayInfo();
        book1.DisplayInfo();

        //Create new instances of the Member class
        //These new members are created using the
        //Member constructor in the member class
        Member member = new Member(1, "John Smith", "123 Main St", "555-1234"); 
        Member member = new Member(2, "Jane Doe", "456 Elm St", "555-5678");

        Console.WriteLine("Current library members:");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}
