namespace Godot
{
    /// <summary>Godot SceneTree 场景树/主循环钩子入口。</summary>
    public static class SceneTree
    {
        public static object GetRoot(object tree) => throw new PlatformNotSupportedException();
        public static object GetCurrentScene(object tree) => throw new PlatformNotSupportedException();
        public static object GetPaused(object tree) => throw new PlatformNotSupportedException();
        public static void SetPaused(object tree, bool value) => throw new PlatformNotSupportedException();
        public static void ChangeScene(object tree, string path) => throw new PlatformNotSupportedException();
        public static object ChangeSceneToFile(object tree, string path) => throw new PlatformNotSupportedException();
        public static object ChangeSceneToPacked(object tree, object packedScene) => throw new PlatformNotSupportedException();
        public static void ReloadCurrentScene(object tree) => throw new PlatformNotSupportedException();
        public static object UnloadCurrentScene(object tree) => throw new PlatformNotSupportedException();
        public static void Quit(object tree, int exitCode = 0) => throw new PlatformNotSupportedException();
        public static void SetAutoAcceptQuit(object tree, bool value) => throw new PlatformNotSupportedException();
        public static object GetNodeCount(object tree) => throw new PlatformNotSupportedException();
        public static double GetDebugProcessTime(object tree) => throw new PlatformNotSupportedException();
        public static double GetDebugPhysicsTime(object tree) => throw new PlatformNotSupportedException();
        public static object CreateTimer(object tree, double timeSec, bool processAlways = true, bool processInPhysics = false, bool ignoreTimeScale = false) => throw new PlatformNotSupportedException();
        public static object CreateTween(object tree) => throw new PlatformNotSupportedException();
        public static void CallDeferred(object tree, object callable) => throw new PlatformNotSupportedException();
        public static object CallDeferredGroup(object tree) => throw new PlatformNotSupportedException();
        public static void Connect(object tree, string signal, object callable) => throw new PlatformNotSupportedException();
        public static double GetProcessDelta(object tree) => throw new PlatformNotSupportedException();
        public static double GetPhysicsDelta(object tree) => throw new PlatformNotSupportedException();
        public static int GetFrame(object tree) => throw new PlatformNotSupportedException();
    }
}