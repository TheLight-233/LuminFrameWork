namespace UE
{
    /// <summary>UE UKismetMathLibrary 蓝图数学钩子入口。</summary>
    public static class MathLibrary
    {
        public static float Abs(float value) => throw new PlatformNotSupportedException();
        public static float Clamp(float value, float min, float max) => throw new PlatformNotSupportedException();
        public static float ClampAxis(float angle) => throw new PlatformNotSupportedException();
        public static float NormalizeAxis(float angle) => throw new PlatformNotSupportedException();
        public static float Lerp(float current, float target, float alpha) => throw new PlatformNotSupportedException();
        public static float LerpUnclamped(float a, float b, float alpha) => throw new PlatformNotSupportedException();
        public static float InverseLerp(float a, float b, float value) => throw new PlatformNotSupportedException();
        public static float FInterpTol(float current, float target, float alpha, float tolerance) => throw new PlatformNotSupportedException();
        public static float MoveWithTarget(float current, float target, float moveAmount) => throw new PlatformNotSupportedException();
        public static float FMin(float a, float b) => throw new PlatformNotSupportedException();
        public static float FMax(float a, float b) => throw new PlatformNotSupportedException();
        public static float Sign(float value) => throw new PlatformNotSupportedException();
        public static float Square(float value) => throw new PlatformNotSupportedException();
        public static float Fmod(float dividend, float divisor) => throw new PlatformNotSupportedException();
        public static float DegreesToRadians(float value) => throw new PlatformNotSupportedException();
        public static float RadiansToDegrees(float value) => throw new PlatformNotSupportedException();
        public static float Sin(float value) => throw new PlatformNotSupportedException();
        public static float Cos(float value) => throw new PlatformNotSupportedException();
        public static float Tan(float value) => throw new PlatformNotSupportedException();
        public static float Asin(float value) => throw new PlatformNotSupportedException();
        public static float Acos(float value) => throw new PlatformNotSupportedException();
        public static float Atan(float value) => throw new PlatformNotSupportedException();
        public static float Atan2(float y, float x) => throw new PlatformNotSupportedException();
        public static float Sqrt(float value) => throw new PlatformNotSupportedException();
        public static float Pow(float value, float power) => throw new PlatformNotSupportedException();
        public static float Exp(float value) => throw new PlatformNotSupportedException();
        public static float Log(float value, float baseValue) => throw new PlatformNotSupportedException();
        public static float Floor(float value) => throw new PlatformNotSupportedException();
        public static float Ceiling(float value) => throw new PlatformNotSupportedException();
        public static float Round(float value) => throw new PlatformNotSupportedException();
        public static int RandomInteger(int min, int max) => throw new PlatformNotSupportedException();
        public static float RandomFloat(float min, float max) => throw new PlatformNotSupportedException();
        public static bool RandomBool(float chance) => throw new PlatformNotSupportedException();
        public static object RandomUnitVector() => throw new PlatformNotSupportedException();
        public static object RandomUnitVectorInCone(object vector, float coneHalfAngleDeg) => throw new PlatformNotSupportedException();
        public static object RandomRotator(bool rollIsYaw = true) => throw new PlatformNotSupportedException();
        public static object RandomPointInBoundingBox(object origin, object boxExtent) => throw new PlatformNotSupportedException();
        public static bool IsValid(object value) => throw new PlatformNotSupportedException();
        public static bool NearlyEqual(float a, float b, float epsilon) => throw new PlatformNotSupportedException();
        public static bool InRange(float value, float min, float max) => throw new PlatformNotSupportedException();
        public static bool IsEven(int value) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE FVector / 向量数学钩子入口。</summary>
    public static class Vector
    {
        public static object Add(object a, object b) => throw new PlatformNotSupportedException();
        public static object Subtract(object a, object b) => throw new PlatformNotSupportedException();
        public static object Multiply(object a, float scale) => throw new PlatformNotSupportedException();
        public static object Divide(object a, float scale) => throw new PlatformNotSupportedException();
        public static object Negated(object v) => throw new PlatformNotSupportedException();
        public static object Clone(object v) => throw new PlatformNotSupportedException();
        public static object Normal(object v) => throw new PlatformNotSupportedException();
        public static object NormalizedSafe(object v) => throw new PlatformNotSupportedException();
        public static float Dot(object a, object b) => throw new PlatformNotSupportedException();
        public static object Cross(object a, object b) => throw new PlatformNotSupportedException();
        public static float Size(object v) => throw new PlatformNotSupportedException();
        public static float SizeSquared(object v) => throw new PlatformNotSupportedException();
        public static float Distance(object a, object b) => throw new PlatformNotSupportedException();
        public static float DistanceSquared2D(object a, object b) => throw new PlatformNotSupportedException();
        public static object Lerp(object a, object b, float alpha) => throw new PlatformNotSupportedException();
        public static object Slerp(object a, object b, float alpha) => throw new PlatformNotSupportedException();
        public static object MoveTowards(object a, object b, float delta) => throw new PlatformNotSupportedException();
        public static object ClampSize(object v, float maxSize) => throw new PlatformNotSupportedException();
        public static object ProjectOnTo(object v, object target) => throw new PlatformNotSupportedException();
        public static object ProjectOnToNormal(object v, object target) => throw new PlatformNotSupportedException();
        public static object GetUpVector() => throw new PlatformNotSupportedException();
        public static object GetForwardVector() => throw new PlatformNotSupportedException();
        public static object GetRightVector() => throw new PlatformNotSupportedException();
        public static object GetZeroVector() => throw new PlatformNotSupportedException();
        public static object GetOneVector() => throw new PlatformNotSupportedException();
        public static object GetRotator(object v) => throw new PlatformNotSupportedException();
        public static object MirrorVectorByNormal(object vector, object normal) => throw new PlatformNotSupportedException();
        public static object MakeVector(float x, float y, float z) => throw new PlatformNotSupportedException();
    }
}