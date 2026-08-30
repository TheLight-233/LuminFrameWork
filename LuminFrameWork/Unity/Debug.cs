namespace Unity
{
    /// <summary>Unity Debug 的钩子入口（日志/绘制/断言）。</summary>
    public static class Debug
    {
        public static void Log(object message) => throw new PlatformNotSupportedException();
        public static void Log(object message, object context) => throw new PlatformNotSupportedException();
        public static void LogFormat(object message, params object[] args) => throw new PlatformNotSupportedException();
        public static void LogWarning(object message) => throw new PlatformNotSupportedException();
        public static void LogWarning(object message, object context) => throw new PlatformNotSupportedException();
        public static void LogWarningFormat(object message, params object[] args) => throw new PlatformNotSupportedException();
        public static void LogError(object message) => throw new PlatformNotSupportedException();
        public static void LogError(object message, object context) => throw new PlatformNotSupportedException();
        public static void LogErrorFormat(object message, params object[] args) => throw new PlatformNotSupportedException();
        public static void LogException(System.Exception exception) => throw new PlatformNotSupportedException();
        public static void LogException(System.Exception exception, object context) => throw new PlatformNotSupportedException();
        public static void LogAssertion(object message) => throw new PlatformNotSupportedException();
        public static void LogAssertionFormat(object message, params object[] args) => throw new PlatformNotSupportedException();
        public static void Assert(bool condition) => throw new PlatformNotSupportedException();
        public static void Assert(bool condition, object message) => throw new PlatformNotSupportedException();
        public static void Assert(object message, params object[] args) => throw new PlatformNotSupportedException();
        public static void AssertFormat(bool condition, object message, params object[] args) => throw new PlatformNotSupportedException();
        public static void Break() => throw new PlatformNotSupportedException();
        public static void DrawLine(object start, object end) => throw new PlatformNotSupportedException();
        public static void DrawLine(object start, object end, object color, float duration = 0f) => throw new PlatformNotSupportedException();
        public static void DrawRay(object origin, object direction) => throw new PlatformNotSupportedException();
        public static void DrawRay(object origin, object direction, object color, float duration = 0f) => throw new PlatformNotSupportedException();
        public static void DrawSphere(object center, float radius, object? color = null) => throw new PlatformNotSupportedException();
        public static void DrawCube(object center, object size, object? color = null) => throw new PlatformNotSupportedException();
        public static void DrawText(object position, object text, object? color = null) => throw new PlatformNotSupportedException();
        public static void ClearDeveloperConsole() => throw new PlatformNotSupportedException();
        public static bool GetDeveloperConsoleVisible() => throw new PlatformNotSupportedException();
        public static void SetDeveloperConsoleVisible(bool value) => throw new PlatformNotSupportedException();
        public static bool GetIsDebugBuild() => throw new PlatformNotSupportedException();
    }
}