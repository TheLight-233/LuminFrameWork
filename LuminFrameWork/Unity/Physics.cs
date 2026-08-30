namespace Unity
{
    /// <summary>Unity 物理（Physics/Raycast 等）的钩子入口。</summary>
    public static class Physics
    {
        public static bool Raycast(object origin, object direction)
            => throw new PlatformNotSupportedException();
        public static bool Raycast(object origin, object direction, float maxDistance)
            => throw new PlatformNotSupportedException();
        public static bool Raycast(object origin, object direction, out object hitInfo, float maxDistance)
            => throw new PlatformNotSupportedException();
        public static bool Raycast(object ray, out object hitInfo)
            => throw new PlatformNotSupportedException();
        public static object[] RaycastAll(object origin, object direction, float maxDistance)
            => throw new PlatformNotSupportedException();
        public static int RaycastNonAlloc(object origin, object direction, object[] results, float maxDistance)
            => throw new PlatformNotSupportedException();

        public static bool SphereCast(object origin, float radius, object direction, out object hitInfo, float maxDistance)
            => throw new PlatformNotSupportedException();
        public static bool BoxCast(object center, object halfExtents, object direction, out object hitInfo, object orientation, float maxDistance)
            => throw new PlatformNotSupportedException();
        public static bool CapsuleCast(object point1, object point2, float radius, object direction, out object hitInfo, float maxDistance)
            => throw new PlatformNotSupportedException();

        public static bool CheckSphere(object position, float radius)
            => throw new PlatformNotSupportedException();
        public static bool CheckBox(object center, object halfExtents, object orientation)
            => throw new PlatformNotSupportedException();
        public static bool CheckCapsule(object start, object end, float radius)
            => throw new PlatformNotSupportedException();

        public static object[] OverlapSphere(object position, float radius)
            => throw new PlatformNotSupportedException();
        public static object[] OverlapBox(object center, object halfExtents, object orientation)
            => throw new PlatformNotSupportedException();
        public static object[] OverlapCapsule(object point0, object point1, float radius)
            => throw new PlatformNotSupportedException();
        public static int OverlapSphereNonAlloc(object position, float radius, object[] results)
            => throw new PlatformNotSupportedException();

        public static object GetGravity()
            => throw new PlatformNotSupportedException();
        public static void SetGravity(object value)
            => throw new PlatformNotSupportedException();
        public static float GetBounceThreshold()
            => throw new PlatformNotSupportedException();
        public static void SetBounceThreshold(float value)
            => throw new PlatformNotSupportedException();
        public static int GetPhysicsLayersQueriesHitTriggers()
            => throw new PlatformNotSupportedException();
        public static bool GetQueriesHitTriggers()
            => throw new PlatformNotSupportedException();
        public static void SetQueriesHitTriggers(bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetAutoSimulation()
            => throw new PlatformNotSupportedException();
        public static void SetAutoSimulation(bool value)
            => throw new PlatformNotSupportedException();
        public static void Simulate(float step)
            => throw new PlatformNotSupportedException();
        public static float GetFixedDeltaTime()
            => throw new PlatformNotSupportedException();
        public static void SetFixedDeltaTime(float value)
            => throw new PlatformNotSupportedException();
    }
}