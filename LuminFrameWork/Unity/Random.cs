namespace Unity
{
    /// <summary>Unity Random 的钩子入口。</summary>
    public static class Random
    {
        public static int Range(int minInclusive, int maxExclusive) => throw new PlatformNotSupportedException();
        public static float Range(float minInclusive, float maxInclusive) => throw new PlatformNotSupportedException();
        public static float GetValue() => throw new PlatformNotSupportedException();
        public static object GetInsideUnitSphere() => throw new PlatformNotSupportedException();
        public static object GetOnUnitSphere() => throw new PlatformNotSupportedException();
        public static object GetInsideUnitCircle() => throw new PlatformNotSupportedException();
        public static object GetRotation() => throw new PlatformNotSupportedException();
        public static object GetRotationUniform() => throw new PlatformNotSupportedException();
        public static object GetUnitVector() => throw new PlatformNotSupportedException();
        public static void SetSeed(int seed) => throw new PlatformNotSupportedException();
        public static long GetSeedInternal() => throw new PlatformNotSupportedException();
        public static int GetState() => throw new PlatformNotSupportedException();
    }
}