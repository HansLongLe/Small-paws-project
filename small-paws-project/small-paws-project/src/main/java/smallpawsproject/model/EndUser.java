package smallpawsproject.model;

import com.fasterxml.jackson.annotation.JsonCreator;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.io.Serializable;
@Entity
public class EndUser implements Serializable
{
  private static final long serialVersionUID = 663126647076776891L;
  @Id
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private int id;
  private String userName;
  private String password;



  @JsonCreator
  public EndUser(String userName, String password){
    this.userName = userName;
    this.password = password;
  }

  @JsonCreator
  public EndUser(int id , String userName, String password)
  {
    this.id = id;
    this.userName = userName;
    this.password = password;
  }
  @JsonCreator
  public EndUser(int id)
  {
    this.id = id;
  }
  public EndUser(){}

  public String getUserName()
  {
    return userName;
  }

  public void setUserName(String userName)
  {
    this.userName = userName;
  }

  public String getPassword()
  {
    return password;
  }

  public int getId()
  {
    return id;
  }

  public void setId(int id)
  {
    this.id = id;
  }


  public void setPassword(String password)
  {
    this.password = password;
  }

}
