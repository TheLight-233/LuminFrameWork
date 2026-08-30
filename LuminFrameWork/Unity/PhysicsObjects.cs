namespace Unity
{
    /// <summary>Unity Rigidbody 刚体动力学钩子入口。</summary>
    public static class Rigidbody
    {
        public static object GetVelocity(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void SetVelocity(object rigidbody, object velocity)
            => throw new PlatformNotSupportedException();
        public static void SetAngularVelocity(object rigidbody, object velocity)
            => throw new PlatformNotSupportedException();
        public static object GetAngularVelocity(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void AddForce(object rigidbody, object force)
            => throw new PlatformNotSupportedException();
        public static void AddForce(object rigidbody, object force, int mode)
            => throw new PlatformNotSupportedException();
        public static void AddForce(object rigidbody, float x, float y, float z, int mode)
            => throw new PlatformNotSupportedException();
        public static void AddTorque(object rigidbody, object torque, int mode)
            => throw new PlatformNotSupportedException();
        public static void AddExplosionForce(object rigidbody, float explosionForce, object explosionPosition, float explosionRadius)
            => throw new PlatformNotSupportedException();
        public static void SetMass(object rigidbody, float value)
            => throw new PlatformNotSupportedException();
        public static float GetMass(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void SetDrag(object rigidbody, float value)
            => throw new PlatformNotSupportedException();
        public static void SetAngularDrag(object rigidbody, float value)
            => throw new PlatformNotSupportedException();
        public static void SetUseGravity(object rigidbody, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetUseGravity(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void SetIsKinematic(object rigidbody, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetIsKinematic(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void SetInterpolation(object rigidbody, int value)
            => throw new PlatformNotSupportedException();
        public static void MakeSleep(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void WakeUp(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static bool GetIsSleeping(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void SetFreezeRotation(object rigidbody, bool value)
            => throw new PlatformNotSupportedException();
        public static void MovePosition(object rigidbody, object position)
            => throw new PlatformNotSupportedException();
        public static void MoveRotation(object rigidbody, object rotation)
            => throw new PlatformNotSupportedException();
        public static void SetDetectionMode(object rigidbody, int value)
            => throw new PlatformNotSupportedException();
        public static object GetPosition(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static object GetRotation(object rigidbody)
            => throw new PlatformNotSupportedException();
        public static void SetInertiaTensor(object rigidbody, object tensor)
            => throw new PlatformNotSupportedException();
        public static object GetInertiaTensor(object rigidbody)
            => throw new PlatformNotSupportedException();
    }
}