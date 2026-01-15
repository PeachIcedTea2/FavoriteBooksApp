using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Services
{
    public static class UserService
    {
        static List<User> Users { get; }
        static UserService()
        {
            Users = new List<User>
            {
                new User { Id = 1, Username = "mouse", FavoriteBook = "A Court of Thorns and Roses"},
                new User { Id = 2, Username = "bunny", FavoriteBook = "A Game of Thrones"},
                new User { Id = 3, Username = "cat", FavoriteBook = "A Game of Thrones"}
            };
        }

        public static List<User> GetAll() => Users;

        // TODO: Pass in book by id? 
        public static void Update(User user, Book book)
        {
            var userToUpdate = Users.FirstOrDefault(u => u.Id == user.Id);
            if(userToUpdate != null)
            {
                userToUpdate.FavoriteBook = book.Title;
            }
        }
    }
}