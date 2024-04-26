namespace Delegate_Assignment
{
    internal delegate bool DeathCheckDelegate(Animal animal);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MY Zoo
            Zoo zoo = new Zoo();

            Lion l1 = new(5);
            Elephant e1 = new(7);
            Pigeon p1 = new(8);
            Sparrow s1 = new(6);

            zoo.AddAnimal(l1);
            zoo.AddAnimal(e1);
            zoo.AddAnimal(p1);
            zoo.AddAnimal(s1);

            Lion l2 = new(7);
            Elephant e2 = new(2);
            Pigeon p2 = new(7);
            Sparrow s2 = new(1);

            zoo.AddAnimal(l2);
            zoo.AddAnimal(e2);
            zoo.AddAnimal(p2);
            zoo.AddAnimal(s2);

            //l1.AnimalDied += zoo.RemoveDeadAnimal;
            //e1.AnimalDied += zoo.RemoveDeadAnimal;
            //p1.AnimalDied += zoo.RemoveDeadAnimal;
            //s1.AnimalDied += zoo.RemoveDeadAnimal;

            Console.WriteLine(" Birds :");
            foreach (Animal bird in zoo.Birds)
            // (Birds must be a read-only collection)
            {
                Console.WriteLine($"\t{bird}");
            }
            Console.WriteLine("\t================================");


            Console.WriteLine(" Mammals :");
            foreach (Animal mammal in zoo.Mammals)
            // (Mammals must be a read-only collection)
            {
                Console.WriteLine($"\t{mammal}");
            }
            Console.WriteLine("\t================================");


            Console.WriteLine(" Animals :");
            foreach (Animal animal in zoo.Animals)
            {
                Console.WriteLine($"\t{animal}");
            }
            Console.WriteLine("\t================================");

            l1.Die();
            e1.Die();
            p1.Die();
            s1.Die();

            Console.WriteLine("\tBirds again after Death :");
            foreach (Animal bird in zoo.Birds)
            // (Birds must be a read-only collection)
            {
                Console.WriteLine($"\t\t{bird}");
            }
            Console.WriteLine("\t================================");


            Console.WriteLine("\t Mammals again after Death :");
            foreach (Animal mammal in zoo.Mammals)
            // (Birds must be a read-only collection)
            {
                Console.WriteLine($"\t\t{mammal}");
            }
            Console.WriteLine("\t================================");

            Console.WriteLine("\tAnimals again after Death :");
            foreach (Animal animal in zoo.Animals)
            {
                Console.WriteLine($"\t\t{animal}");
            }
            Console.WriteLine("\t================================");

            #endregion

            #region PhoneBook
            //PhoneBook myPB = new PhoneBook();
            //myPB[123] = "Omar";     // set using int indexer
            //myPB["Ahmed"] = 456;   // set using string indexer

            //Console.WriteLine($"Omar phone number : {myPB["Omar"]}");                 // get using string indexer
            //Console.WriteLine($"the person whose phone number(456) : {myPB[456]}");  // get using int indexer

            //Console.WriteLine($"Emad phone number : {myPB["Emad"]}");                 // testing nonexisted name =>  get using string indexer 
            //Console.WriteLine($"the person whose phone number(789) : {myPB[789]}");  // testing nonexisted number =>  get using string indexer 

            ////PhoneBook myPB2 = new PhoneBook();
            ////myPB2[123] = "Ali";
            ////myPB2["Hossam"] = 456;
            ////int phone = myPB2["Ali"];
            ////Console.WriteLine($"Ali's phone number : {phone}"); 
            #endregion

            #region Advanced Phone Book
            //AdvancedPhoneBook adb1 = new AdvancedPhoneBook();
            //adb1["Omar"] = 123;   // set using string indexer
            //adb1[456] = "Ahmed"; // set using int indexer 

            //Console.WriteLine($"omar's phone number : {adb1["Omar"]}");              // get using string indexer
            //Console.WriteLine($"the person whose phone number (456): {adb1[456]}"); //get using int indexer 

            //Console.WriteLine($"Ali's phone number : {adb1["Ali"]}");                // testing nonexisted name => get using string indexer
            //Console.WriteLine($"the person whose phone number (789): {adb1[789]}"); //testing nonexisted number =>get using int indexer  
            #endregion



        }
    }
}
