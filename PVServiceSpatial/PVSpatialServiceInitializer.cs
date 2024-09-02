using UnityEngine;

namespace PVServiceSDK.Spatial
{
    public class PVSpatialServiceInitializer : IPVServiceInitializer
    {
        void IPVServiceInitializer.Initialize()
        {
            PVServiceBridge.actorService = new PVSpatialActorService();
        }
    }
}