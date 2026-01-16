namespace FavoriteBooksApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public List<string> FavoritedBy { get; set; } = new List<string>();
        public string ImageName { get; set; } = string.Empty; 
        public int TotalFavorites { get; set; }
    }
}