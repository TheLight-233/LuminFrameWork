namespace Unity
{
    /// <summary>Unity Camera 的钩子入口。</summary>
    public static class Camera
    {
        public static object GetMain()
            => throw new PlatformNotSupportedException();
        public static object[] GetAllCameras()
            => throw new PlatformNotSupportedException();
        public static object GetFirstEnabled()
            => throw new PlatformNotSupportedException();
        public static bool SetEnabled(object camera, bool value)
            => throw new PlatformNotSupportedException();
        public static float GetFieldOfView(object camera)
            => throw new PlatformNotSupportedException();
        public static void SetFieldOfView(object camera, float value)
            => throw new PlatformNotSupportedException();
        public static float GetNearClip(object camera)
            => throw new PlatformNotSupportedException();
        public static void SetNearClip(object camera, float value)
            => throw new PlatformNotSupportedException();
        public static float GetFarClip(object camera)
            => throw new PlatformNotSupportedException();
        public static void SetFarClip(object camera, float value)
            => throw new PlatformNotSupportedException();
        public static object GetBackgroundColor(object camera)
            => throw new PlatformNotSupportedException();
        public static void SetBackgroundColor(object camera, object color)
            => throw new PlatformNotSupportedException();
        public static float GetAspect(object camera)
            => throw new PlatformNotSupportedException();
        public static void SetAspect(object camera, float value)
            => throw new PlatformNotSupportedException();
        public static int GetBuffer(object camera)
            => throw new PlatformNotSupportedException();
        public static object ScreenToWorldPoint(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static object ScreenToViewportPoint(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static object WorldToScreenPoint(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static object WorldToViewportPoint(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static object ViewportToWorldPoint(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static object ViewportToScreenPoint(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static object ScreenPointToRay(object camera, object position)
            => throw new PlatformNotSupportedException();
        public static bool SetClearFlags(object camera, int value)
            => throw new PlatformNotSupportedException();
        public static void Clear(object camera, int backgroundColor, float depth)
            => throw new PlatformNotSupportedException();
        public static void Render(object camera)
            => throw new PlatformNotSupportedException();
        public static void RenderWithShader(object camera, object shader, string replacementTag)
            => throw new PlatformNotSupportedException();
    }
}