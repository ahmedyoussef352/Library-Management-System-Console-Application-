using Oop_LibrarySystem1.Entities;
using Oop_LibrarySystem1.Entities.Users;
using Oop_LibrarySystem1.Helper;

namespace Oop_LibrarySystem1.Service;

public class LibraryService
{
    private readonly Library _library;

    public LibraryService(Library library)
    {
        _library = library;
    }

    public void AddBookProcess(Librarian librarian)
    {
        string title = ThemeHelper.ReadNonEmptyString("Enter Book Title: ");
        string author = ThemeHelper.ReadNonEmptyString("Enter Book Author: ");
        int year = ThemeHelper.ReadInteger("Enter Puplished Year: ");

        var book = new Book(title, author, year);
        librarian.AddBook(book, _library);

        ThemeHelper.PrintSuccess($"Book '{title}' added successfully!");
    }

    public void RemoveBookProcess(Librarian librarian)
    {
        string title = ThemeHelper.ReadNonEmptyString("Enter Book Title: ");
        librarian.RemoveBook(title, _library);
    }
    public void DisplayAviableBooksProccess(Librarian librarian)
    {
        librarian.DisplayBooks(_library);
    }
    public void BorrowBookProcess(LibraryUser libraryUser)
    {
        string title = ThemeHelper.ReadNonEmptyString("Enter Book Title You need Borrow It: ");
        libraryUser.BorrowBook(title, _library);
    }
    public void ReturnBookProcess(LibraryUser libraryUser)
    {
        string title = ThemeHelper.ReadNonEmptyString("Enter Book Title You need Return It: ");
        libraryUser.ReturnBook(title, _library);
    }
    public void DisplayAviableBooksProccess(LibraryUser libraryUser)
    {
        libraryUser.DisplayBooks(_library);
    }
}
