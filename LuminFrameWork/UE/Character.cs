namespace UE
{
    /// <summary>UE ACharacter / 角色移动钩子入口。</summary>
    public static class Character
    {
        public static object GetCharacterMovement(object character) => throw new PlatformNotSupportedException();
        public static object GetController(object character) => throw new PlatformNotSupportedException();
        public static object GetMesh(object character) => throw new PlatformNotSupportedException();
        public static object GetCapsuleComponent(object character) => throw new PlatformNotSupportedException();
        public static object GetCharacterName(object character) => throw new PlatformNotSupportedException();
        public static void Destroy(object character) => throw new PlatformNotSupportedException();
        public static object GetPawnRoleUid(object character) => throw new PlatformNotSupportedException();
        public static object GetLastHitResult(object character) => throw new PlatformNotSupportedException();
        public static bool GetWasJumping(object character) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE UCharacterMovementComponent / 角色移动组件钩子入口。</summary>
    public static class CharacterMovement
    {
        public static void SetMovementMode(object movement, int newMovementMode) => throw new PlatformNotSupportedException();
        public static object GetMovementMode(object movement) => throw new PlatformNotSupportedException();
        public static void SetWalkSpeed(object movement, float speed) => throw new PlatformNotSupportedException();
        public static float GetWalkSpeed(object movement) => throw new PlatformNotSupportedException();
        public static void SetRunSpeed(object movement, float speed) => throw new PlatformNotSupportedException();
        public static float GetRunSpeed(object movement) => throw new PlatformNotSupportedException();
        public static void SetJumpForce(object movement, float jumpForce) => throw new PlatformNotSupportedException();
        public static void SetAirControl(object movement, float airControl) => throw new PlatformNotSupportedException();
        public static float GetMaxJumpHeight(object movement) => throw new PlatformNotSupportedException();
        public static float GetMaxSpeed(object movement) => throw new PlatformNotSupportedException();
        public static void SetFallingPhysics(object movement, float value) => throw new PlatformNotSupportedException();
        public static void AddImpulse(object movement, object impulse) => throw new PlatformNotSupportedException();
        public static void AddForce(object movement, object force) => throw new PlatformNotSupportedException();
        public static void StopMovementImmediately(object movement) => throw new PlatformNotSupportedException();
        public static object GetVelocity(object movement) => throw new PlatformNotSupportedException();
        public static bool GetIsFalling(object movement) => throw new PlatformNotSupportedException();
        public static bool GetIsGrounded(object movement) => throw new PlatformNotSupportedException();
        public static bool GetIsJumping(object movement) => throw new PlatformNotSupportedException();
        public static void MoveSmooth(object movement, object velocity) => throw new PlatformNotSupportedException();
        public static object GetVelocitySmoothing(object movement) => throw new PlatformNotSupportedException();
        public static void SetTickTaskGroup(object movement, int value) => throw new PlatformNotSupportedException();
        public static void SetPlaneConstraint(bool value, object planeNormal) => throw new PlatformNotSupportedException();
        public static void SetPlaneConstraintEnabled(bool value) => throw new PlatformNotSupportedException();
        public static void SetPlaneConstraintOrigin(object origin) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE USpringArmComponent / 弹簧臂相机钩子入口。</summary>
    public static class SpringArm
    {
        public static void SetTargetArmLength(object arm, float length) => throw new PlatformNotSupportedException();
        public static float GetTargetArmLength(object arm) => throw new PlatformNotSupportedException();
        public static void SetRelativeToView(object arm, bool value) => throw new PlatformNotSupportedException();
        public static void SetChildRelativeRotation(object arm, object rotation) => throw new PlatformNotSupportedException();
        public static object GetHitResult(object arm) => throw new PlatformNotSupportedException();
        public static void SetExitRotationSpeed(object arm, float value) => throw new PlatformNotSupportedException();
    }
}