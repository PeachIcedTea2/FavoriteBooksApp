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
                new Book { Id = 1, Title = "A Game of Thrones", Author = "George R. R. Martin", ImageName="GOT", FavoritedBy=["bunny", "cat"], TotalFavorites=2},
                new Book { Id = 2, Title = "A Court of Thorns and Roses", Author = "Sarah J. Maas", ImageName="ACOTAR", FavoritedBy = ["mouse"], TotalFavorites = 1},
                new Book { Id = 3, Title = "Throne of Glass", Author = "Sarah J. Maas", ImageName = "TOG"},
                new Book { Id = 4, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", ImageName = "Harry"},
                new Book { Id = 5, Title = "The Lightning Thief", Author = "Rick Riordan", ImageName = "Lightning"},
                new Book { Id = 6, Title = "The Duke and I", Author = "Julia Quinn", ImageName = "Bridgerton"},
                new Book { Id = 7, Title = "Twilight", Author = "Stephanie Meyer", ImageName = "Twilight"},
                new Book { Id = 8, Title = "The Hunger Games", Author = "Suzanne Collins", ImageName = "HungerGames"},
                new Book { Id = 9, Title = "A Clash of Kings", Author = "George R. R. Martin", ImageName = "Clash"},
                new Book { Id = 10, Title = "A Court of Mist and Fury", Author = "Sarah J. Maas", ImageName = "ACOMAF"}
            };
        }

        public static List<Book> GetAll() => Books;

        public static Book GetBookById(int id) => Books.FirstOrDefault(u => u.Id == id);
    }
}