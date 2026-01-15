using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Components.Pages
{
    public partial class Home 
    {
        public List<Book> Books { get; set; } = new List<Book>();

        protected async override Task OnInitializedAsync()
        {
            Books = BookService.Books;
        }
    }
}