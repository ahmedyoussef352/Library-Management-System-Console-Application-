namespace Oop_LibrarySystem1.Helper;

public static class ConsoleHelper
{
    public static void ShowMainMenu()
    {
        ThemeHelper.PrintHeader("LIBRARY SYSTEM - MAIN MENU");
        ThemeHelper.PrintOption("[L] Librarian Panel");
        ThemeHelper.PrintOption("[R] Regular User Panel");
        Console.WriteLine(new string('-', 40));
        ThemeHelper.PrintOption("[E] Exit Program");
        Console.WriteLine(new string('=', 40));
        Console.Write("Enter your choice: ");
    }

    public static void ShowLibrarianMenu()
    {
        ThemeHelper.PrintSectionTitle("LIBRARIAN PANEL");
        ThemeHelper.PrintOption("[A] Add Book");
        ThemeHelper.PrintOption("[R] Remove Book");
        ThemeHelper.PrintOption("[D] Display Available Books");
        Console.WriteLine(new string('-', 40));
        ThemeHelper.PrintOption("[B] Back to Main Menu");
        Console.WriteLine(new string('=', 40));
        Console.Write("Enter your choice: ");
    }

    public static void ShowUserMenu()
    {
        ThemeHelper.PrintSectionTitle("USER PANEL");
        ThemeHelper.PrintOption("[B] Borrow Book");
        ThemeHelper.PrintOption("[R] Return Book");
        ThemeHelper.PrintOption("[D] Display Available Books");
        Console.WriteLine(new string('-', 40));
        ThemeHelper.PrintOption("[M] Back to Main Menu");
        Console.WriteLine(new string('=', 40));
        Console.Write("Enter your choice: ");
    }

    public static char ReadChoice()
    {
        string input = Console.ReadLine()?.Trim().ToUpper()!;
        return string.IsNullOrEmpty(input) ? '\0' : input[0];
    }
}