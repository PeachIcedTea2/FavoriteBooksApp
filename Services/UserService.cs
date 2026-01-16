using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Services
{
    public static class UserService
    {
        static int nextId = 4;
        public static List<User> Users { get; }
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

        public static User GetUserById(int id) => Users.FirstOrDefault(u => u.Id == id);

        public static User GetUserByUsername(string username) => Users.FirstOrDefault(u => u.Username == username);

        public static int AddUser(string username)
        {
            var user = new User()
            {
                Username = username,
                Id = nextId++
            };
            Users.Add(user);
            Console.WriteLine($"New user added Id: {user.Id}, username:{user.Username}, favorite book: {user.FavoriteBook}");
            return user.Id;
        }

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