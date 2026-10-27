namespace Oop_LibrarySystem1.Entities.Users;

public class Librarian : User
{
    private int _Couter = 1;
    public int EmployeeNumber { get; private set; }
    public Librarian(string name) : base(name)
    {
        EmployeeNumber = _Couter++;
    }
    public void AddBook(Book book, Library library)
    {
        library.AddBook(book);
    }
    public void RemoveBook(string title, Library library)
    {
        library.RemoveBook(title);
    }

    public override void DisplayBooks(Library library)
    {
        library.Display();
    }
}
