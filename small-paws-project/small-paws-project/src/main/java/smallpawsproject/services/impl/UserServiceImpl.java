package smallpawsproject.services.impl;

import org.springframework.stereotype.Service;
import smallpawsproject.model.EndUser;
import smallpawsproject.rmi.ClientFactory;
import smallpawsproject.rmi.ClientRMI;
import smallpawsproject.services.UsersService;

import javax.servlet.http.HttpServletResponse;
import java.rmi.RemoteException;
import java.util.List;
@Service
public class UserServiceImpl implements UsersService
{
  ClientFactory clientFactory;
  ClientRMI client;
  List<EndUser> endUsers;

  public UserServiceImpl(ClientFactory clientFactory)
  {
    this.clientFactory = clientFactory;
    client = clientFactory.getClient();
    try
    {
      client.connect();
    }
    catch (RemoteException e)
    {
      e.printStackTrace();
    }
    try
    {
      endUsers = client.getUsers();
    }
    catch (RemoteException e)
    {
      e.printStackTrace();
    }

  }

  @Override public int checkAccount(String userName, String password)
  {
    int answer = 0;
        for(EndUser endUser : endUsers){
          if (endUser.getUserName().equals(userName) && endUser.getPassword()
              .equals(password))
          {
            System.out.println(endUser.getUserName());
            System.out.println(endUser.getPassword());
            answer = HttpServletResponse.SC_ACCEPTED;
            break;
          }
          else
          {
            answer = HttpServletResponse.SC_FORBIDDEN;
          }
        }


    return answer;

  }
}
