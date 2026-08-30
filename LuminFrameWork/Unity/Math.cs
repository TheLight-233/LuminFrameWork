namespace Unity
{
    /// <summary>Unity Mathf 数学函数钩子入口。</summary>
    public static class Math
    {
        public static float Abs(float value) => throw new PlatformNotSupportedException();
        public static int Abs(int value) => throw new PlatformNotSupportedException();
        public static float Sqrt(float value) => throw new PlatformNotSupportedException();
        public static float Pow(float value, float power) => throw new PlatformNotSupportedException();
        public static float Exp(float power) => throw new PlatformNotSupportedException();
        public static float Floor(float value) => throw new PlatformNotSupportedException();
        public static int FloorToInt(float value) => throw new PlatformNotSupportedException();
        public static float Ceil(float value) => throw new PlatformNotSupportedException();
        public static int CeilToInt(float value) => throw new PlatformNotSupportedException();
        public static float Round(float value) => throw new PlatformNotSupportedException();
        public static int RoundToInt(float value) => throw new PlatformNotSupportedException();

        public static float Clamp(float value, float min, float max) => throw new PlatformNotSupportedException();
        public static int Clamp(int value, int min, int max) => throw new PlatformNotSupportedException();
        public static float Clamp01(float value) => throw new PlatformNotSupportedException();
        public static float Min(float a, float b) => throw new PlatformNotSupportedException();
        public static float Max(float a, float b) => throw new PlatformNotSupportedException();
        public static int Min(int a, int b) => throw new PlatformNotSupportedException();
        public static int Max(int a, int b) => throw new PlatformNotSupportedException();

        public static float Lerp(float a, float b, float t) => throw new PlatformNotSupportedException();
        public static float LerpUnclamped(float a, float b, float t) => throw new PlatformNotSupportedException();
        public static float InverseLerp(float a, float b, float value) => throw new PlatformNotSupportedException();
        public static float MoveTowards(float current, float target, float maxDelta) => throw new PlatformNotSupportedException();
        public static float MoveTowardsAngle(float current, float target, float maxDelta) => throw new PlatformNotSupportedException();
        public static float SmoothStep(float from, float to, float t) => throw new PlatformNotSupportedException();
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime) => throw new PlatformNotSupportedException();
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => throw new PlatformNotSupportedException();

        public static float Sin(float value) => throw new PlatformNotSupportedException();
        public static float Cos(float value) => throw new PlatformNotSupportedException();
        public static float Tan(float value) => throw new PlatformNotSupportedException();
        public static float Asin(float value) => throw new PlatformNotSupportedException();
        public static float Acos(float value) => throw new PlatformNotSupportedException();
        public static float Atan(float value) => throw new PlatformNotSupportedException();
        public static float Atan2(float y, float x) => throw new PlatformNotSupportedException();
        public static float Sign(float value) => throw new PlatformNotSupportedException();

        public static float Repeat(float t, float length) => throw new PlatformNotSupportedException();
        public static float PingPong(float t, float length) => throw new PlatformNotSupportedException();
        public static float DeltaAngle(float current, float target) => throw new PlatformNotSupportedException();
        public static float LerpAngle(float a, float b, float t) => throw new PlatformNotSupportedException();
        public static float PerlinNoise(float x, float y) => throw new PlatformNotSupportedException();
        public static float PerlinNoise1D(float x) => throw new PlatformNotSupportedException();

        public static float GetDeg2Rad() => throw new PlatformNotSupportedException();
        public static float GetRad2Deg() => throw new PlatformNotSupportedException();
        public static float GetPI() => throw new PlatformNotSupportedException();
        public static float GetInfinity() => throw new PlatformNotSupportedException();
        public static float GetNegativeInfinity() => throw new PlatformNotSupportedException();
        public static float GetEpsilon() => throw new PlatformNotSupportedException();
    }
}