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
            // Only add if the user does not already have a favorite book
            if(user.FavoriteBook == string.Empty)
            {
                user.FavoriteBook = book.Title ?? "";
                book.FavoritedBy.Add(user.Username);
                book.TotalFavorites++;
            }
        }

        public List<Book> GetBooks()
        {
            return BookService.Books;
        }
    }
}