namespace Unity
{
    /// <summary>Unity Screen 屏幕信息的钩子入口。</summary>
    public static class Screen
    {
        public static int GetWidth() => throw new PlatformNotSupportedException();
        public static int GetHeight() => throw new PlatformNotSupportedException();
        public static void SetResolution(int width, int height, bool fullscreen)
            => throw new PlatformNotSupportedException();
        public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
            => throw new PlatformNotSupportedException();
        public static bool GetFullScreen() => throw new PlatformNotSupportedException();
        public static void SetFullScreen(bool value) => throw new PlatformNotSupportedException();
        public static int GetRefreshRate() => throw new PlatformNotSupportedException();
        public static int GetDPI() => throw new PlatformNotSupportedException();
        public static float GetBrightness() => throw new PlatformNotSupportedException();
        public static void SetBrightness(float value) => throw new PlatformNotSupportedException();
        public static float GetSleepTimeout() => throw new PlatformNotSupportedException();
        public static void SetSleepTimeout(float value) => throw new PlatformNotSupportedException();
        public static bool GetFullScreenMode() => throw new PlatformNotSupportedException();
        public static void SetFullScreenMode(int value) => throw new PlatformNotSupportedException();
        public static int GetRenderingOrder() => throw new PlatformNotSupportedException();
        public static void SetRenderingOrder(int value) => throw new PlatformNotSupportedException();
        public static string GetOrientation() => throw new PlatformNotSupportedException();
        public static void SetOrientation(string value) => throw new PlatformNotSupportedException();
        public static object GetSafeArea() => throw new PlatformNotSupportedException();
        public static bool GetCutoutEnabled() => throw new PlatformNotSupportedException();
    }
}