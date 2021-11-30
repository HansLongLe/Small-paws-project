package smallpawsproject.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import smallpawsproject.model.AdoptRequest;


public interface AdoptRequestRepository extends JpaRepository<AdoptRequest, Integer> {
}
