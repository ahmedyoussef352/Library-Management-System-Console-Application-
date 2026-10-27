using Oop_LibrarySystem1.Entities;
using Oop_LibrarySystem1.Entities.Users;
using Oop_LibrarySystem1.Helper;
using Oop_LibrarySystem1.Service;

namespace Oop_LibrarySystem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("My Library");
            LibraryService libraryService = new LibraryService(library);
            bool running = true;

            // Loop رئيسية للتنقل بين الأدوار
            while (running)
            {
                ConsoleHelper.ShowMainMenu();
                char userType = ConsoleHelper.ReadChoice();
                switch (userType)
                {
                    case 'L':
                        HandelLibrarian(library, libraryService);
                        break;

                    case 'R':
                        HandelLibraryUser(library, libraryService);
                        break;

                    case 'E':
                        ThemeHelper.PrintSuccess("Thank you for using the Library System! Goodbye 👋");
                        running = false;
                        break;

                    default:
                        ThemeHelper.PrintError("❌ Invalid input. Please enter 'L', 'R', or 'E'.");
                        break;
                }
            }

            //  int year = ConsoleHelper.ReadInteger("Enter publication year: ");



        }

        public static void HandelLibraryUser(Library library, LibraryService libraryService)
        {
            var libraryCard1 = new LibraryCard(1234567890);
            var libraryUser1 = new LibraryUser("Jane Smith", libraryCard1);
            ThemeHelper.PrintHeader($"Welcome, {libraryUser1.Name}!");
            bool inUserMenu = true;
            while (inUserMenu)
            {
                ConsoleHelper.ShowUserMenu();
                char choice = ConsoleHelper.ReadChoice();
                switch (choice)
                {
                    case 'B':
                        libraryService.BorrowBookProcess(libraryUser1);
                        break;
                    case 'R':
                        libraryService.ReturnBookProcess(libraryUser1);
                        break;

                    case 'D':
                        libraryService.DisplayAviableBooksProccess(libraryUser1);
                        break;
                    case 'M':
                        inUserMenu = false; // يخرج ويرجع للقائمة الرئيسية
                        break;

                    default:
                        Console.WriteLine("❌ Invalid choice!");
                        break;
                }
            }
        }
        public static void HandelLibrarian(Library library, LibraryService libraryService)
        {
            var librarian1 = new Librarian("John Doe");
            ThemeHelper.PrintHeader($"Welcome, {librarian1.Name}!");
            bool inLibrarianMenu = true;
            while (inLibrarianMenu)
            {
                ConsoleHelper.ShowLibrarianMenu();
                char choice = ConsoleHelper.ReadChoice();
                switch (choice)
                {
                    case 'A':
                        libraryService.AddBookProcess(librarian1);
                        break;
                    case 'R':
                        libraryService.RemoveBookProcess(librarian1);
                        break;
                    case 'D':
                        libraryService.DisplayAviableBooksProccess(librarian1);
                        break;
                    case 'B':
                        inLibrarianMenu = false; // يخرج ويرجع للقائمة الرئيسية
                        break;

                    default:
                        ThemeHelper.PrintError("❌ Invalid choice!");
                        break;
                }
            }
        }
    }


}
