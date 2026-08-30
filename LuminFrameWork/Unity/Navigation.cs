namespace Unity
{
    /// <summary>Unity NavMeshAgent 寻路/导航钩子入口。</summary>
    public static class NavMesh
    {
        public static bool SetDestination(object agent, object target)
            => throw new PlatformNotSupportedException();
        public static void Stop(object agent)
            => throw new PlatformNotSupportedException();
        public static void Stop(object agent, bool stopUpdates)
            => throw new PlatformNotSupportedException();
        public static void ResetPath(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetPaused(object agent)
            => throw new PlatformNotSupportedException();
        public static void SetPaused(object agent, bool value)
            => throw new PlatformNotSupportedException();
        public static object GetDestination(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetIsOnNavMesh(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetIsStopped(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetHasPath(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetPathPending(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetPathIsComplete(object agent)
            => throw new PlatformNotSupportedException();
        public static bool GetPathIsStale(object agent)
            => throw new PlatformNotSupportedException();
        public static float GetSpeed(object agent)
            => throw new PlatformNotSupportedException();
        public static void SetSpeed(object agent, float value)
            => throw new PlatformNotSupportedException();
        public static float GetAngularSpeed(object agent)
            => throw new PlatformNotSupportedException();
        public static float GetStoppingDistance(object agent)
            => throw new PlatformNotSupportedException();
        public static void SetStoppingDistance(object agent, float value)
            => throw new PlatformNotSupportedException();
        public static float GetAcceleration(object agent)
            => throw new PlatformNotSupportedException();
        public static void SetAcceleration(object agent, float value)
            => throw new PlatformNotSupportedException();
        public static object GetVelocity(object agent)
            => throw new PlatformNotSupportedException();
        public static void SetVelocity(object agent, object velocity)
            => throw new PlatformNotSupportedException();
        public static float GetRemainingDistance(object agent)
            => throw new PlatformNotSupportedException();
        public static float GetBaseOffset(object agent)
            => throw new PlatformNotSupportedException();
        public static int GetAvoidancePriority(object agent)
            => throw new PlatformNotSupportedException();
        public static void SetAvoidancePriority(object agent, int value)
            => throw new PlatformNotSupportedException();
        public static object GetAgentPosition(object agent)
            => throw new PlatformNotSupportedException();
        public static object GetAgentPath(object agent)
            => throw new PlatformNotSupportedException();
    }
}