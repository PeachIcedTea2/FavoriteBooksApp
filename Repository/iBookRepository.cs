using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();
        public void AddUserToBook(Book book, string username);
        public Book GetBookById(int bookId);
    }
}