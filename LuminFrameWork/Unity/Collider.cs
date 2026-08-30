namespace Unity
{
    /// <summary>Unity Collider 碰撞体钩子入口。</summary>
    public static class Collider
    {
        public static bool GetEnabled(object collider) => throw new PlatformNotSupportedException();
        public static void SetEnabled(object collider, bool value) => throw new PlatformNotSupportedException();
        public static bool GetIsTrigger(object collider) => throw new PlatformNotSupportedException();
        public static void SetIsTrigger(object collider, bool value) => throw new PlatformNotSupportedException();
        public static bool GetIsWasTrigger(object collider) => throw new PlatformNotSupportedException();
        public static object GetBounds(object collider) => throw new PlatformNotSupportedException();
        public static object GetAttachedRigidbody(object collider) => throw new PlatformNotSupportedException();
        public static object GetMaterial(object collider) => throw new PlatformNotSupportedException();
        public static bool GetContactTestValue(object collider) => throw new PlatformNotSupportedException();
        public static bool GetContactTestValue(object collider, ref object collider2) => throw new PlatformNotSupportedException();
        public static void SetAttachedRigidbody(object collider, object body) => throw new PlatformNotSupportedException();
        public static void SetCenter(object collider, object center) => throw new PlatformNotSupportedException();
        public static object GetCenter(object collider) => throw new PlatformNotSupportedException();
        public static void SetSize(object collider, object size) => throw new PlatformNotSupportedException();
        public static object GetSize(object collider) => throw new PlatformNotSupportedException();
        public static void SetRadius(object collider, float value) => throw new PlatformNotSupportedException();
        public static float GetRadius(object collider) => throw new PlatformNotSupportedException();
        public static void SetHeight(object collider, float value) => throw new PlatformNotSupportedException();
        public static float GetHeight(object collider) => throw new PlatformNotSupportedException();
        public static void SetDirection(object collider, int value) => throw new PlatformNotSupportedException();
        public static object ClosestPoint(object collider, object position) => throw new PlatformNotSupportedException();
        public static void SetTriggerEnabled(object collider, bool value) => throw new PlatformNotSupportedException();
    }
}