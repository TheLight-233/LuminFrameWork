namespace Godot
{
    /// <summary>Godot DisplayServer / 显示服务器钩子入口。</summary>
    public static class Display
    {
        public static int GetScreenCount() => throw new PlatformNotSupportedException();
        public static object GetScreenSize() => throw new PlatformNotSupportedException();
        public static object GetScreenPosition() => throw new PlatformNotSupportedException();
        public static void WindowSetPosition(object position) => throw new PlatformNotSupportedException();
        public static object WindowGetPosition() => throw new PlatformNotSupportedException();
        public static void WindowSetSize(object size) => throw new PlatformNotSupportedException();
        public static object WindowGetSize() => throw new PlatformNotSupportedException();
        public static void WindowSetMode(int mode) => throw new PlatformNotSupportedException();
        public static int WindowGetMode() => throw new PlatformNotSupportedException();
        public static void WindowSetMaxSize(object size) => throw new PlatformNotSupportedException();
        public static void WindowSetMinSize(object size) => throw new PlatformNotSupportedException();
        public static void WindowSetTitle(string title) => throw new PlatformNotSupportedException();
        public static string WindowGetTitle() => throw new PlatformNotSupportedException();
        public static void WindowSetVsyncMode(int mode) => throw new PlatformNotSupportedException();
        public static int WindowGetVsyncMode() => throw new PlatformNotSupportedException();
        public static void ScreenSetOrientation(int orientation) => throw new PlatformNotSupportedException();
        public static int ScreenGetOrientation() => throw new PlatformNotSupportedException();
        public static string GetName() => throw new PlatformNotSupportedException();
        public static void SetBorderless(bool value) => throw new PlatformNotSupportedException();
        public static float ScreenGetDPI(int screen = -1) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Engine / 引擎信息钩子入口。</summary>
    public static class Engine
    {
        public static string GetVersion() => throw new PlatformNotSupportedException();
        public static int GetVersionMajor() => throw new PlatformNotSupportedException();
        public static int GetVersionMinor() => throw new PlatformNotSupportedException();
        public static string GetVersionPatch() => throw new PlatformNotSupportedException();
        public static string GetCopyrightInformation() => throw new PlatformNotSupportedException();
        public static string GetDoctorInformation() => throw new PlatformNotSupportedException();
        public static double GetFramesPerSecond() => throw new PlatformNotSupportedException();
        public static bool GetIsEditorHint() => throw new PlatformNotSupportedException();
        public static void SetPhysicsTicksPerSecond(int value) => throw new PlatformNotSupportedException();
        public static int GetPhysicsTicksPerSecond() => throw new PlatformNotSupportedException();
        public static void SetMaxFps(int value) => throw new PlatformNotSupportedException();
        public static int GetMaxFps() => throw new PlatformNotSupportedException();
        public static double GetFps() => throw new PlatformNotSupportedException();
        public static void SetTimeScale(double value) => throw new PlatformNotSupportedException();
        public static double GetTimeScale() => throw new PlatformNotSupportedException();
        public static void SetPhysicsJitterFix(double value) => throw new PlatformNotSupportedException();
        public static bool HasMainLoop() => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Time / 时间钩子入口。</summary>
    public static class Time
    {
        public static int GetTicksMsec() => throw new PlatformNotSupportedException();
        public static long GetUnixTime() => throw new PlatformNotSupportedException();
        public static object GetDatetimeDictFromSystem() => throw new PlatformNotSupportedException();
        public static object GetDatetimeDictFromUnixTime(long time) => throw new PlatformNotSupportedException();
        public static string GetDatetimeString() => throw new PlatformNotSupportedException();
        public static string GetTimeString() => throw new PlatformNotSupportedException();
        public static object GetDateDictFromSystem() => throw new PlatformNotSupportedException();
        public static object GetDateDictFromUnixTime(long time) => throw new PlatformNotSupportedException();
        public static string GetTimeStringFromMsec(long msec) => throw new PlatformNotSupportedException();
        public static long GetTimePassedSince(object start) => throw new PlatformNotSupportedException();
    }
}