using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Assignment
{
    internal class Zoo
    {
        List<Animal> animals;
        public List<Animal> Animals { get { return animals; } }

        List<Bird> birds;
        List<Mammal> mammals;
        public List<Bird> Birds
        {
            get
            {
                return birds;
            }
        }
        public List<Mammal> Mammals
        {
            get
            {
                return mammals;
            }
        }
        public Zoo()
        {
            animals = new List<Animal>();
            birds = new List<Bird>();
            mammals = new List<Mammal>();
        }
        public void AddAnimal(Animal animal)
        {
            if (animal.Age <= 10)
            {
                animals.Add(animal);

                animal.AnimalDied += this.RemoveDeadAnimal;

                if (animal is Bird bird)
                {
                    birds.Add(bird);
                }
                else if (animal is Mammal mammal)
                {
                    mammals.Add(mammal);
                }
            }
            else
            {
                //throw new Exception("this animal age is greater than 10 years !");
            }
        }
        public void RemoveAnimal(Animal animal)
        {
            animal.AnimalDied -= this.RemoveDeadAnimal;
            animals.Remove(animal);
        }
        public void RemoveAllAnimals(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                animal.AnimalDied -= this.RemoveDeadAnimal;
                this.animals.Remove(animal); 
            }
        }
        public void RemoveDeadAnimal(object sender, Args args)
        {
            Console.WriteLine("An Animal died ... ");

            Animal animal = sender as Animal ;

            animal.AnimalDied -= this.RemoveDeadAnimal;
            animals.Remove((animal));

            if (sender is Lion l )
            {
                mammals.Remove((l));
                Console.WriteLine($"The dead lion has been removed ...");
            }
            else if (sender is Elephant e)
            {
                mammals.Remove((e));
                Console.WriteLine($"The dead Elephant has been removed ...");
            }
            else if (sender is Sparrow s)
            {
                birds.Remove((s));
                Console.WriteLine($"The dead Sparrow has been removed ...");
            }
            else if (sender is Pigeon p)
            {
                birds.Remove((p));
                Console.WriteLine($"The dead Pigion has been removed ...");
            }

            Console.WriteLine($"message from Args : {args.ExtraMessage}");
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
