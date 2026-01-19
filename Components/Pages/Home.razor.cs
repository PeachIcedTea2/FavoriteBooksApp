using FavoriteBooksApp.Models;
using FavoriteBooksApp.Repository;

namespace FavoriteBooksApp.Components.Pages
{
    public partial class Home 
    {
        private IBookRepository _bookRepository;

        private IUserRepository _userRepository;

        public Home(IBookRepository bookRepository, IUserRepository userRepository)
        {
            _bookRepository = bookRepository;
            _userRepository = userRepository;
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
                var book = _bookRepository.GetBookById(bookId);
                var user = _userRepository.GetUserById(userId);
                var success =_userRepository.AddBookToUser(user, book.Title);
                if(success)
                {
                    _bookRepository.AddUserToBook(book, user.Username);
                }
            }
        }
    }
}