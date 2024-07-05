namespace BusinessLibrary.StructuralPatterns.Adapter;

internal class ClientClassTwo
{
    private readonly IClientInterface _clientInterface;
    internal ClientClassTwo(IClientInterface clientInterface)
    {
        _clientInterface = clientInterface;
    }

    /// <summary>
    /// Here some client specific logic can happen. The client doesn't know have to know anything about the legacy class, 
    /// nor is it forced to set it up. This can only need a part of the logic provided by the adapter, but then it's worth considering 
    /// interface segregation principle. 
    /// </summary>
    internal void DoSomeClientOperation()
    {
        _clientInterface.Substract(1, 2);
    }
}