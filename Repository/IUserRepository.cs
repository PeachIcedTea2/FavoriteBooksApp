using FavoriteBooksApp.Models;

namespace FavoriteBooksApp.Repository
{
    public interface IUserRepository
    {
        public void AddUser(User user);
    }
}