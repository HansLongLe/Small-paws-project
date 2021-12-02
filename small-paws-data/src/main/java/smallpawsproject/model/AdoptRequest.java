package smallpawsproject.model;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonProperty;
import org.hibernate.annotations.DynamicUpdate;
import org.hibernate.annotations.Fetch;
import org.hibernate.annotations.FetchMode;
import smallpawsproject.repositories.UsersRepository;

import javax.persistence.*;
import javax.transaction.Transactional;
import java.io.Serializable;
import java.util.Date;

@Transactional
@DynamicUpdate
@Entity
@Table(uniqueConstraints = {@UniqueConstraint(columnNames = {"userId", "animalId"})})
public class AdoptRequest implements Serializable {
    private static final long serialVersionUID = 663126647076776891L;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int requestId;
    @Column(name = "userId")
    private int userId;
    @Column(name = "animalId")
    private int animalId;
    private Date date;
    private String animalType;
    private String animalName;
    private int veterinarianId;
    private Boolean approved;

    public AdoptRequest(){}

    @JsonCreator
    public AdoptRequest(@JsonProperty("requestId") int requestId, @JsonProperty("userId") int userId, @JsonProperty("animalId") int animalId, @JsonProperty("date") Date date, @JsonProperty("animalType") String animalType,
                        @JsonProperty("animalName") String animalName, @JsonProperty("veterinarianId") int veterinarianId, @JsonProperty("approved") Boolean approved)
    {
        this.requestId = requestId;
        this.userId = userId;
        this.animalId = animalId;
        this.date = date;
        this.animalType = animalType;
        this.animalName = animalName;
        this.veterinarianId = veterinarianId;
        this.approved = approved;
    }

    public int getRequestId() {
        return requestId;
    }

    public void setRequestId(int requestId) {
        this.requestId = requestId;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public int getAnimalId() {
        return animalId;
    }

    public void setAnimalId(int animalId) {
        this.animalId = animalId;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public String getAnimalType() {
        return animalType;
    }

    public void setAnimalType(String animalType) {
        this.animalType = animalType;
    }

    public String getAnimalName() {
        return animalName;
    }

    public void setAnimalName(String animalName) {
        this.animalName = animalName;
    }

    public int getVeterinarianId() {
        return veterinarianId;
    }

    public void setVeterinarianId(int veterinarianId) {
        this.veterinarianId = veterinarianId;
    }

    public Boolean isApproved() {
        return approved;
    }

    public void setApproved(Boolean approved) {
        this.approved = approved;
    }
}
