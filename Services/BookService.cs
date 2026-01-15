using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Services
{
    public static class BookService
    {
        public static List<Book> Books { get; }
        static BookService()
        {
            Books = new List<Book>
            {
                new Book { Title = "A Game of Thrones", Author = "George R. R. Martin"},
                new Book { Title = "A Court of Thorns and Roses", Author = "Sarah J. Maas"},
                new Book { Title = "Throne of Glass", Author = "Sarah J. Maas"},
                new Book { Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling"},
                new Book { Title = "The Lightning Thief", Author = "Rick Riordan"},
                new Book { Title = "The Duke and I", Author = "Julia Quinn"},
                new Book { Title = "Twilight", Author = "Stephanie Meyer"},
                new Book { Title = "The Hunger Games", Author = "Suzanne Collins"},
                new Book { Title = "The Lost Hero", Author = "Rick Riordan"},
                new Book { Title = "A Clash of Kings", Author = "George R. R. Martin"},
                new Book { Title = "A Court of Mist and Fury", Author = "Sarah J. Maas"}
            };
        }

        public static List<Book> GetAll() => Books;
    }
}