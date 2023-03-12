using AdmirLive.BoostYourCode.Execute.Animals;

namespace AdmirLive.BoostYourCode.Execute.Factory;

/// <summary>
///     The AnimalFactory class is a factory class that creates animals.
/// </summary>
public class AnimalFactory
{
    /// <summary>
    ///     The CreateAnimal method creates an animal based on the animal type.
    /// </summary>
    /// <param name="animalType">The type of animal to create.</param>
    /// <returns>An object that implements the IAnimal interface.</returns>
    /// <exception cref="ArgumentException">Thrown when an invalid animal type is specified.</exception>
    public IAnimal CreateAnimal(string animalType)
    {
        return animalType switch
        {
            "cat" => new Cat(), // Create a new cat object
            "tiger" => new Tiger(), // Create a new tiger object
            _ => throw new ArgumentException(message: "Invalid animal type. Only cat or tiger are allowed.") // Throw an exception for invalid input
        };
    }
}