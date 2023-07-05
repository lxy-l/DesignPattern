namespace ProxyPattern;

public class RealSubject:ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}