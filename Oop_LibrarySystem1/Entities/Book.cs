using Oop_LibrarySystem1.Contract;
using Oop_LibrarySystem1.Enum;

namespace Oop_LibrarySystem1.Entities;

public class Book : IDisplay
{
    public string Title { get; private set; } = null!;
    public string Author { get; private set; } = null!;
    public int Year { get; private set; }

    public BookType Type { get; set; }
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        Type = BookType.Available;
    }

    public void Display()
    {
        Console.WriteLine($"Book Title: {Title} | Author: {Author} | Year: {Year} | Type: {Type}");
    }
}