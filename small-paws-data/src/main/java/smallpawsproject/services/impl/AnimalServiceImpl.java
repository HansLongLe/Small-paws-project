package smallpawsproject.services.impl;

import org.hibernate.Session;
import smallpawsproject.model.AdoptRequest;
import smallpawsproject.model.Animal;
import smallpawsproject.repositories.AdoptRequestRepository;
import smallpawsproject.repositories.AnimalRepository;
import smallpawsproject.services.AnimalService;

import java.util.List;

public class AnimalServiceImpl implements AnimalService {

    private final AnimalRepository animalRepository;
    private final AdoptRequestRepository adoptRequestRepository;
    public AnimalServiceImpl(AnimalRepository animalRepository, AdoptRequestRepository adoptRequestRepository) {
        this.animalRepository = animalRepository;
        this.adoptRequestRepository = adoptRequestRepository;
    }
    @Override public void addAnimal(Animal animal){
        animalRepository.save(animal);
    }

    @Override
    public List<Animal> getAnimals() {
        return animalRepository.findAll();
    }

    @Override
    public Animal updateAnimal(Animal animal) {
        Animal temp = animalRepository.getById(animal.getId());
        temp.set(animal.getPicture(),animal.getAge(), animal.getDescription(), animal.isWashed(), animal.isFed(), animal.isVaccinated());
        animalRepository.save(temp);
        return temp;


    }

    @Override
    public void newAdoptRequest(AdoptRequest adoptRequest) {
        adoptRequestRepository.save(adoptRequest);
    }

    @Override
    public List<AdoptRequest> getAdoptRequests() {
        return adoptRequestRepository.findAll();
    }
}
