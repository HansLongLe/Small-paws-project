using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Authentication;
using Client.Model;
using Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;

namespace Client.Pages
{
    public class ViewSpecificAnimalRazor : ComponentBase
    {
        [Parameter]
        public string Value { get; set; }

        private IList<Animal> Animals { get; set; }
        [Inject] protected IAnimalService AnimalService { get; set; }
        [Inject] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        protected string ShownImage;
        protected string AnimalType;
        protected int? Age;
        protected int? Id;
        private bool _washed;
        private bool _fed;
        private bool _vaccinated;
        protected string Description;
        protected string WashedIcon = "fas fa-times";
        protected string FedIcon = "fas fa-times";
        protected string VaccinatedIcon = "fas fa-times";

        protected string AnimalName;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var valueInt = Convert.ToInt32(Value);
                Console.WriteLine(valueInt + "!!!!!!!!!!!!");
                Animals = await AnimalService.GetAnimalsAsync();
                foreach (var animal in Animals)
                {
                    if (animal.Id != valueInt) continue;
                    ShownImage = $"data:image/jpg;base64,{Convert.ToBase64String(animal.Picture)}";
                    AnimalType = animal.AnimalType;
                    Age = animal.Age;
                    Id = animal.Id;
                    _washed = animal.Washed;
                    WashedIcon = _washed ? "fas fa-check" : "fas fa-times";
                
                    _fed = animal.Fed;
                
                    FedIcon = _fed ? "fas fa-check" : "fas fa-times";
                
                    _vaccinated = animal.Vaccinated;
                
                    VaccinatedIcon = _vaccinated ? "fas fa-check" : "fas fa-times";
                
                    Description = animal.Description;
                }

                

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        protected async Task AdoptAnimal()
        {
            var user = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser();
            var animalId = Convert.ToInt32(Value);
            var tempAnimal = new Animal();

            foreach (var animal in Animals)
            {
                if (animal.Id == animalId)
                {
                    tempAnimal = animal;
                }
            }
            var adoptRequest = new AdoptRequest
            {
                UserId = user.Id,
                AnimalId = tempAnimal.Id,
                Date = DateTime.Now,
                AnimalType = tempAnimal.AnimalType,
                AnimalName = AnimalName,
                Approved = null
            };
            await AnimalService.AdoptAnimal(adoptRequest);
            
        }
        
        protected async Task Enter(KeyboardEventArgs e)
        {
            if (e.Code is "Enter" or "NumpadEnter")
            {
                await AdoptAnimal();
            }
        }
        
    } 
}