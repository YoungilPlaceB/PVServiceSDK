namespace PVServiceSDK
{
    public interface IActorService
    {
        ILocalActor localActor { get; }
    }

    public interface IActor
    {

    }

    public interface ILocalActor : IActor
    {
        IAvatar avatar { get; }
    }
}
