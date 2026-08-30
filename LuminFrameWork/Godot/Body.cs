namespace Godot
{
    /// <summary>Godot CharacterBody2D/3D 角色移动钩子入口。</summary>
    public static class CharacterBody
    {
        public static void MoveAndSlide(object body) => throw new PlatformNotSupportedException();
        public static object MoveAndCollide(object body, object motion, bool testOnly = false, bool safeMargin = true, bool recoveryAsCollision = false) => throw new PlatformNotSupportedException();
        public static void SetVelocity(object body, object velocity) => throw new PlatformNotSupportedException();
        public static object GetVelocity(object body) => throw new PlatformNotSupportedException();
        public static double GetUpDirection(object body) => throw new PlatformNotSupportedException();
        public static void SetUpDirection(object body, double value) => throw new PlatformNotSupportedException();
        public static object GetFloorNormal(object body) => throw new PlatformNotSupportedException();
        public static bool GetIsOnFloor(object body) => throw new PlatformNotSupportedException();
        public static bool GetIsOnFloorOnly(object body) => throw new PlatformNotSupportedException();
        public static bool GetIsOnCeiling(object body) => throw new PlatformNotSupportedException();
        public static bool GetIsOnWall(object body) => throw new PlatformNotSupportedException();
        public static object GetWallNormal(object body) => throw new PlatformNotSupportedException();
        public static object GetFloorNormal2D(object body) => throw new PlatformNotSupportedException();
        public static bool GetSlideCollisionCount(object body, int collisionNumber, out object collision) => throw new PlatformNotSupportedException();
        public static object GetLastSlideCollision(object body) => throw new PlatformNotSupportedException();
        public static object GetCollider(object collision) => throw new PlatformNotSupportedException();
        public static double GetCollisionAngle(object collision) => throw new PlatformNotSupportedException();
        public static object GetCollisionPosition(object collision) => throw new PlatformNotSupportedException();
        public static object GetCollisionNormal(object collision) => throw new PlatformNotSupportedException();
        public static void ApplyFloorSnap(object body) => throw new PlatformNotSupportedException();
        public static void SetFloorStopOnSlope(object body, bool value) => throw new PlatformNotSupportedException();
        public static object GetFloorMaxAngle(object body) => throw new PlatformNotSupportedException();
        public static object GetFloorSnapLength(object body) => throw new PlatformNotSupportedException();
        public static void SetFloorSnapLength(object body, object value) => throw new PlatformNotSupportedException();
        public static void SetAxisLock(object body, int axis, bool enabled) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot RigidBody / 刚体动力学钩子入口。</summary>
    public static class RigidBody
    {
        public static object GetLinearVelocity(object body) => throw new PlatformNotSupportedException();
        public static void SetLinearVelocity(object body, object velocity) => throw new PlatformNotSupportedException();
        public static object GetAngularVelocity(object body) => throw new PlatformNotSupportedException();
        public static void SetAngularVelocity(object body, object velocity) => throw new PlatformNotSupportedException();
        public static void ApplyCentralForce(object body, object force) => throw new PlatformNotSupportedException();
        public static void ApplyForce(object body, object force, object position) => throw new PlatformNotSupportedException();
        public static void ApplyCentralImpulse(object body, object impulse) => throw new PlatformNotSupportedException();
        public static void ApplyImpulse(object body, object impulse, object position) => throw new PlatformNotSupportedException();
        public static void ApplyTorque(object body, object torque) => throw new PlatformNotSupportedException();
        public static void SetMass(object body, float value) => throw new PlatformNotSupportedException();
        public static float GetMass(object body) => throw new PlatformNotSupportedException();
        public static float GetWeight(object body) => throw new PlatformNotSupportedException();
        public static float GetInertia(object body) => throw new PlatformNotSupportedException();
        public static void SetGravityScale(object body, float value) => throw new PlatformNotSupportedException();
        public static void SetFreeze(object body, bool value) => throw new PlatformNotSupportedException();
        public static void SetFreezeMode(object body, int value) => throw new PlatformNotSupportedException();
        public static object GetMassProperties(object body) => throw new PlatformNotSupportedException();
        public static void SetLinearDamp(object body, float value) => throw new PlatformNotSupportedException();
        public static void SetAngularDamp(object body, float value) => throw new PlatformNotSupportedException();
        public static void SetContactMonitor(object body, bool value) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot RayCast / Area 检测钩子入口。</summary>
    public static class Body2D
    {
        public static void SetTargetPosition(object ray, object position) => throw new PlatformNotSupportedException();
        public static object GetTargetPosition(object ray) => throw new PlatformNotSupportedException();
        public static bool IsColliding(object ray) => throw new PlatformNotSupportedException();
        public static object GetCollider(object ray) => throw new PlatformNotSupportedException();
        public static object GetColliderPoint(object ray) => throw new PlatformNotSupportedException();
        public static object GetColliderNormal(object ray) => throw new PlatformNotSupportedException();
        public static void ForceRaycastUpdate(object ray) => throw new PlatformNotSupportedException();
        public static void SetEnabled(object ray, bool value) => throw new PlatformNotSupportedException();
        public static bool GetEnabled(object ray) => throw new PlatformNotSupportedException();
        public static void SetExcludeParent(object ray, bool value) => throw new PlatformNotSupportedException();
    }
}