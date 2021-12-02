package smallpawsproject.services;

import smallpawsproject.model.AdoptRequest;
import smallpawsproject.model.Animal;

import java.util.List;

public interface AnimalService {
    void addAnimal(Animal animal);
    List<Animal> getAnimals();
    void updateAnimal(Animal animal);
    void newAdoptRequest(AdoptRequest adoptRequest);
    List<AdoptRequest> getAdoptRequests();
    void updateAdoptRequest(AdoptRequest adoptRequest);
}
