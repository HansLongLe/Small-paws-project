package smallpawsproject.services;

import org.springframework.stereotype.Service;

@Service
public interface UsersService
{
   int checkAccount(String userName, String password);
}
