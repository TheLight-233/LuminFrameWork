namespace Unity
{
    /// <summary>Unity Input 的钩子入口。</summary>
    public static class Input
    {
        public static bool GetKey(int keyCode)
            => throw new PlatformNotSupportedException();
        public static bool GetKeyDown(int keyCode)
            => throw new PlatformNotSupportedException();
        public static bool GetKeyUp(int keyCode)
            => throw new PlatformNotSupportedException();
        public static bool GetMouseButton(int button)
            => throw new PlatformNotSupportedException();
        public static bool GetMouseButtonDown(int button)
            => throw new PlatformNotSupportedException();
        public static bool GetMouseButtonUp(int button)
            => throw new PlatformNotSupportedException();
        public static bool GetButton(string buttonName)
            => throw new PlatformNotSupportedException();
        public static bool GetButtonDown(string buttonName)
            => throw new PlatformNotSupportedException();
        public static bool GetButtonUp(string buttonName)
            => throw new PlatformNotSupportedException();
        public static bool GetButtonHeld(string buttonName)
            => throw new PlatformNotSupportedException();
        public static float GetAxis(string axisName)
            => throw new PlatformNotSupportedException();
        public static float GetAxisRaw(string axisName)
            => throw new PlatformNotSupportedException();
        public static bool GetTouch(int fingerId, out object touch)
            => throw new PlatformNotSupportedException();
        public static int GetTouchCount()
            => throw new PlatformNotSupportedException();
        public static object GetMousePosition()
            => throw new PlatformNotSupportedException();
        public static object GetMouseScrollDelta()
            => throw new PlatformNotSupportedException();
        public static void SetMousePosition(object position)
            => throw new PlatformNotSupportedException();
        public static void ResetInputAxes()
            => throw new PlatformNotSupportedException();
        public static string[] GetJoystickNames()
            => throw new PlatformNotSupportedException();
        public static bool IsJoystickPreconfigured(string joystickName)
            => throw new PlatformNotSupportedException();
        public static float GetGyroAttitude()
            => throw new PlatformNotSupportedException();
        public static object GetAcceleration()
            => throw new PlatformNotSupportedException();
        public static bool GetAccelerationEvent(int index, out object accelerationEvent)
            => throw new PlatformNotSupportedException();
        public static int GetAccelerationEventCount()
            => throw new PlatformNotSupportedException();
    }
}