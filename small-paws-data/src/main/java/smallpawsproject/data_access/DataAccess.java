package smallpawsproject.data_access;

import smallpawsproject.model.AdoptRequest;
import smallpawsproject.model.EndUser;
import smallpawsproject.model.Animal;
import smallpawsproject.model.PetOwner;

import java.util.List;

public interface DataAccess
{
  void registerPetOwner(PetOwner petOwner);
  List<PetOwner> getPetOwners();
  List<Animal> getAnimals();
  List<EndUser> getUsers();
  void addAnimal(Animal animal);
  Animal updateAnimal(Animal animal);
  void newAdoptRequest(AdoptRequest adoptRequest);
  List<AdoptRequest> getAdoptRequests();
}
