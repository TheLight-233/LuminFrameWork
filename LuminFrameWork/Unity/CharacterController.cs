namespace Unity
{
    /// <summary>Unity CharacterController 角色控制器钩子入口。</summary>
    public static class CharacterController
    {
        public static object Move(object controller, object motion) => throw new PlatformNotSupportedException();
        public static object SimpleMove(object controller, object speed) => throw new PlatformNotSupportedException();
        public static bool GetIsGrounded(object controller) => throw new PlatformNotSupportedException();
        public static object GetVelocity(object controller) => throw new PlatformNotSupportedException();
        public static object GetCenter(object controller) => throw new PlatformNotSupportedException();
        public static float GetHeight(object controller) => throw new PlatformNotSupportedException();
        public static void SetHeight(object controller, float value) => throw new PlatformNotSupportedException();
        public static float GetRadius(object controller) => throw new PlatformNotSupportedException();
        public static void SetRadius(object controller, float value) => throw new PlatformNotSupportedException();
        public static float GetSlopeLimit(object controller) => throw new PlatformNotSupportedException();
        public static void SetSlopeLimit(object controller, float value) => throw new PlatformNotSupportedException();
        public static float GetStepOffset(object controller) => throw new PlatformNotSupportedException();
        public static void SetStepOffset(object controller, float value) => throw new PlatformNotSupportedException();
        public static float GetSkinWidth(object controller) => throw new PlatformNotSupportedException();
        public static void SetSkinWidth(object controller, float value) => throw new PlatformNotSupportedException();
        public static float GetMinMoveDistance(object controller) => throw new PlatformNotSupportedException();
        public static object GetCollisionsFlags(object controller) => throw new PlatformNotSupportedException();
        public static void SetEnableOverlapRecovery(object controller, bool value) => throw new PlatformNotSupportedException();
        public static object GetDetectCollisions(object controller) => throw new PlatformNotSupportedException();
        public static void SetDetectCollisions(object controller, bool value) => throw new PlatformNotSupportedException();
        public static bool IsTouching(object controller, object collider) => throw new PlatformNotSupportedException();
        public static void SetWasEnabled(object controller, bool value) => throw new PlatformNotSupportedException();
    }
}