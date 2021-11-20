﻿using System.Threading.Tasks;
using Client.Data.Validation;
using Client.Model;
using Microsoft.AspNetCore.Components;



namespace Client.Pages
{
    public class LoginRazor : ComponentBase
    {
    [Inject] private NavigationManager NavigationManager { get; set; }
    [Inject] private IUserLogInService UserLogInService { get; set; }

    protected string Username;
    protected string Password;

    protected async Task LoadMainPage()
    {
        
        if (await UserLogInService.ValidateUserAsync(Username, Password) == 202)
        {
            NavigationManager.NavigateTo("ViewAnimals");    
        }

    }
    protected void LoadCreateAccount()
    {
        NavigationManager.NavigateTo("CreateAccountMain");
    }
    

    }
    

}