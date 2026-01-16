using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Repository
{
    public class BookRepository : IBookRepository
    {
        public void AddUserToBook(Book book, string username)
        {
            book.FavoritedBy.Add(username);
            book.TotalFavorites++;
        }

        public List<Book> GetBooks()
        {
            return BookService.Books;
        }

        public Book GetBookById(int id)
        {
            return BookService.GetBookById(id);
        }
    }
}