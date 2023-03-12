using AdmirLive.BoostYourCode.Execute.Animals;

namespace AdmirLive.BoostYourCode.Execute.Factory;

/// <summary>
///     The CatFactory class is a concrete factory class that implements the factory method to return a Cat object.
/// </summary>
public class CatFactory : AnimalFactory
{
    // This method will return a Cat object.
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}