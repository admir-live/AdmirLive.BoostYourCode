using AdmirLive.BoostYourCode.Execute.Animals;

namespace AdmirLive.BoostYourCode.Execute.Factory;

/// <summary>
///     The TigerFactory class is a concrete factory class that implements the factory method to return a Tiger object.
/// </summary>
public class TigerFactory : AnimalFactory
{
    // This method will return a Tiger object.
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}