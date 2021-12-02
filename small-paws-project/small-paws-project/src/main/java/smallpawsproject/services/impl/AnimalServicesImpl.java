package smallpawsproject.services.impl;

import net.minidev.json.JSONArray;
import net.minidev.json.JSONObject;
import net.minidev.json.parser.JSONParser;
import net.minidev.json.parser.ParseException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import smallpawsproject.model.AdoptRequest;
import smallpawsproject.model.Animal;
import smallpawsproject.rmi.ClientFactory;
import smallpawsproject.rmi.ClientRMI;
import smallpawsproject.services.AnimalServices;

import javax.servlet.http.HttpServletResponse;
import java.io.*;
import java.rmi.RemoteException;
import java.util.List;

@Service
public class AnimalServicesImpl implements AnimalServices
{

  @Autowired
  private final ClientFactory clientFactory;

  private final ClientRMI client;

  public AnimalServicesImpl(ClientFactory clientFactory) {

    this.clientFactory = clientFactory;
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
  public void newAdoptRequest(AdoptRequest adoptRequest)
  {
    try
    {
      client.newAdoptRequest(adoptRequest);
    }
    catch (RemoteException e)
    {
      e.printStackTrace();
    }
  }

  @Override
  public JSONArray getAdoptRequests() {
    var adoptRequestAsJson = new JSONArray();

    try {

      var listOfAdoptRequests = client.getAdoptRequests();

      for (var adoptRequest : listOfAdoptRequests)
      {
        var jsonObject = new JSONObject();
        jsonObject.put("requestId", adoptRequest.getRequestId());
        jsonObject.put("userId", adoptRequest.getUserId());
        jsonObject.put("animalId", adoptRequest.getAnimalId());
        jsonObject.put("date", adoptRequest.getDate());
        jsonObject.put("animalType", adoptRequest.getAnimalType());
        jsonObject.put("animalName", adoptRequest.getAnimalName() );
        jsonObject.put("veterinarianId", adoptRequest.getVeterinarianId());
        jsonObject.put("approved", adoptRequest.isApproved());
        adoptRequestAsJson.add(jsonObject);
      }

    } catch (RemoteException e) {
      e.printStackTrace();
    }
    return adoptRequestAsJson;

  }

  @Override
  public void updateAdoptRequest(AdoptRequest adoptRequest) {
    try {
      client.updateAdoptRequest(adoptRequest);
    } catch (RemoteException e) {
      e.printStackTrace();
    }
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
       jsonObject.put("description", animal.getDescription());
       jsonObject.put("washed", animal.isWashed());
       jsonObject.put("fed", animal.isFed());
       jsonObject.put("vaccinated", animal.isVaccinated());
       animalsAsJson.add(jsonObject);
      }

    } catch (RemoteException e) {
      e.printStackTrace();
    }
    return animalsAsJson;
  }
}
