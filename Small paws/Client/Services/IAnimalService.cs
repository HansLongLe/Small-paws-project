using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Services
{
    public interface IAnimalService
    {
        Task<IList<Animal>> GetAnimalsAsync();
        Task AddAnimalAsync(Animal animal);
        Task UpdateAnimal(Animal newAnimal);
        Task AdoptAnimal(AdoptRequest adoptRequest);
        
        Task<IList<AdoptRequest>> GetAdoptRequestsAsync();
    }
}