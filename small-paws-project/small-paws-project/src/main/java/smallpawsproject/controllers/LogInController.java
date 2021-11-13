package smallpawsproject.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import smallpawsproject.model.EndUser;
//import smallpawsproject.securityjwt.provider.JWTProvider;
import smallpawsproject.services.*;

@RestController
public class LogInController
{
//  @Autowired
//  private final EmployeeService employeeService;
//  @Autowired
//  private final PetOwnerService petOwnerService;
//
  @Autowired
  private UsersService usersService;


  public LogInController(UsersService usersService)
  {
    this.usersService = usersService;
  }


  @PostMapping("/User")
  @ResponseBody
  public int login(@RequestBody EndUser endUser){
//    if(request.getRole().equals("PetOwner")){
//      return petOwnerService.authenticatePetOwner(request.getUserName(),
//          request.getPassword());
//    }
//    else if(request.getRole().equals("Employee")){
//      return employeeService.authenticateEmployee(request.getUserName(),
//          request.getPassword());
//    }

    return usersService.checkAccount(endUser.getUserName(),
        endUser.getPassword());
    }
  }

