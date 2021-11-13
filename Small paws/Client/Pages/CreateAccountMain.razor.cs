using Client.Model;
using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    public class CreateAccountMainRazor : ComponentBase
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject]
        private EndUser User { get; set; }

        protected string Username { get; set; }
        protected string Password { get; set; }

        // public string Email { get; protected set; }
        protected string PasswordConfirmation { get; set; }

        protected void LoadLogIn()
        {
            NavigationManager.NavigateTo("");
        }
        protected void LoadCreateAccountDetails()
        {
            User.Username = Username;
            User.Password = Password;
            if (Password.Equals(PasswordConfirmation))
            {
                NavigationManager.NavigateTo("CreateAccountDetails");
            }
        }
    }
}