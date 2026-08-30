namespace Unity
{
    /// <summary>Unity Time 的钩子入口。</summary>
    public static class Time
    {
        public static float GetDeltaTime() => throw new PlatformNotSupportedException();
        public static float GetUnscaledDeltaTime() => throw new PlatformNotSupportedException();
        public static float GetFixedDeltaTime() => throw new PlatformNotSupportedException();
        public static float GetFixedUnscaledDeltaTime() => throw new PlatformNotSupportedException();
        public static float GetTime() => throw new PlatformNotSupportedException();
        public static float GetUnscaledTime() => throw new PlatformNotSupportedException();
        public static float GetRealtimeSinceStartup() => throw new PlatformNotSupportedException();
        public static float GetSmoothDeltaTime() => throw new PlatformNotSupportedException();
        public static float GetFixedTime() => throw new PlatformNotSupportedException();
        public static float GetTimeSinceLevelLoad() => throw new PlatformNotSupportedException();

        public static float GetTimeScale() => throw new PlatformNotSupportedException();
        public static void SetTimeScale(float value) => throw new PlatformNotSupportedException();

        public static int GetFrameCount() => throw new PlatformNotSupportedException();
        public static int GetFrameTime() => throw new PlatformNotSupportedException();

        public static float GetMaximumDeltaTime() => throw new PlatformNotSupportedException();
        public static void SetMaximumDeltaTime(float value) => throw new PlatformNotSupportedException();
        public static float GetMaximumParticleDeltaTime() => throw new PlatformNotSupportedException();
        public static void SetMaximumParticleDeltaTime(float value) => throw new PlatformNotSupportedException();
        public static bool GetUseRealTime() => throw new PlatformNotSupportedException();
        public static void SetUseRealTime(bool value) => throw new PlatformNotSupportedException();
        public static int GetCaptureFramerate() => throw new PlatformNotSupportedException();
        public static void SetCaptureFramerate(int value) => throw new PlatformNotSupportedException();
    }
}