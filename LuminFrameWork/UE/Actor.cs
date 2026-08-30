namespace UE
{
    /// <summary>UE AActor / 提成体钩子入口。</summary>
    public static class Actor
    {
        public static string GetActorLabel(object actor) => throw new PlatformNotSupportedException();
        public static void SetActorLabel(object actor, string label) => throw new PlatformNotSupportedException();
        public static bool SetActorHidden(object actor, bool value) => throw new PlatformNotSupportedException();
        public static object SetActorLocation(object actor, object newLocation) => throw new PlatformNotSupportedException();
        public static object SetActorLocationAndRotation(object actor, object newLocation, object newRotation) => throw new PlatformNotSupportedException();
        public static object GetActorLocation(object actor) => throw new PlatformNotSupportedException();
        public static object GetActorTransform(object actor) => throw new PlatformNotSupportedException();
        public static object SetActorTransform(object actor, object transform) => throw new PlatformNotSupportedException();
        public static object AddActorLocalOffset(object actor, object deltaLocation, object? sweep = null) => throw new PlatformNotSupportedException();
        public static object AddActorWorldOffset(object actor, object deltaLocation, object? sweep = null) => throw new PlatformNotSupportedException();
        public static object GetActorRotation(object actor) => throw new PlatformNotSupportedException();
        public static object SetActorRotation(object actor, object newRotation) => throw new PlatformNotSupportedException();
        public static object SetActorScale3D(object actor, object newScale) => throw new PlatformNotSupportedException();
        public static object GetActorScale3D(object actor) => throw new PlatformNotSupportedException();
        public static object GetForwardVector(object actor) => throw new PlatformNotSupportedException();
        public static object GetRightVector(object actor) => throw new PlatformNotSupportedException();
        public static object GetUpVector(object actor) => throw new PlatformNotSupportedException();
        public static object GetActorRight(object actor) => throw new PlatformNotSupportedException();
        public static object AddActorLocalRotation(object actor, object deltaRotation, object? sweep = null) => throw new PlatformNotSupportedException();
        public static object AddActorWorldRotation(object actor, object deltaRotation, object? sweep = null) => throw new PlatformNotSupportedException();
        public static object GetActorVelocity(object actor) => throw new PlatformNotSupportedException();
        public static object GetActorDimensions(object actor) => throw new PlatformNotSupportedException();
        public static object GetActorBounds(object actor) => throw new PlatformNotSupportedException();
        public static object GetActorBoundsCenter(object actor, out object origin) => throw new PlatformNotSupportedException();
        public static object GetActorOverlapCount(object actor) => throw new PlatformNotSupportedException();
        public static object GetAttachedActors(object actor) => throw new PlatformNotSupportedException();
        public static object GetAttachParentActor(object actor) => throw new PlatformNotSupportedException();
        public static object GetChildActors(object actor) => throw new PlatformNotSupportedException();
        public static bool GetTickEnabled(object actor) => throw new PlatformNotSupportedException();
        public static void SetTickEnabled(object actor, bool value) => throw new PlatformNotSupportedException();
        public static void SetLifeSpan(object actor, float lifeSpan) => throw new PlatformNotSupportedException();
        public static object GetLifeSpan(object actor) => throw new PlatformNotSupportedException();
        public static bool IsActorValid(object actor) => throw new PlatformNotSupportedException();
        public static object GetComponentByClass(object actor, object componentClass) => throw new PlatformNotSupportedException();
        public static object[] GetComponentsByClass(object actor, object componentClass) => throw new PlatformNotSupportedException();
        public static object FindComponentByTag(object actor, object componentClass, string tag) => throw new PlatformNotSupportedException();
        public static object GetOwner(object actor) => throw new PlatformNotSupportedException();
        public static object GetWorld(object actor) => throw new PlatformNotSupportedException();
        public static object GetGameInstance(object actor) => throw new PlatformNotSupportedException();
        public static object GetInstigator(object actor) => throw new PlatformNotSupportedException();
        public static object GetKillList(object actor) => throw new PlatformNotSupportedException();
        public static object GetNamespacedProcessId(object actor) => throw new PlatformNotSupportedException();
    }

    /// <summary>UE UActorComponent / 组件钩子入口。</summary>
    public static class Component
    {
        public static object GetOwner(object component) => throw new PlatformNotSupportedException();
        public static object GetWorld(object component) => throw new PlatformNotSupportedException();
        public static void SetWorldLocation(object component, object location) => throw new PlatformNotSupportedException();
        public static object GetWorldLocation(object component) => throw new PlatformNotSupportedException();
        public static void SetWorldRotation(object component, object rotation) => throw new PlatformNotSupportedException();
        public static object GetWorldRotation(object component) => throw new PlatformNotSupportedException();
        public static void SetComponentTickEnabled(object component, bool value) => throw new PlatformNotSupportedException();
        public static bool GetComponentTickEnabled(object component) => throw new PlatformNotSupportedException();
        public static object GetComponentBounds(object component) => throw new PlatformNotSupportedException();
        public static void SetComponentScale(object component, object scale, object? relativeLocation = null, object? yawPitchRoll = null) => throw new PlatformNotSupportedException();
        public static void SetHiddenInGame(object component, bool value, bool propagateToChildren = false) => throw new PlatformNotSupportedException();
        public static object GetComponentLocation(object component) => throw new PlatformNotSupportedException();
        public static void DestroyComponent(object component) => throw new PlatformNotSupportedException();
        public static object GetWChildComponents(object component) => throw new PlatformNotSupportedException();
    }
}