using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Model;
using Client.Services;
using Microsoft.AspNetCore.Components;
namespace Client.Pages
{
    public class AdoptRequestListRazor : ComponentBase
    {
        protected IList<AdoptRequest> AdoptRequests{ get; set; }
        [Inject] protected IAnimalService AnimalService { get; set; }

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

        protected async Task AcceptRequest()
        {
            
        }

        protected async Task RejectRequest()
        {
            
        }


    }
}