using Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository_Pattern.DAL
{
    public class AnimalRepository : IAnimalRepository
    {


        private readonly AnimalContext _animalContext;

        public AnimalRepository(AnimalContext animalContext)
        {
            _animalContext = animalContext;
        }

        public void Add(Animal animal)
        {
            _animalContext.Animals.Add(animal);
            _animalContext.SaveChanges();

        }

        public void Delete(Animal animal)
        {
            _animalContext.Animals.Remove(animal);
        }

        public void Dispose()
        {
            _animalContext.Dispose();
        }

        public Animal Get(string name)
        {
            return _animalContext.Animals.FirstOrDefault(animal => animal.Name.Equals(name));
        }

        public void Save()
        {
            _animalContext.SaveChanges();
        }

        public void GetAll()
        {

        }

        public void Update(Animal animal)
        {
            var dbAnimal = _animalContext.Animals.FirstOrDefault(an => an.Id.Equals(animal.Name));
            if (dbAnimal != null)
            {
                dbAnimal.Name = animal.Name;
            }
        }
    }
}