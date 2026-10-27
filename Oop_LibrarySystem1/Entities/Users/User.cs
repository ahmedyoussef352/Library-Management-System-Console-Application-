namespace Oop_LibrarySystem1.Entities.Users;

public abstract class User(string name)
{
    public string Name { get; protected set; } = name;
    public abstract void DisplayBooks(Library library);
}
