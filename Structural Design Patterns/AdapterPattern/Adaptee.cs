namespace AdapterPattern;

/// <summary>
/// 适应者
/// </summary>
public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request.";
    }
}