using SpatialSys.UnitySDK;

namespace PVServiceSDK.Spatial
{
    public class PVSpatialActorService : IActorService
    {
        public ILocalActor localActor { get; } = new PVSpatialLocalActor();
    }

    public class PVSpatialLocalActor : ILocalActor
    {
        public IAvatar avatar { get; } = new PVSpatialLocalAvatar();
    }

    public class PVSpatialLocalAvatar : IAvatar
    {
        public void Jump() => SpatialBridge.actorService.localActor.avatar.Jump();
    }
}
