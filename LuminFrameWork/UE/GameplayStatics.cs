namespace UE
{
    /// <summary>UE UGameplayStatics 游戏玩法静态工具钩子入口。</summary>
    public static class GameplayStatics
    {
        public static object GetPlayerController(object contextWorldContext, int playerIndex = 0) => throw new PlatformNotSupportedException();
        public static object GetPlayerPawn(object contextWorldContext, int playerIndex = 0) => throw new PlatformNotSupportedException();
        public static object GetPlayerCharacter(object contextWorldContext, int playerIndex = 0) => throw new PlatformNotSupportedException();
        public static object GetGameState(object contextWorldContext) => throw new PlatformNotSupportedException();
        public static object GetGameInstance(object contextWorldContext) => throw new PlatformNotSupportedException();
        public static object SpawnActor(object contextWorldContext, object actorClass, object location, object rotation, object? spawnParams = null) => throw new PlatformNotSupportedException();
        public static object SpawnActorAtTransform(object contextWorldContext, object actorClass, object transform, object? spawnParams = null) => throw new PlatformNotSupportedException();
        public static object SpawnActorDeferred(object contextWorldContext, object actorClass, object transform, object owner) => throw new PlatformNotSupportedException();
        public static void FinishSpawningActor(object contextWorldContext, object actor, object transform) => throw new PlatformNotSupportedException();
        public static object BeginDeferredActorSpawnFromClass(object contextWorldContext, object actorClass, object spawnParameters) => throw new PlatformNotSupportedException();
        public static void OpenLevel(object contextWorldContext, string levelName) => throw new PlatformNotSupportedException();
        public static object LoadStreamLevel(object contextWorldContext, string levelName, bool makeVisibleAfterLoad, bool shouldBlockOnLoad, object? completedCallback = null) => throw new PlatformNotSupportedException();
        public static object UnloadStreamLevel(object contextWorldContext, string levelName, object? completedCallback = null, bool shouldBlockOnUnload = false) => throw new PlatformNotSupportedException();
        public static object GetAllActorsOfClass(object contextWorldContext, object actorClass) => throw new PlatformNotSupportedException();
        public static object GetAllActorsOfClassWithTag(object contextWorldContext, object actorClass, string tag) => throw new PlatformNotSupportedException();
        public static object GetAllActorsWithTag(object contextWorldContext, string tag) => throw new PlatformNotSupportedException();
        public static object GetActorOfClass(object contextWorldContext, object actorClass) => throw new PlatformNotSupportedException();
        public static object GetPawnFromPlayerState(object playerState) => throw new PlatformNotSupportedException();
        public static object CreateSound2D(object contextWorldContext, object sound) => throw new PlatformNotSupportedException();
        public static void PlaySound2D(object contextWorldContext, object sound) => throw new PlatformNotSupportedException();
        public static void PlaySoundAtLocation(object contextWorldContext, object sound, object location, float volumeMultiplier = 1f, float pitchMultiplier = 1f) => throw new PlatformNotSupportedException();
        public static void ApplyDamage(object contextWorldContext, object damagedActor, float damage, object damageCauser) => throw new PlatformNotSupportedException();
        public static void ApplyPointDamage(object damagedActor, float baseDamage, object hitFromDirection, object hitLocation, object hitInfo, object damageCauser) => throw new PlatformNotSupportedException();
        public static void SetGlobalTimeDilation(object contextWorldContext, float newDilation) => throw new PlatformNotSupportedException();
        public static float GetGlobalTimeDilation(object contextWorldContext) => throw new PlatformNotSupportedException();
        public static void SetGamePaused(object contextWorldContext, bool paused) => throw new PlatformNotSupportedException();
        public static bool IsGamePaused(object contextWorldContext) => throw new PlatformNotSupportedException();
        public static object CreateSaveGame(object saveGameClass) => throw new PlatformNotSupportedException();
        public static bool SaveGameToSlot(object saveGameObject, string slotName, int userIndex) => throw new PlatformNotSupportedException();
        public static object LoadGameFromSlot(string slotName, int userIndex) => throw new PlatformNotSupportedException();
        public static void DeleteGameInSlot(string slotName, int userIndex) => throw new PlatformNotSupportedException();
    }
}