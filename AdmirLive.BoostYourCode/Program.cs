// ReSharper disable All

using AdmirLive.BoostYourCode.Execute.Factory;

namespace AdmirLive.BoostYourCode.Execute;

internal class Program
{
    private static void Main(string[] args)
    {
        AnimalFactory animalFactory = new();

        var animal = animalFactory.CreateAnimal(animalType: "cat");
        animal.DisplayBehavior();

        animal = animalFactory.CreateAnimal(animalType: "tiger");
        animal.DisplayBehavior();
    }
}