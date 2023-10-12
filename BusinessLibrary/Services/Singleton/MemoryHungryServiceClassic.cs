namespace BusinessLibrary.Services.Singleton;

public class MemoryHungryServiceClassic : ISayHello
{
    private MemoryHungryServiceClassic()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("--------------Classic approach, a new instance of Memory Hungry Service was created!");
    }

    private static MemoryHungryServiceClassic instance = null;

    public static MemoryHungryServiceClassic Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MemoryHungryServiceClassic();
            }
            return instance;
        }
    }

    public string SayHello(string origin)
    {
        string hello = string.Format("--------------Hello there! {0}", origin);
        Console.WriteLine(hello);
        return hello;
    }
}