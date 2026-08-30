namespace Unity
{
    /// <summary>Unity LayerMask / 图层的钩子入口。</summary>
    public static class LayerMask
    {
        public static int NameToLayer(string layerName) => throw new PlatformNotSupportedException();
        public static string LayerToName(int layer) => throw new PlatformNotSupportedException();
        public static int GetMask(params string[] layerNames) => throw new PlatformNotSupportedException();
        public static int GetValue(object layerMask) => throw new PlatformNotSupportedException();
        public static bool Contains(object layerMask, int layer) => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Physics2D 2D 物理钩子入口。</summary>
    public static class Physics2D
    {
        public static bool Raycast(object origin, object direction, out object hitInfo, float distance = float.PositiveInfinity)
        {
            throw new PlatformNotSupportedException();
        }
        public static object[] RaycastAll(object origin, object direction, float distance)
            => throw new PlatformNotSupportedException();
        public static bool BoxCast(object origin, object size, float angle, object direction, out object hitInfo, float distance)
            => throw new PlatformNotSupportedException();
        public static bool CircleCast(object origin, float radius, object direction, out object hitInfo, float distance)
            => throw new PlatformNotSupportedException();
        public static bool CapsuleCast(object origin, object size, int capsuleDirection, float angle, object direction, out object hitInfo, float distance)
            => throw new PlatformNotSupportedException();
        public static object[] OverlapCircle(object center, float radius, object layerMask)
            => throw new PlatformNotSupportedException();
        public static object[] OverlapBox(object center, object size, float angle)
            => throw new PlatformNotSupportedException();
        public static object[] GetContacts(object body)
            => throw new PlatformNotSupportedException();
        public static float GetGravityMagnitude()
            => throw new PlatformNotSupportedException();
        public static object GetGravity()
            => throw new PlatformNotSupportedException();
        public static void SetGravity(object value)
            => throw new PlatformNotSupportedException();
        public static bool GetQueriesHitTriggers()
            => throw new PlatformNotSupportedException();
        public static void SetQueriesHitTriggers(bool value)
            => throw new PlatformNotSupportedException();
        public static float GetDefaultContactOffset()
            => throw new PlatformNotSupportedException();
        public static bool GetAutoSimulation()
            => throw new PlatformNotSupportedException();
        public static void SetAutoSimulation(bool value)
            => throw new PlatformNotSupportedException();
        public static void Simulate(float step)
            => throw new PlatformNotSupportedException();
    }
}