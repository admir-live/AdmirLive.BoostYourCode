using AdmirLive.BoostYourCode.Execute.Factory;

namespace AdmirLive.BoostYourCode.Execute;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create a cat factory based on the AnimalFactory class.
        AnimalFactory animalFactory = new CatFactory();
        
        // Create a cat based on the cat factory.
        IAnimal animal = animalFactory.CreateAnimal();
        animal.DisplayBehavior();

        // Create a tiger factory based on the AnimalFactory class.
        animalFactory = new TigerFactory();
        
        // Create a tiger based on the tiger factory.
        animal = animalFactory.CreateAnimal();
        animal.DisplayBehavior();
    }
}