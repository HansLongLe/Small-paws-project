using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Authentication;
using Client.Model;
using Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Client.Pages
{
    public class AdoptRequestListRazor : ComponentBase
    {
        protected IList<AdoptRequest> AdoptRequests{ get; set; }
        [Inject] protected IAnimalService AnimalService { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        protected string [] StatusText;

        protected override async Task OnInitializedAsync()
        {
            AdoptRequests = await AnimalService.GetAdoptRequestsAsync();
            StatusText = new string[AdoptRequests.Count];
            for (int i = 0; i < AdoptRequests.Count; i++)
            {
                if (AdoptRequests[i].Approved == null)
                {
                    StatusText[i] = "Awaiting";
                }
                else if (AdoptRequests[i].Approved == true)
                {
                    StatusText[i] = "Approved";
                }
                else
                {
                    StatusText[i] = "Rejected";
                }
                
            }
        }

        protected async Task AcceptRequest(AdoptRequest adoptRequest)
        {
            adoptRequest.Approved = true;
            adoptRequest.VeterinarianId = 
                ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().Id;
            await AnimalService.UpdateAdoptRequest(adoptRequest);
            NavigationManager.NavigateTo("AdoptRequestList");
        }

        protected async Task RejectRequest(AdoptRequest adoptRequest)
        {
            adoptRequest.Approved = false;
            adoptRequest.VeterinarianId = 
                ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().Id;
            await AnimalService.UpdateAdoptRequest(adoptRequest);
            NavigationManager.NavigateTo("AdoptRequestList");
        }


    }
}