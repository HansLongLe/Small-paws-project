package smallpawsproject.services;

import net.minidev.json.JSONArray;
import org.springframework.stereotype.Service;
import smallpawsproject.model.AdoptRequest;
import smallpawsproject.model.Animal;

import java.util.List;

@Service
public interface AnimalServices
{
  JSONArray GetAnimals();
  void AddAnimal(Animal animal);
  Animal updateAnimal(Animal animal);
  void newAdoptRequest(AdoptRequest adoptRequest);
  JSONArray getAdoptRequests();
}
