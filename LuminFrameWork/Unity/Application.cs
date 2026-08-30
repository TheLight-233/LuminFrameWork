namespace Unity
{
    /// <summary>Unity Application / 全局运行时信息的钩子入口。</summary>
    public static class Application
    {
        public static void Quit()
            => throw new PlatformNotSupportedException();
        public static void Quit(int exitCode)
            => throw new PlatformNotSupportedException();
        public static void OpenURL(string url)
            => throw new PlatformNotSupportedException();
        public static string GetVersion()
            => throw new PlatformNotSupportedException();
        public static string GetUnityVersion()
            => throw new PlatformNotSupportedException();
        public static string GetProductName()
            => throw new PlatformNotSupportedException();
        public static string GetCompanyName()
            => throw new PlatformNotSupportedException();
        public static string GetIdentifier()
            => throw new PlatformNotSupportedException();
        public static string GetDataPath()
            => throw new PlatformNotSupportedException();
        public static string GetPersistentDataPath()
            => throw new PlatformNotSupportedException();
        public static string GetStreamingAssetsPath()
            => throw new PlatformNotSupportedException();
        public static string GetTemporaryCachePath()
            => throw new PlatformNotSupportedException();
        public static string GetConsoleLogPath()
            => throw new PlatformNotSupportedException();
        public static bool GetIsPlaying()
            => throw new PlatformNotSupportedException();
        public static bool GetIsFocused()
            => throw new PlatformNotSupportedException();
        public static bool GetIsBatchMode()
            => throw new PlatformNotSupportedException();
        public static bool GetIsMobilePlatform()
            => throw new PlatformNotSupportedException();
        public static bool GetIsEditor()
            => throw new PlatformNotSupportedException();
        public static bool GetRunInBackground()
            => throw new PlatformNotSupportedException();
        public static void SetRunInBackground(bool value)
            => throw new PlatformNotSupportedException();
        public static int GetTargetFrameRate()
            => throw new PlatformNotSupportedException();
        public static void SetTargetFrameRate(int value)
            => throw new PlatformNotSupportedException();
        public static bool GetVsync()
            => throw new PlatformNotSupportedException();
        public static void SetVsync(bool value)
            => throw new PlatformNotSupportedException();
        public static int GetFrameRate()
            => throw new PlatformNotSupportedException();
        public static float GetFPS()
            => throw new PlatformNotSupportedException();
        public static void SetStackTraceLogType(int value)
            => throw new PlatformNotSupportedException();
        public static int GetStackTraceLogType()
            => throw new PlatformNotSupportedException();
    }
}