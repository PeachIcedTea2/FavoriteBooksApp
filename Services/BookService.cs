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
                new Book { Title = "A Game of Thrones", Author = "George R. R. Martin", ImageName="GOT", FavoritedBy=["mouse"], TotalFavorites=2},
                new Book { Title = "A Court of Thorns and Roses", Author = "Sarah J. Maas", ImageName="ACOTAR", FavoritedBy = ["bunny", "cat"], TotalFavorites = 1},
                new Book { Title = "Throne of Glass", Author = "Sarah J. Maas", ImageName = "TOG"},
                new Book { Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", ImageName = "Harry"},
                new Book { Title = "The Lightning Thief", Author = "Rick Riordan", ImageName = "Lightning"},
                new Book { Title = "The Duke and I", Author = "Julia Quinn", ImageName = "Bridgerton"},
                new Book { Title = "Twilight", Author = "Stephanie Meyer", ImageName = "Twilight"},
                new Book { Title = "The Hunger Games", Author = "Suzanne Collins", ImageName = "HungerGames"},
                new Book { Title = "A Clash of Kings", Author = "George R. R. Martin", ImageName = "Clash"},
                new Book { Title = "A Court of Mist and Fury", Author = "Sarah J. Maas", ImageName = "ACOMAF"}
            };
        }

        public static List<Book> GetAll() => Books;

        public static Book GetBookById(int id) => Books.FirstOrDefault(u => u.Id == id);
    }
}