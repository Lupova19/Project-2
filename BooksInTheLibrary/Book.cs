using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInTheLibrary
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int CatalogNumber { get; set; }

        private List<Book> books;

        public Book()
        {
            books = new List<Book>();
        }


        public Book(string title, string author, string publisher, int year, int catalogNumber)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Year = year;
            this.CatalogNumber = catalogNumber;
        }

        //а
        public void AddBook(string title, string author, string publisher, int year, int catalogNumber)
        {
            Book book = new Book(title, author, publisher, year, catalogNumber);
            books.Add(book);
            Console.WriteLine("Книгата е добавена успешно!");
        }
        //б
        public void DisplayBooks()
        {
            foreach (Book item in books)
            {
                Console.WriteLine($"Заглавие:{item.Title} | Автор:{item.Author} | Издател:{item.Publisher} | Година:{item.Year} | Номер в каталога:{item.CatalogNumber}");
            }
        }
        //в
        public void SearchByTitle(string title)
        {
            foreach (Book item in books)
            {
                if (item.Title == title)
                {
                    Console.WriteLine($"Заглавие: {item.Title}");
                    Console.WriteLine($"Автор: {item.Author}");
                    Console.WriteLine($"Издател: {item.Publisher}");
                    Console.WriteLine($"Година: {item.Year}");
                    Console.WriteLine($"Номер в каталога: {item.CatalogNumber}");
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("Няма въведени книги с това заглавие!");
        }
        // г
        public void SearchByAuthor(string author)
        {
            foreach (Book item in books)
            {
                if (item.Author == author)
                {
                    Console.WriteLine($"Заглавие: {item.Title}");
                    Console.WriteLine($"Автор: {item.Author}");
                    Console.WriteLine($"Издател: {item.Publisher}");
                    Console.WriteLine($"Година: {item.Year}");
                    Console.WriteLine($"Номер в каталога: {item.CatalogNumber}");
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("Няма въведени книги с този автор!");
        }
        //д
        public void UpdateInformationAboutBook(string title)
        {
            foreach (Book item in books)
            {
                if (item.Title == title)
                {
                    Console.Write("Въведи ново заглавие: ");
                    item.Title = Console.ReadLine();
                    Console.Write("Въведи нов автор: ");
                    item.Author = Console.ReadLine();
                    Console.Write("Въведи нов издател: ");
                    item.Publisher = Console.ReadLine();
                    Console.Write("Въведи нова година: ");
                    item.Year = int.Parse(Console.ReadLine());
                    Console.Write("Въведи нов номер в каталога: ");
                    item.CatalogNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Книгата е актуализирана успешно!");
                    return;
                }
            }
            Console.WriteLine("Няма въведени книги с това заглавие!");
        }
        //е
        public void DeleteBook(string title)
        {
            int countOfBook = books.Count;
            books.RemoveAll(book => book.Title == title);

            if (books.Count < countOfBook)
            {
                Console.WriteLine("Книгата е изтрита успешно!");
            }
            else
            {
                Console.WriteLine("Няма въведени книги с това заглавие!");
            }
        }
        //ж
        public double AverageYear()
        {
            if (books.Count == 0)
            {
                return 0;
            }

            double averageYear = books.Average(book => book.Year);
            return averageYear;
        }
        //з
        public Book OldestBook()
        {
            if (books.Count == 0)
            {
                return null;
            }

            Book oldestBook = books.OrderBy(book => book.Year).First();
            return oldestBook;
        }
        //и
        public Book NewestBookByAuthor(string author)
        {
            Book newestBook = books.Where(book => book.Author == author)
                                   .OrderByDescending(book => book.Year)
                                   .FirstOrDefault();
            return newestBook;
        }
        //й
        public void SortByAuthorAndCatalogNumber()
        {
            books = books.OrderBy(book => book.Author)
                         .ThenBy(book => book.CatalogNumber)
                         .ToList();
        }
    }
}
