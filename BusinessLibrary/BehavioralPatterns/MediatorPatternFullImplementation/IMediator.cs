namespace BusinessLibrary.BehavioralPatterns.MediatorPatternFullImplementation;

public interface IMediator
{
    public void Notify(object sender, string ev);
}