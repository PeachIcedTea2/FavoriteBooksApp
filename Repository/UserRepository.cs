using System.Text;
using FavoriteBooksApp.Models;
using FavoriteBooksApp.Services;

namespace FavoriteBooksApp.Repository
{
    public class UserRepository: IUserRepository
    {
        // Registers the user if they are new and returns their Id
        public int AddUser(string username)
        {
            if(!UserService.Users.Any(u => u.Username == username))
            {
                return UserService.AddUser(username);
            }
            else
            {
                return GetIdByName(username);
            }
        }

        // Returns the id for an existing username
        public int GetIdByName(string name)
        {
            var user = UserService.GetUserByUsername(name);
            return user.Id;
        }

        // Adds book to user and returns true if successful
        public bool AddBookToUser(User user, string title)
        {
            // Only add if the user does not already have a favorite book
            if(user.FavoriteBook == string.Empty)
            {
                user.FavoriteBook = title ?? "";
                return true;
            }
            
            return false;
        }

        public User GetUserById(int id)
        {
            return UserService.GetUserById(id);
        }
    }
}