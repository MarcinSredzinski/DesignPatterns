namespace BusinessLibrary.Services.Singleton;

public class MemoryHungryServiceClassic : ISayHello
{
    private MemoryHungryServiceClassic()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("--------------Classic approach, a new instance of Memory Hungry Service was created!");
    }

    private int saidHelloCounter = 0;
    private static MemoryHungryServiceClassic? instance = null;

    public static MemoryHungryServiceClassic Instance
    {
        get
        {
            if (instance != null)
            {
                return instance;
            }
            instance = new MemoryHungryServiceClassic();
            return instance;
        }
    }

    public string SayHello(string origin)
    {
        string hello = string.Format("--------------Hello there! Said hello {0} times, from: {1}", saidHelloCounter, origin);
        saidHelloCounter++;
        Console.WriteLine(hello);
        return hello;
    }
}