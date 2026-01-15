using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Repository
{
    public interface iBookRepository
    {
        public List<Book> GetBooks();
        public void AddBookToUser();
        public Book GetFavoriteBookFromUser();
    }
}