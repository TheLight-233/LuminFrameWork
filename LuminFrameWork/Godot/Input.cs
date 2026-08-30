namespace Godot
{
    /// <summary>Godot Input 输入钩子入口。</summary>
    public static class Input
    {
        public static bool IsActionPressed(object input, string action) => throw new PlatformNotSupportedException();
        public static bool IsActionPressedExact(object input, string action) => throw new PlatformNotSupportedException();
        public static bool IsActionJustPressed(object input, string action) => throw new PlatformNotSupportedException();
        public static bool IsActionJustReleased(object input, string action) => throw new PlatformNotSupportedException();
        public static float GetActionStrength(object input, string action) => throw new PlatformNotSupportedException();
        public static float GetActionRawStrength(object input, string action) => throw new PlatformNotSupportedException();
        public static float GetAxis(object input, string negativeAction, string positiveAction) => throw new PlatformNotSupportedException();
        public static object GetVector(object input, object negativeX, object positiveX, object negativeY, object positiveY) => throw new PlatformNotSupportedException();
        public static bool IsKeyPressed(object input, object key) => throw new PlatformNotSupportedException();
        public static bool IsMouseButtonPressed(object input, object button) => throw new PlatformNotSupportedException();
        public static object GetMousePosition(object input) => throw new PlatformNotSupportedException();
        public static void SetMousePosition(object input, object position) => throw new PlatformNotSupportedException();
        public static object GetMouseButtonMask(object input) => throw new PlatformNotSupportedException();
        public static void WarpMouse(object input, object position) => throw new PlatformNotSupportedException();
        public static void SetMouseMode(object input, int mode) => throw new PlatformNotSupportedException();
        public static int GetMouseMode(object input) => throw new PlatformNotSupportedException();
        public static void SetUseAccumulatedInput(object input, bool value) => throw new PlatformNotSupportedException();
        public static void ActionPress(object input, string action, float strength = 1f) => throw new PlatformNotSupportedException();
        public static void ActionRelease(object input, string action) => throw new PlatformNotSupportedException();
        public static void VibrationStart(float durationMs = 500f, float power = 1f) => throw new PlatformNotSupportedException();
        public static void VibrationStop() => throw new PlatformNotSupportedException();
        public static object GetJoyAxis(object input, int device, int axis) => throw new PlatformNotSupportedException();
        public static bool GetJoyButton(object input, int device, object button) => throw new PlatformNotSupportedException();
        public static object GetConnectedJoypads(object input) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot InputMap 输入动作表钩子入口。</summary>
    public static class InputMap
    {
        public static bool HasAction(object map, string action) => throw new PlatformNotSupportedException();
        public static void AddAction(object map, string action) => throw new PlatformNotSupportedException();
        public static void AddAction(object map, string action, int deadzone) => throw new PlatformNotSupportedException();
        public static void EraseAction(object map, string action) => throw new PlatformNotSupportedException();
        public static void ActionAddEvent(object map, string action, object @event) => throw new PlatformNotSupportedException();
        public static object ActionGetEvents(object map, string action) => throw new PlatformNotSupportedException();
        public static void ActionEraseEvent(object map, string action, object @event) => throw new PlatformNotSupportedException();
        public static float ActionGetDeadzone(object map, string action) => throw new PlatformNotSupportedException();
        public static object[] GetActions(object map) => throw new PlatformNotSupportedException();
        public static void LoadFromProjectSettings(object map) => throw new PlatformNotSupportedException();
    }
}