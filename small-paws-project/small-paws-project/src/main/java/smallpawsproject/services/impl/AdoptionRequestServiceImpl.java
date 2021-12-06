package smallpawsproject.services.impl;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import smallpawsproject.model.AdoptionRequest;
import smallpawsproject.rmi.ClientFactory;
import smallpawsproject.rmi.ClientRMI;
import smallpawsproject.services.AdoptionRequestService;

import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.List;
@Service
public class AdoptionRequestServiceImpl implements AdoptionRequestService {

    @Autowired
    private final ClientFactory clientFactory;

    private final ClientRMI client;

    public AdoptionRequestServiceImpl(ClientFactory clientFactory) {

        this.clientFactory = clientFactory;
        client = clientFactory.getClient();

        try {
            client.connect();
        }catch (RemoteException e)
        {
            e.printStackTrace();
        }
    }





    @Override
    public void makeNewRequest(AdoptionRequest adoptionRequest) {
        try {
            client.makeNewRequest(adoptionRequest);
            System.out.println("Sent request through client");
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<AdoptionRequest> getAdoptionRequests() {
        List<AdoptionRequest> requests = new ArrayList<>();
        try {
            System.out.println("Adoption Requests from client in service");
            requests = client.getAdoptionRequests();
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return requests;
    }

    @Override
    public AdoptionRequest updateAdoptionRequest(AdoptionRequest adoptionRequest) {
        try {
            return client.updateAdoptionRequest(adoptionRequest);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }
}