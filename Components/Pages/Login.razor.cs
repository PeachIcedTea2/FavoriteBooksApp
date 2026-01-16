using FavoriteBooksApp.Models;
using FavoriteBooksApp.Repository;
using FavoriteBooksApp.State;
using Microsoft.AspNetCore.Components;

namespace FavoriteBooksApp.Components.Pages
{
    public partial class Login
    {
        private IUserRepository _userRepository;

        public Login(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected ApplicationState ApplicationState { get; set; }

        [SupplyParameterFromForm]
        public User User { get; set; }

        public bool LoggingIn { get; set;} = false;
        public bool CloseModal { get; set;} = false;

        protected override void OnInitialized()
        {
            User ??= new User();
        }

        private void OnSubmit()
        {
            var id = _userRepository.AddUser(User.Username);
            ApplicationState.UserName = User.Username;
            ApplicationState.LoggedIn = true;
            ApplicationState.UserId = id;
        }

        private void Logout()
        {
            ApplicationState.UserName = "";
            ApplicationState.LoggedIn = false;
            ApplicationState.UserId = 0;
        }

        private void Cancel()
        {
            CloseModal = true;
        }

        private void LoginClicked()
        {
            LoggingIn = true;
            CloseModal = false;
        }
    }
}