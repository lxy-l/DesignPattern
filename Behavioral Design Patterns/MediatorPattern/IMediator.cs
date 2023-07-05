namespace MediatorPattern;

public interface IMediator
{
    void Notify(object sender, string ev);
}