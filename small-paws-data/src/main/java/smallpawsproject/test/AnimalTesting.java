package smallpawsproject.test;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;
import smallpawsproject.SmallPawsDataApplication;
import smallpawsproject.model.Animal;
import smallpawsproject.repositories.AnimalRepository;


import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;

@RunWith(SpringRunner.class)
@SpringBootTest(classes = SmallPawsDataApplication.class)
public class AnimalTesting {
    @Autowired
    private AnimalRepository animalRepository;

    @Test
    public void WhenSaveAndRetrieveAnimal_thenOK()
    {
        Animal animal = animalRepository.save(new Animal("bird", 3, "Tropical bird from South America.", new byte[30], true, false, false, "healhy"));
        Animal foundAnimal = animalRepository.findById(animal.getId()).orElse(null);
        assertNotNull(foundAnimal);
        assertEquals(animal.getId(), foundAnimal.getId());
        if (foundAnimal != null)
        {
            animalRepository.deleteById(animal.getId());
        }
    }

    @Test
    public void UpdateAnimal()
    {
        Animal animal = animalRepository.save(new Animal("bird", 3, "Tropical bird from South America.", new byte[30], true, false, false, "healhy"));

        //updating age
        animal.setAge(5);
        animalRepository.save(animal);
        Animal foundAnimal = animalRepository.findById(animal.getId()).orElse(null);
        assertEquals(foundAnimal.getAge(), 5);


        //updating description
        String newDescription = "new description for the bird";
        animal.setDescription(newDescription);
        animalRepository.save(animal);
        foundAnimal = animalRepository.findById(animal.getId()).orElse(null);
        assertEquals(foundAnimal.getDescription(), newDescription);

        //updating fed status
        animal.setFed(false);
        animalRepository.save(animal);
        foundAnimal = animalRepository.findById(animal.getId()).orElse(null);
        assertEquals(foundAnimal.isFed(), false);

        //updating washed status
        animal.setWashed(true);
        animalRepository.save(animal);
        foundAnimal = animalRepository.findById(animal.getId()).orElse(null);
        assertEquals(foundAnimal.isWashed(), true);

        //updating vaccinated status
        animal.setVaccinated(true);
        animalRepository.save(animal);
        foundAnimal = animalRepository.findById(animal.getId()).orElse(null);
        assertEquals(foundAnimal.isVaccinated(), true);

        if (foundAnimal != null)
        {
            animalRepository.deleteById(animal.getId());
        }
    }
}