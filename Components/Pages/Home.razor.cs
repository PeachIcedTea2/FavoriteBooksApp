using FavoriteBooksApp.Models;
using FavoriteBooksApp.Repository;

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
            Books = _bookRepository.GetBooks();
        }

        private void Favorite(int bookId, int userId)
        {
            if(applicationState.LoggedIn)
            {
                _bookRepository.AddBookToUser(bookId, userId);
            }
        }
    }
}