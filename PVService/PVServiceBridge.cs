namespace PVServiceSDK
{
    public static class PVServiceBridge
	{
        public static IActorService actorService;

        public static void Initialize(IPVServiceInitializer initializer)
        {
            initializer.Initialize();
        }
    }
}