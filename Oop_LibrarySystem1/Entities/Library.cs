using Oop_LibrarySystem1.Contract;
using Oop_LibrarySystem1.Enum;

namespace Oop_LibrarySystem1.Entities;

public class Library(string name) : IDisplay
{
    public string Name { get; set; } = name;

    private readonly List<Book> _books = [];
    public IReadOnlyList<Book> Books => _books;
    private readonly List<Book> _borrowedBooks = [];

    public IReadOnlyList<Book> BorrowedBooks => _borrowedBooks;

    public void AddBook(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));
        _books.Add(book);
    }
    public void RemoveBook(string title)
    {
        var bookToRemove = _books.FirstOrDefault(b => string.Equals(b.Title, title, StringComparison.OrdinalIgnoreCase));
        if (bookToRemove == null)
        {
            Console.WriteLine($"❌ Book with title '{title}' was not found.");
            return;
        }
        _books.Remove(bookToRemove!);
        Console.WriteLine($"Book removed: {bookToRemove?.Title} Successfully!✅");
    }

    public void BorrowBook(string bookTitle)
    {
        var bookToBorrow = _books.FirstOrDefault(b => string.Equals(b.Title, bookTitle, StringComparison.OrdinalIgnoreCase));
        if (bookToBorrow == null)
        {
            Console.WriteLine($"❌ Book with title '{bookTitle}' was not found.");
            return;
        }
        _borrowedBooks.Add(bookToBorrow);
        _books.Remove(bookToBorrow);
        bookToBorrow.Type = BookType.Borrowed;
        Console.WriteLine($"Book borrowed: {bookToBorrow?.Title} Successfully! ✅");
    }

    public void ReturnBook(string title)
    {
        var bookToReturn = _borrowedBooks.FirstOrDefault(b => string.Equals(b.Title, title, StringComparison.OrdinalIgnoreCase));
        if (bookToReturn == null)
        {
            Console.WriteLine($"❌ Book with title '{title}' was not found.");
            return;
        }
        _borrowedBooks.Remove(bookToReturn);
        _books.Add(bookToReturn);
        bookToReturn.Type = BookType.Available;
        Console.WriteLine($"Book returned: {bookToReturn?.Title} Successfully! ✅");
    }

    public void Display()
    {
        Console.WriteLine("Displaying Available Books:");
        foreach (var item in _books)
        {
            item.Display();
        }

    }
}
