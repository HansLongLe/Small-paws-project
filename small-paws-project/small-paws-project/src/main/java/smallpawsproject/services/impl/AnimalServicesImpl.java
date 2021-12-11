package smallpawsproject.services.impl;

import net.minidev.json.JSONArray;
import net.minidev.json.JSONObject;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import smallpawsproject.model.Animal;
import smallpawsproject.rmi.ClientFactory;
import smallpawsproject.rmi.ClientRMI;
import smallpawsproject.services.AnimalServices;
import java.rmi.RemoteException;

@Service
public class AnimalServicesImpl implements AnimalServices
{

  @Autowired
  private final ClientFactory clientFactory;

  private ClientRMI client;

  public AnimalServicesImpl() {

    clientFactory = new ClientFactory();
    client = clientFactory.getClient();

    try {
      client.connect();
    }catch (RemoteException e)
    {
      e.printStackTrace();
    }
  }

  @Override public void AddAnimal(Animal animal)
  {
    animal.setHealthNotes("Nothing to note about the animal's health");

    try
    {
      client.addAnimal(animal);
      System.out.println("Sending to server");
    }
    catch (RemoteException e)
    {
      e.printStackTrace();
    }
  }

  @Override public void updateAnimal(Animal animal)
  {
    try
    {
      client.updateAnimal(animal);
    }
    catch (RemoteException e)
    {
      e.printStackTrace();
    }
  }

  @Override
  public void setClient(ClientRMI clientRMI) {
    this.client = clientRMI;
  }

  @Override public JSONArray GetAnimals()
  {
    var animalsAsJson = new JSONArray();

    try {

    var listOfAnimals = client.getAnimals();

      for (var animal: listOfAnimals)
      {
       var jsonObject = new JSONObject();
       jsonObject.put("id", animal.getId());
       jsonObject.put("picture", animal.getPicture());
       jsonObject.put("animalType", animal.getAnimalType());
       jsonObject.put("age", animal.getAge());
       jsonObject.put("sex", animal.getSex());
       jsonObject.put("description", animal.getDescription());
       jsonObject.put("washed", animal.isWashed());
       jsonObject.put("fed", animal.isFed());
       jsonObject.put("vaccinated", animal.isVaccinated());
       jsonObject.put("healthNotes", animal.getHealthNotes());
       animalsAsJson.add(jsonObject);
      }

    } catch (RemoteException e) {
      e.printStackTrace();
    }
    return animalsAsJson;
  }
}
