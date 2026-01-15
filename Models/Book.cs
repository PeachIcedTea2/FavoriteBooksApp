namespace FavoriteBooksApp.Models
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public List<User> FavoritedBy { get; set; } = new List<User>();
        public string ImagePath { get; set; } = string.Empty; 
    }
}