namespace AdmirLive.BoostYourCode.Execute.Animals;

/// <summary>
///     The Cat class implements the IAnimal interface.
/// </summary>
internal class Cat : IAnimal
{
    public Cat()
    {
        Console.WriteLine(value: "A cat is created.");
    }

    public void DisplayBehavior()
    {
        Console.WriteLine(value: "It meows.It loves to stay at a home. ");
    }
}