using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();
        public void AddBookToUser(int bookId, int userId);
    }
}