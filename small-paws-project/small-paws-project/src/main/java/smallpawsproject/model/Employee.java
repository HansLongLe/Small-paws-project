package smallpawsproject.model;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonProperty;

import javax.persistence.*;


@Entity
public class Employee extends EndUser
{
  private static final long serialVersionUID = 663126647076776891L;
  private role role;
  public enum role{Veterinarian, AnimalAttendant}



  public Employee(){};

  @JsonCreator
  public Employee(@JsonProperty("id") int id ,@JsonProperty("role") role userRole)
  {
    super(id);

    this.role = userRole;
  }

  public role getRole()
  {
    return role;
  }

  public void setRole(role role)
  {
    this.role = role;
  }

}
