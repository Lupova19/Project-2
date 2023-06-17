using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInTheLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book library = new Book();
            int command = 0;

            while (command != 11)
            {
                Console.WriteLine("1 - Добави книга");
                Console.WriteLine("2 - Извади цялата информация за книгите");
                Console.WriteLine("3 - Търсене на книга по заглавие");
                Console.WriteLine("4 - Търсене на книга по автор");
                Console.WriteLine("5 - Актуализиране на книга");
                Console.WriteLine("6 - Изтриване на книга");
                Console.WriteLine("7 - Изчисляване на средната година на книгите");
                Console.WriteLine("8 - Извеждане на най-старата книга");
                Console.WriteLine("9 - Извеждане на най-новата книга от автор");
                Console.WriteLine("10 - Сортиране на книгите по автор и номер в каталога");
                Console.WriteLine("11 - Изход от програмата");
                Console.Write("Въведи команда: ");
                command = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (command)
                {

                    case 1:
                        Console.Write("Въведи заглавие: ");
                        string title = Console.ReadLine();
                        Console.Write("Въведи автор: ");
                        string author = Console.ReadLine();
                        Console.Write("Въведи издател: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Въведи година: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Въведи номер в каталога: ");
                        int catalogNumber = int.Parse(Console.ReadLine());
                        library.AddBook(title, author, publisher, year, catalogNumber);
                        Console.WriteLine();
                        break;

                    case 2:
                        library.DisplayBooks();
                        break;

                    case 3:
                        Console.Write("Въведи заглавие: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchByTitle(searchTitle);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Въведи автор: ");
                        string searchAuthor = Console.ReadLine();
                        library.SearchByAuthor(searchAuthor);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Въведи заглавие на книгата за да се актуализира: ");
                        string updateTitle = Console.ReadLine();
                        library.UpdateInformationAboutBook(updateTitle);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Въведи заглавие на книгата за да се изтрие: ");
                        string deleteTitle = Console.ReadLine();
                        library.DeleteBook(deleteTitle);
                        Console.WriteLine();
                        break;

                    case 7:
                        double averageYear = library.AverageYear();
                        Console.WriteLine($"Средна година на книгите: {averageYear}");
                        Console.WriteLine();
                        break;

                    case 8:
                        Book oldestBook = library.OldestBook();
                        if (oldestBook != null)
                        {
                            Console.WriteLine($"Най-стара книга: {oldestBook.Title}");
                        }
                        else
                        {
                            Console.WriteLine("Няма въведени книги в библиотеката!");
                        }
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.Write("Въведи автор за да се изведе най-новата книга: ");
                        string authorNewestBook = Console.ReadLine();
                        Book newestBook = library.NewestBookByAuthor(authorNewestBook);
                        if (newestBook != null)
                        {
                            Console.WriteLine($"Най-новата книга от {authorNewestBook} е {newestBook.Title}");
                        }
                        else
                        {
                            Console.WriteLine($"Няма въведени книги от {authorNewestBook} в библиотеката!");
                        }
                        Console.WriteLine();
                        break;

                    case 10:
                        library.SortByAuthorAndCatalogNumber();
                        Console.WriteLine("Сортираните книги по автор и номер в каталога:");
                        library.DisplayBooks();
                        break;
                    case 11:
                        Console.WriteLine("Изход от програмата!");
                        break;
                }

            }
        }
    }
}
