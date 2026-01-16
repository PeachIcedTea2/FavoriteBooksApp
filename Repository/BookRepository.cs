using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Repository
{
    public class BookRepository : IBookRepository
    {
        public void AddBookToUser(string bookTitle, int userId)
        {
            var user = UserService.GetUserById(userId);
            user.FavoriteBook = bookTitle;
        }

        public List<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetFavoriteBookFromUser()
        {
            throw new NotImplementedException();
        }
    }
}