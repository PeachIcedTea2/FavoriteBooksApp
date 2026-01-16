using FavoriteBooksApp.Models;
using FavoriteBooksApp.Repository;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Components.Pages
{
    public partial class Home 
    {
        private IBookRepository _bookRepository;

        public Home(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> Books { get; set; } = new List<Book>();

        public bool LoggingIn = false;

        protected async override Task OnInitializedAsync()
        {
            Books = BookService.Books;
        }

        private void Favorite(string bookTitle, int userId)
        {
            _bookRepository.AddBookToUser(bookTitle, userId);
        }
    }
}