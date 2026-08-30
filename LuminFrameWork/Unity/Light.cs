namespace Unity
{
    /// <summary>Unity Light 光源钩子入口。</summary>
    public static class Light
    {
        public static void SetEnabled(object light, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetEnabled(object light)
            => throw new PlatformNotSupportedException();
        public static void SetType(object light, int value)
            => throw new PlatformNotSupportedException();
        public static int GetType(object light)
            => throw new PlatformNotSupportedException();
        public static void SetColor(object light, object color)
            => throw new PlatformNotSupportedException();
        public static object GetColor(object light)
            => throw new PlatformNotSupportedException();
        public static void SetIntensity(object light, float value)
            => throw new PlatformNotSupportedException();
        public static float GetIntensity(object light)
            => throw new PlatformNotSupportedException();
        public static void SetRange(object light, float value)
            => throw new PlatformNotSupportedException();
        public static float GetRange(object light)
            => throw new PlatformNotSupportedException();
        public static void SetSpotAngle(object light, float value)
            => throw new PlatformNotSupportedException();
        public static float GetSpotAngle(object light)
            => throw new PlatformNotSupportedException();
        public static void SetShadows(object light, int value)
            => throw new PlatformNotSupportedException();
        public static void SetCookie(object light, object texture)
            => throw new PlatformNotSupportedException();
        public static void SetShadowsStrength(object light, float value)
            => throw new PlatformNotSupportedException();
        public static float GetShadowsStrength(object light)
            => throw new PlatformNotSupportedException();
        public static bool GetIsBaked(object light)
            => throw new PlatformNotSupportedException();
        public static void SetBounceIntensity(object light, float value)
            => throw new PlatformNotSupportedException();
        public static void SetRenderMode(object light, int value)
            => throw new PlatformNotSupportedException();
    }
}