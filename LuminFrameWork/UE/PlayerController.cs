namespace UE
{
    /// <summary>UE APlayerController / 玩家控制器钩子入口。</summary>
    public static class PlayerController
    {
        public static object GetPawn(object controller) => throw new PlatformNotSupportedException();
        public static void SetPawn(object controller, object pawn) => throw new PlatformNotSupportedException();
        public static object GetCharacter(object controller) => throw new PlatformNotSupportedException();
        public static object GetPlayerCameraManager(object controller) => throw new PlatformNotSupportedException();
        public static object GetViewTarget(object controller) => throw new PlatformNotSupportedException();
        public static void SetControlRotation(object controller, object newRotation) => throw new PlatformNotSupportedException();
        public static object GetControlRotation(object controller) => throw new PlatformNotSupportedException();
        public static object GetInputAxis(object controller, string axisName) => throw new PlatformNotSupportedException();
        public static object GetInputVectorAxis(object controller, int axis) => throw new PlatformNotSupportedException();
        public static bool IsInputKeyDown(object controller, object key) => throw new PlatformNotSupportedException();
        public static object GetHitResultUnderCursor(object controller, int traceChannels, bool bTraceComplex) => throw new PlatformNotSupportedException();
        public static object GetMousePosition(object controller, out object mousePositionX) => throw new PlatformNotSupportedException();
        public static void SetMouseLocation(object controller, float x, float y) => throw new PlatformNotSupportedException();
        public static void SetShowMouseCursor(object controller, bool value) => throw new PlatformNotSupportedException();
        public static bool GetShowMouseCursor(object controller) => throw new PlatformNotSupportedException();
        public static void EnableInput(object controller, object playerInput) => throw new PlatformNotSupportedException();
        public static void DisableInput(object controller, object playerInput) => throw new PlatformNotSupportedException();
        public static object GetInputTouch(object controller) => throw new PlatformNotSupportedException();
        public static object GetVirtualJoystick(object controller) => throw new PlatformNotSupportedException();
        public static void SetDisableHapticEffects(object controller, bool value) => throw new PlatformNotSupportedException();
        public static object GetLocalPlayer(object controller) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE APlayerCharacter/WorldSettings 世界设置钩子入口。</summary>
    public static class WorldSettings
    {
        public static object GetTimeSeconds(object world) => throw new PlatformNotSupportedException();
        public static object GetStartTime(object world) => throw new PlatformNotSupportedException();
        public static bool GetIsPaused(object world) => throw new PlatformNotSupportedException();
        public static object GetGravityZ(object world) => throw new PlatformNotSupportedException();
        public static object GetGlobalTimeDilation(object world) => throw new PlatformNotSupportedException();
        public static void SetGlobalTimeDilation(object world, float value) => throw new PlatformNotSupportedException();
        public static object GetCustomTimeDilation(object world) => throw new PlatformNotSupportedException();
        public static void SetCustomTimeDilation(object world, float value) => throw new PlatformNotSupportedException();
        public static void SetTimeDilation(object world, float value) => throw new PlatformNotSupportedException();
        public static void SetMaxPhysicsTicksPerSecond(object world, float value) => throw new PlatformNotSupportedException();
        public static object GetMaxPhysicsTicksPerSecond(object world) => throw new PlatformNotSupportedException();
        public static void SetMinClientHandshakeTimeout(object world, float value) => throw new PlatformNotSupportedException();
        public static void SetMinimumTickDeltaTime(object world, float value) => throw new PlatformNotSupportedException();
    }
}