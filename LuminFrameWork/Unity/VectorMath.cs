namespace Unity
{
    /// <summary>Unity Vector3 静态数学钩子入口。</summary>
    public static class Vector3
    {
        public static object Get(float x, float y, float z) => throw new PlatformNotSupportedException();
        public static object Distance(object a, object b) => throw new PlatformNotSupportedException();
        public static object SqrMagnitude(object v) => throw new PlatformNotSupportedException();
        public static object Dot(object a, object b) => throw new PlatformNotSupportedException();
        public static object Cross(object a, object b) => throw new PlatformNotSupportedException();
        public static object Lerp(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object LerpUnclamped(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object Slerp(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object Normalize(object v) => throw new PlatformNotSupportedException();
        public static object Magnitude(object v) => throw new PlatformNotSupportedException();
        public static object MoveTowards(object current, object target, float maxDistanceDelta) => throw new PlatformNotSupportedException();
        public static object Reflect(object inDirection, object inNormal) => throw new PlatformNotSupportedException();
        public static object Project(object vector, object onNormal) => throw new PlatformNotSupportedException();
        public static object Scale(object a, object b) => throw new PlatformNotSupportedException();
        public static object SmoothDamp(object current, object target, ref object currentVelocity, float smoothTime) => throw new PlatformNotSupportedException();
        public static object Angle(object a, object b) => throw new PlatformNotSupportedException();
        public static object SignedAngle(object a, object b, object axis) => throw new PlatformNotSupportedException();
        public static object GetForward() => throw new PlatformNotSupportedException();
        public static object GetBack() => throw new PlatformNotSupportedException();
        public static object GetUp() => throw new PlatformNotSupportedException();
        public static object GetDown() => throw new PlatformNotSupportedException();
        public static object GetLeft() => throw new PlatformNotSupportedException();
        public static object GetRight() => throw new PlatformNotSupportedException();
        public static object GetZero() => throw new PlatformNotSupportedException();
        public static object GetOne() => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Vector2 静态数学钩子入口。</summary>
    public static class Vector2
    {
        public static object Get(float x, float y) => throw new PlatformNotSupportedException();
        public static object Distance(object a, object b) => throw new PlatformNotSupportedException();
        public static object Dot(object a, object b) => throw new PlatformNotSupportedException();
        public static object Lerp(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object LerpUnclamped(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object Normalize(object v) => throw new PlatformNotSupportedException();
        public static object Magnitude(object v) => throw new PlatformNotSupportedException();
        public static object MoveTowards(object current, object target, float maxDistanceDelta) => throw new PlatformNotSupportedException();
        public static object Perpendicular(object v) => throw new PlatformNotSupportedException();
        public static object Reflect(object inDirection, object inNormal) => throw new PlatformNotSupportedException();
        public static object Scale(object a, object b) => throw new PlatformNotSupportedException();
        public static object SmoothDamp(object current, object target, ref object currentVelocity, float smoothTime) => throw new PlatformNotSupportedException();
        public static float Angle(object a, object b) => throw new PlatformNotSupportedException();
        public static float SignedAngle(object a, object b) => throw new PlatformNotSupportedException();
        public static object GetUp() => throw new PlatformNotSupportedException();
        public static object GetDown() => throw new PlatformNotSupportedException();
        public static object GetLeft() => throw new PlatformNotSupportedException();
        public static object GetRight() => throw new PlatformNotSupportedException();
        public static object GetZero() => throw new PlatformNotSupportedException();
        public static object GetOne() => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Quaternion / 旋转静态钩子入口。</summary>
    public static class Quaternion
    {
        public static object Euler(float x, float y, float z) => throw new PlatformNotSupportedException();
        public static object Euler(object euler) => throw new PlatformNotSupportedException();
        public static object AngleAxis(float angle, object axis) => throw new PlatformNotSupportedException();
        public static object LookRotation(object forward) => throw new PlatformNotSupportedException();
        public static object LookRotation(object forward, object upwards) => throw new PlatformNotSupportedException();
        public static object FromToRotation(object fromDirection, object toDirection) => throw new PlatformNotSupportedException();
        public static object Slerp(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object Lerp(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object RotateTowards(object from, object to, float maxDegreesDelta) => throw new PlatformNotSupportedException();
        public static float Angle(object a, object b) => throw new PlatformNotSupportedException();
        public static object Dot(object a, object b) => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Color / 颜色静态钩子入口。</summary>
    public static class Color
    {
        public static object Get(float r, float g, float b) => throw new PlatformNotSupportedException();
        public static object Get(float r, float g, float b, float a) => throw new PlatformNotSupportedException();
        public static object Lerp(object a, object b, float t) => throw new PlatformNotSupportedException();
        public static object GetRGB(float value) => throw new PlatformNotSupportedException();
        public static object GetRGBA(float value) => throw new PlatformNotSupportedException();
        public static object GetRed() => throw new PlatformNotSupportedException();
        public static object GetGreen() => throw new PlatformNotSupportedException();
        public static object GetBlue() => throw new PlatformNotSupportedException();
        public static object GetWhite() => throw new PlatformNotSupportedException();
        public static object GetBlack() => throw new PlatformNotSupportedException();
        public static object GetYellow() => throw new PlatformNotSupportedException();
        public static object GetGrey() => throw new PlatformNotSupportedException();
        public static object GetMagenta() => throw new PlatformNotSupportedException();
        public static object GetClear() => throw new PlatformNotSupportedException();
    }
}