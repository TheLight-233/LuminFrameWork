namespace UE
{
    /// <summary>UE 物理 / 碰撞检测钩子入口。</summary>
    public static class Physics
    {
        public static bool LineTraceByChannel(object worldContext, object start, object end, int traceChannel, bool bTraceComplex, out object outHit) => throw new PlatformNotSupportedException();
        public static object[] LineTraceByChannelArray(object worldContext, object start, object end, int traceChannel, bool bTraceComplex) => throw new PlatformNotSupportedException();
        public static object[] LineTraceMultiByChannel(object worldContext, object start, object end, int traceChannel, bool bTraceComplex) => throw new PlatformNotSupportedException();
        public static bool SphereTraceByChannel(object worldContext, object start, object end, float radius, int traceChannel, bool bTraceComplex, out object outHit) => throw new PlatformNotSupportedException();
        public static bool BoxTraceByChannel(object worldContext, object start, object end, object halfSize, object orientation, int traceChannel, bool bTraceComplex, out object outHit) => throw new PlatformNotSupportedException();
        public static bool CapsuleTraceByChannel(object worldContext, object start, object end, float radius, float halfHeight, int traceChannel, bool bTraceComplex, out object outHit) => throw new PlatformNotSupportedException();
        public static bool ActorHasTag(object actor, string tag) => throw new PlatformNotSupportedException();
        public static object GetActorOverlap(object actor) => throw new PlatformNotSupportedException();
        public static object[] GetOverlappingActorsOfClass(object actor) => throw new PlatformNotSupportedException();
        public static object GetHitActor(object hit) => throw new PlatformNotSupportedException();
        public static object GetHitComponent(object hit) => throw new PlatformNotSupportedException();
        public static object GetHitImpactPoint(object hit) => throw new PlatformNotSupportedException();
        public static object GetHitImpactNormal(object hit) => throw new PlatformNotSupportedException();
        public static object GetHitBoneName(object hit) => throw new PlatformNotSupportedException();
        public static bool GetHitBlockingHit(object hit) => throw new PlatformNotSupportedException();
        public static float GetHitTime(object hit) => throw new PlatformNotSupportedException();
        public static object GetHitDistance(object hit) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE UPrimitiveComponent 骨架碰撞钩子入口。</summary>
    public static class PrimitiveComponent
    {
        public static void SetCollisionEnabled(object component, int collisionType) => throw new PlatformNotSupportedException();
        public static object GetCollisionEnabled(object component) => throw new PlatformNotSupportedException();
        public static void SetCollisionObjectType(object component, int channel) => throw new PlatformNotSupportedException();
        public static void SetCollisionResponseToChannel(object component, int channel, int response) => throw new PlatformNotSupportedException();
        public static void SetCollisionResponseToAllChannels(object component, int response) => throw new PlatformNotSupportedException();
        public static void SetSimulatePhysics(object component, bool simulate) => throw new PlatformNotSupportedException();
        public static bool GetSimulatePhysics(object component) => throw new PlatformNotSupportedException();
        public static void SetEnableGravity(object component, bool value) => throw new PlatformNotSupportedException();
        public static object GetPhysicsLinearVelocity(object component) => throw new PlatformNotSupportedException();
        public static object GetPhysicsAngularVelocity(object component) => throw new PlatformNotSupportedException();
        public static void AddImpulse(object component, object impulse, object? affectedActors = null) => throw new PlatformNotSupportedException();
        public static void AddForce(object component, object force, object? affectedActors = null) => throw new PlatformNotSupportedException();
        public static void SetAllPhysicsLinearVelocity(object component, object velocity) => throw new PlatformNotSupportedException();
        public static object GetOverlappingComponents(object component) => throw new PlatformNotSupportedException();
        public static void SetMass(object component, float mass) => throw new PlatformNotSupportedException();
        public static float GetMass(object component) => throw new PlatformNotSupportedException();
        public static void SetBoundsScale(object component, float newBoundsScale) => throw new PlatformNotSupportedException();
        public static void SetHiddenInGame(object component, bool value, bool propagateToChildren = false) => throw new PlatformNotSupportedException();
    }
}