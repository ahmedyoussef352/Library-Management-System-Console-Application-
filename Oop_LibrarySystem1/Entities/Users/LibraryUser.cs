namespace Oop_LibrarySystem1.Entities.Users;

public class LibraryUser : User
{
    public LibraryCard Card { get; private set; }
    public LibraryUser(string name, LibraryCard card) : base(name)
    {
        Card = card;
    }


    public void BorrowBook(string title, Library library)
    {
        library.BorrowBook(title);
    }
    public void ReturnBook(string title, Library library)
    {
        library.ReturnBook(title);
    }
    public override void DisplayBooks(Library library)
    {
        library.Display();
    }
}
