namespace BridgePattern;

public class Client
{
    public void ClientCode(Abstraction abstraction)
    {
        Console.Write(abstraction.Operation());
    }
}