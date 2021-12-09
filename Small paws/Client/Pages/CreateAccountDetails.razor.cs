﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Client.Data.Registration;
using Client.Model;
using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    public abstract class CreateAccountDetailsRazor : ComponentBase
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private EndUser EndUser { get; set; }
        [Inject] private IUserCreateAccountService UserCreateAccountService { get; set; }

        protected string FirstName;
        protected string LastName;
        protected int? Age;
        protected string Sex;
        protected string FamilyStatus;
        protected int? AverageIncome;
        protected string Address;
        protected int? ZipCode;
        protected string JobTitle;
        protected int? Id;

        protected string IdError ="";
        protected string AvgIncomeError="";
        protected string AgeError="";
        protected string Error = "";
        // ReSharper disable once UnusedMember.Global
        protected string FirstNameError = "";
        // ReSharper disable once UnusedMember.Global
        protected string LastNameError = "";
        // ReSharper disable once UnusedMember.Global
        protected string FamilyStatusNameError = "";

        protected async Task LoadViewAnimals()
        {
            Debug.Assert(Age != null, nameof(Age) + " != null");
            Debug.Assert(AverageIncome != null, nameof(AverageIncome) + " != null");
            Debug.Assert(ZipCode != null, nameof(ZipCode) + " != null");
            Debug.Assert(Id != null, nameof(Id) + " != null");
            var petOwner = new PetOwner
            {
                Email = EndUser.Email,
                UserName = EndUser.UserName,
                Password = EndUser.Password,
                FirstName = FirstName,
                LastName = LastName,
                Age = (int) Age,
                Sex = Sex,
                FamilyStatus = FamilyStatus,
                AvgIncome = (int) AverageIncome,
                Address = Address,
                ZipCode = (int) ZipCode,
                JobTitle = JobTitle,
                Id = (int) Id
            };
            Console.WriteLine(petOwner.Id);
            if (Age < 18 || Age > 130)
            {
                AgeError = "Age is either too low or too high";
            }
            else if (AverageIncome < 0)
            {
                AvgIncomeError = "Average Income cannot be less than 0";
            }
            else if (Id.ToString().Length < 4 || Id.ToString().Length > 9 || Id.ToString()[0] == 0)
            {
                IdError = "Id cannot be less than 4 digits or bigger than 9 digits, and it cannot start with 0";
                
            }
            else if (Id.ToString().Length < 4 || Id.ToString().Length > 9 || Id.ToString()[0] == 0)
            {
                IdError = "Id cannot be less than 4 digits or bigger than 9 digits, and it cannot start with 0";
                
            }

            else if (await UserCreateAccountService.CreateUserAsync(petOwner) == 201)
            {
                NavigationManager.NavigateTo("");
            }
            else
            {
                Error = UserCreateAccountService.CreateUserAsync(petOwner).Result + " Error message";
            }

        }
        
        
        protected void LoadLogIn()
        {
            NavigationManager.NavigateTo("");
        }
    }
}