using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();
        public void AddBookToUser(string bookTitle, int userId);
        public Book GetFavoriteBookFromUser();
    }
}