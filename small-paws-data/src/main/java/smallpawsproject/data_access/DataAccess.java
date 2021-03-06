package smallpawsproject.data_access;

import smallpawsproject.model.*;
import smallpawsproject.services.ServiceFactory;

import java.util.List;

public interface DataAccess
{
  void registerPetOwner(PetOwner petOwner);
  List<PetOwner> getPetOwners();
  List<Animal> getAnimals();
  List<EndUser> getUsers();
  void addAnimal(Animal animal);
  void updateAnimal(Animal animal);
  List<AdoptionRequest> getAdoptionRequests();
  void makeNewRequest(AdoptionRequest adoptionRequest);
  void updateAdoptionRequest(AdoptionRequest adoptionRequest);
  void setServicefactory(ServiceFactory serviceFactory);
  void addCertificate(Certificate certificate);
  List<Certificate> getCertificates();


}
