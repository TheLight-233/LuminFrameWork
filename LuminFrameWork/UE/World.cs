namespace UE
{
    /// <summary>UE UWorld / 世界钩子入口。</summary>
    public static class World
    {
        public static object GetGameInstance(object world) => throw new PlatformNotSupportedException();
        public static object GetFirstPlayerController(object world) => throw new PlatformNotSupportedException();
        public static object GetPlayerController(object world, int playerIndex) => throw new PlatformNotSupportedException();
        public static object GetPawnIterator(object world) => throw new PlatformNotSupportedException();
        public static int GetPawnCount(object world) => throw new PlatformNotSupportedException();
        public static object GetPawn(object world, int index) => throw new PlatformNotSupportedException();
        public static object SpawnActor(object world, object actorClass, object transform) => throw new PlatformNotSupportedException();
        public static object SpawnActorDeferred(object world, object actorClass, object transform) => throw new PlatformNotSupportedException();
        public static object SpawnActorDeferredWithLayer(object world, object actorClass, object transform, object layer) => throw new PlatformNotSupportedException();
        public static void DestroyActor(object world, object actor) => throw new PlatformNotSupportedException();
        public static object SpawnActorOfType(object world, object actor) => throw new PlatformNotSupportedException();
        public static object GetActorsOfType(object world, object actorClass) => throw new PlatformNotSupportedException();
        public static object GetOverlappingActors(object world, object actor, object? volumeClass = null) => throw new PlatformNotSupportedException();
        public static object GetOverlappingActorsInfo(object world) => throw new PlatformNotSupportedException();
        public static object GetGameMode(object world) => throw new PlatformNotSupportedException();
        public static object GetLevel(object world) => throw new PlatformNotSupportedException();
        public static void ServerTravel(object world, string url) => throw new PlatformNotSupportedException();
        public static void ServerTravelTime(object world, string url, float travelTime) => throw new PlatformNotSupportedException();
        public static object ClientTravel(object world, string url) => throw new PlatformNotSupportedException();
        public static object GetWorldDeltaSeconds(object world) => throw new PlatformNotSupportedException();
        public static object GetTimeSeconds(object world) => throw new PlatformNotSupportedException();
        public static object GetRealTimeSeconds(object world) => throw new PlatformNotSupportedException();
        public static object GetUnpausedTimeSeconds(object world) => throw new PlatformNotSupportedException();
        public static object GetGravityZ(object world) => throw new PlatformNotSupportedException();
        public static object GetWorldDilation(object world) => throw new PlatformNotSupportedException();
        public static object GetGetAuthorization(object world) => throw new PlatformNotSupportedException();
        public static object GetNetMode(object world) => throw new PlatformNotSupportedException();
        public static object GetMapName(object world) => throw new PlatformNotSupportedException();
        public static void SetPause(object world, bool value) => throw new PlatformNotSupportedException();
        public static bool GetPause(object world) => throw new PlatformNotSupportedException();
        public static object GetOwningLocalLevel(object world) => throw new PlatformNotSupportedException();
        public static object LoadStreamLevel(object world, string levelName, bool makeVisibleAfterLoad, bool shouldBlockOnLoad) => throw new PlatformNotSupportedException();
        public static object UnloadStreamLevel(object world, string levelName) => throw new PlatformNotSupportedException();
    }
}