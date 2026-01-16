namespace FavoriteBooksApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FavoriteBook { get; set; } = string.Empty;
    }
}