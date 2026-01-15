using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Components.Pages
{
    public partial class Home 
    {
        public List<Book> Books { get; set; } = default!;

        protected async override Task OnInitializedAsync()
        {
            Books = BookService.Books;
        }
    }
}