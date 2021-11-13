package smallpawsproject.model;

import com.fasterxml.jackson.annotation.JsonCreator;

import javax.persistence.Entity;

@Entity
public class Veterinarian extends Employee
{

  @JsonCreator
  public Veterinarian(String userName, String password, role userRole)
  {
    super( userName, password, userRole);
  }
  public Veterinarian(){}

}
