using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Repository
{
    public interface IUserRepository
    {
        public int AddUser(string username);
        public bool AddBookToUser(User user, string title);
        public User GetUserById(int id);
        public int GetIdByName(string username);
    }
}