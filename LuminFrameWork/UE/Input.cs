namespace UE
{
    /// <summary>UE UInput / 输入钩子入口。</summary>
    public static class Input
    {
        public static bool WasInputKeyJustPressed(object input, object key) => throw new PlatformNotSupportedException();
        public static bool WasInputKeyJustReleased(object input, object key) => throw new PlatformNotSupportedException();
        public static bool IsInputKeyDown(object input, object key) => throw new PlatformNotSupportedException();
        public static float GetInputAxisValue(object input, int index) => throw new PlatformNotSupportedException();
        public static object GetInputAxisKeyValue(object input) => throw new PlatformNotSupportedException();
        public static float GetKeyValue(object input, object key) => throw new PlatformNotSupportedException();
        public static void SetMousePosition(object input, float x, float y) => throw new PlatformNotSupportedException();
        public static object GetMouseDelta(object input) => throw new PlatformNotSupportedException();
        public static object GetMousePosition(object input) => throw new PlatformNotSupportedException();
        public static void SetViewRotation(object input, object value) => throw new PlatformNotSupportedException();
        public static bool IsMouseButtonDown(object input, int button) => throw new PlatformNotSupportedException();
        public static bool IsTouchActive(object input) => throw new PlatformNotSupportedException();
        public static void SetInputEnabled(object input, bool value) => throw new PlatformNotSupportedException();
        public static bool GetInputEnabled(object input) => throw new PlatformNotSupportedException();
        public static void SetMouseCapture(object input, bool value) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE InputComponent 输入组件钩子入口。</summary>
    public static class InputComponent
    {
        public static object BindAxis(object inputComponent, string axisName, object callback) => throw new PlatformNotSupportedException();
        public static object BindAxisKey(object inputComponent, object key, object callback) => throw new PlatformNotSupportedException();
        public static object BindAction(object inputComponent, string actionName, int eventType, object callback) => throw new PlatformNotSupportedException();
        public static object BindKey(object inputComponent, object key, int eventType, object callback, object? chord = null) => throw new PlatformNotSupportedException();
        public static object GetAxisValue(object inputComponent, string axisName) => throw new PlatformNotSupportedException();
        public static object GetKeyValue(object inputComponent, object key) => throw new PlatformNotSupportedException();
        public static object GetPawnPurgeInput(object inputComponent) => throw new PlatformNotSupportedException();
        public static void UnbindAxis(object inputComponent, string axisName) => throw new PlatformNotSupportedException();
        public static void UnbindAction(object inputComponent, string actionName, int eventType) => throw new PlatformNotSupportedException();
        public static void BindKeyDown(object inputComponent, object key, object callback) => throw new PlatformNotSupportedException();
    }
}