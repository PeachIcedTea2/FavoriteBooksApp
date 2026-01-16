using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Repository
{
    public class BookRepository : IBookRepository
    {
        public void AddBookToUser(int bookId, int userId)
        {
            var user = UserService.GetUserById(userId);
            var book = BookService.GetBookById(bookId);
            user.FavoriteBook = book.Title ?? "";
            book.TotalFavorites++;
        }

        public List<Book> GetBooks()
        {
            return BookService.Books;
        }
    }
}