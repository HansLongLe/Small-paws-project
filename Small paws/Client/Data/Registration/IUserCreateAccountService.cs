using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data.Registration
{
    public interface IUserCreateAccountService
    {
        Task<int> CreateUserAsync(PetOwner petOwner);
        
        Task<int> checkUserName(string userName);
    }
}