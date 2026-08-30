namespace UE
{
    /// <summary>UE 定时器 / Job 与运行时钩子入口。</summary>
    public static class Timer
    {
        public static object SetTimer(object target, float time, bool looping, object callback) => throw new PlatformNotSupportedException();
        public static object SetTimerForNextTick(object target, object callback) => throw new PlatformNotSupportedException();
        public static void ClearTimer(object target, object handle) => throw new PlatformNotSupportedException();
        public static void ClearAllTimers(object target) => throw new PlatformNotSupportedException();
        public static bool IsTimerActive(object target, object handle) => throw new PlatformNotSupportedException();
        public static bool IsTimerPaused(object target, object handle) => throw new PlatformNotSupportedException();
        public static float GetTimerElapsed(object target, object handle) => throw new PlatformNotSupportedException();
        public static float GetTimerRemaining(object target, object handle) => throw new PlatformNotSupportedException();
        public static void PauseTimer(object target, object handle) => throw new PlatformNotSupportedException();
        public static void UnpauseTimer(object target, object handle) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE 相机（UCameraComponent）钩子入口。</summary>
    public static class Camera
    {
        public static object GetViewportSize(object camera) => throw new PlatformNotSupportedException();
        public static void SetActive(object camera, bool value) => throw new PlatformNotSupportedException();
        public static object GetRelativeLocation(object camera) => throw new PlatformNotSupportedException();
        public static void SetRelativeLocation(object camera, object location) => throw new PlatformNotSupportedException();
        public static object GetRotation(object camera) => throw new PlatformNotSupportedException();
        public static object GetFieldOfView(object camera) => throw new PlatformNotSupportedException();
        public static void SetFieldOfView(object camera, float value) => throw new PlatformNotSupportedException();
        public static object GetWorldTransform(object camera) => throw new PlatformNotSupportedException();
        public static object GetClipNear(object camera) => throw new PlatformNotSupportedException();
        public static object GetClipFar(object camera) => throw new PlatformNotSupportedException();
        public static bool IsOrthographic(object camera) => throw new PlatformNotSupportedException();
        public static void SetProjectionMode(object camera, int mode) => throw new PlatformNotSupportedException();
        public static object ScreenToWorldPoint(object camera, object screenPoint) => throw new PlatformNotSupportedException();
        public static object WorldToScreenPoint(object camera, object worldPoint) => throw new PlatformNotSupportedException();
    }
}