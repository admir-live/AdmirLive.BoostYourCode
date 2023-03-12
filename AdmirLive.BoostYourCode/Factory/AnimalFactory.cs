namespace AdmirLive.BoostYourCode.Execute.Factory;

/// <summary>
///     The AnimalFactory class declares the factory method that is supposed to return an object of a Animal class.
/// </summary>
public abstract class AnimalFactory
{
    // This is the factory method that is supposed to return an object of a Animal class in the derived classes.
    public abstract IAnimal CreateAnimal();
}