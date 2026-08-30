namespace Godot
{
    /// <summary>Godot 全局函数 / GDScript 全局作用域钩子入口。</summary>
    public static class Global
    {
        public static void Print(object message) => throw new PlatformNotSupportedException();
        public static void Print(string format, params object[] args) => throw new PlatformNotSupportedException();
        public static void PrintRich(object message) => throw new PlatformNotSupportedException();
        public static void PushWarning(object message) => throw new PlatformNotSupportedException();
        public static void PushError(object message) => throw new PlatformNotSupportedException();
        public static void PushDebugBreak() => throw new PlatformNotSupportedException();
        public static void PushErrorBreak(object message) => throw new PlatformNotSupportedException();
        public static void Breakpoint() => throw new PlatformNotSupportedException();
        public static void Assert(bool condition, object? message = null)
        {
            throw new PlatformNotSupportedException();
        }
        public static object GetSceneTree() => throw new PlatformNotSupportedException();
        public static object Load(string path, string? typeHint = null) => throw new PlatformNotSupportedException();
        public static bool ResourceExists(string path) => throw new PlatformNotSupportedException();
        public static void SetRandomSeed(object seed) => throw new PlatformNotSupportedException();
        public static float GetRandomNumber() => throw new PlatformNotSupportedException();
        public static int GetRandomInteger(int from, int to) => throw new PlatformNotSupportedException();
        public static object GetRandomPoint(object rect) => throw new PlatformNotSupportedException();
        public static float GetFrameDelta() => throw new PlatformNotSupportedException();
        public static float GetPhysicsFrameDelta() => throw new PlatformNotSupportedException();
        public static int GetFrame() => throw new PlatformNotSupportedException();
        public static float GetProcessFrameDelta() => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Object 基类通用信号/属性钩子入口。</summary>
    public static class Object
    {
        public static void Connect(object target, string signal, object callable) => throw new PlatformNotSupportedException();
        public static void Connect(object target, string signal, object callable, object flags) => throw new PlatformNotSupportedException();
        public static void Disconnect(object target, string signal, object callable) => throw new PlatformNotSupportedException();
        public static void EmitSignal(object target, string signal) => throw new PlatformNotSupportedException();
        public static object EmitSignalReturn(object target, string signal, params object[] args) => throw new PlatformNotSupportedException();
        public static object Get(object target, string property) => throw new PlatformNotSupportedException();
        public static void Set(object target, string property, object value) => throw new PlatformNotSupportedException();
        public static object Call(object target, string method, params object[] args) => throw new PlatformNotSupportedException();
        public static object CallDeferred(object target, string method, params object[] args) => throw new PlatformNotSupportedException();
        public static bool HasMethod(object target, string method) => throw new PlatformNotSupportedException();
        public static bool HasSignal(object target, string signal) => throw new PlatformNotSupportedException();
        public static bool HasMeta(object target, string name) => throw new PlatformNotSupportedException();
        public static object GetMeta(object target, string name, object? fallback = null) => throw new PlatformNotSupportedException();
        public static void SetMeta(object target, string name, object value) => throw new PlatformNotSupportedException();
        public static string GetClass(object target) => throw new PlatformNotSupportedException();
        public static bool IsClass(object target, string className) => throw new PlatformNotSupportedException();
        public static void Free(object target) => throw new PlatformNotSupportedException();
        public static bool IsInstanceValid(object target) => throw new PlatformNotSupportedException();
        public static System.Collections.Generic.Dictionary<string, object> GetPropertyList(object target) => throw new PlatformNotSupportedException();
        public static System.Collections.Generic.Dictionary<string, object> GetMethodList(object target) => throw new PlatformNotSupportedException();
        public static System.Collections.Generic.Dictionary<string, object> GetSignalList(object target) => throw new PlatformNotSupportedException();
    }
}