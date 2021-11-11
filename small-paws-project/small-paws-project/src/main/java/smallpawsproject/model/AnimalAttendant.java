package smallpawsproject.model;

import com.fasterxml.jackson.annotation.JsonCreator;

import javax.persistence.Entity;
import javax.persistence.Id;
@Entity
public class AnimalAttendant extends Employee
{


  @JsonCreator
  public AnimalAttendant(int id, role userRole)
  {
    super(id, userRole);
  }
  public AnimalAttendant(){}

}
