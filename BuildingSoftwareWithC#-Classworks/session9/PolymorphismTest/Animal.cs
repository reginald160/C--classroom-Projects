namespace PolymorphismTest
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }  
        public abstract void eat();

        public Animal(string animalName)
        {
            AnimalName = animalName;
        }


        public override string ToString()
        {
            return $"I am a {AnimalName}\n";
        }
    }


    public class Dog : Animal
    {
        public Dog(string animalName) : base(animalName)
        {
            
        }
        public override void eat()
        {
            Console.WriteLine($"{base.ToString()} I like to eat bones");
        }
    }

    
}