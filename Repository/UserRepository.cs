using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Repository
{
    public class UserRepository: IUserRepository
    {
        public void AddUser(User user)
        {
            // Check that username does not already exist before adding it to database
            if(!UserService.Users.Any(u => u.Username == user.Username))
            {
                UserService.AddUser(user);
            }
        }
    }
}