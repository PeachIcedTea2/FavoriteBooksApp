using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.State
{
    public class ApplicationState
    {
        public bool LoggedIn { get; set; } = false;
        public string UserName { get; set; } = string.Empty;
    }
}