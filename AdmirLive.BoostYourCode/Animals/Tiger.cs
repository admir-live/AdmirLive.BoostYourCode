namespace AdmirLive.BoostYourCode.Execute.Animals;

/// <summary>
///     The Tiger class implements the IAnimal interface.
/// </summary>
internal class Tiger : IAnimal
{
    public Tiger()
    {
        Console.WriteLine(value: "A tiger is created.");
    }

    public void DisplayBehavior()
    {
        Console.WriteLine(value: "It roars. It loves to roam in the jungle.");
    }
}