namespace Godot
{
    /// <summary>Godot Resource / ResourceLoader 资源钩子入口。</summary>
    public static class Resource
    {
        public static object Load(string path, string? typeHint = null, int cacheMode = 1) => throw new PlatformNotSupportedException();
        public static bool Exists(string path, string type = "") => throw new PlatformNotSupportedException();
        public static object LoadLocal(string path) => throw new PlatformNotSupportedException();
        public static void SetLocalToScene(object resource, bool value) => throw new PlatformNotSupportedException();
        public static bool GetLocalToScene(object resource) => throw new PlatformNotSupportedException();
        public static string GetResourcePath(object resource) => throw new PlatformNotSupportedException();
        public static string GetResourceName(object resource) => throw new PlatformNotSupportedException();
        public static void SetResourceName(object resource, string name) => throw new PlatformNotSupportedException();
        public static object GetResourceId(object resource) => throw new PlatformNotSupportedException();
        public static string GetResourceUID(object resource) => throw new PlatformNotSupportedException();
        public static void TakeOverPath(object resource) => throw new PlatformNotSupportedException();
        public static void Dup(object resource, bool subresources = false, bool idForPath = false) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot PackedScene / 场景与节点实例化钩子入口。</summary>
    public static class PackedScene
    {
        public static object Instantiate(object packedScene, bool editState = false) => throw new PlatformNotSupportedException();
        public static object InstantiateAsStageInstance(object packedScene) => throw new PlatformNotSupportedException();
        public static object CreateFromScene(object root) => throw new PlatformNotSupportedException();
        public static void Pack(object packedScene, object path) => throw new PlatformNotSupportedException();
        public static string PackArray(object packedScene, object path) => throw new PlatformNotSupportedException();
        public static object GetState(object packedScene) => throw new PlatformNotSupportedException();
        public static bool CanInstantiate(object packedScene) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot SceneFile / 场景生成本地化钩子入口。</summary>
    public static class Node2D
    {
        public static void SetPosition(object node, object position) => throw new PlatformNotSupportedException();
        public static object GetPosition(object node) => throw new PlatformNotSupportedException();
        public static void SetLocalPosition(object node, object position) => throw new PlatformNotSupportedException();
        public static object GetLocalPosition(object node) => throw new PlatformNotSupportedException();
        public static void SetRotation(object node, float radians) => throw new PlatformNotSupportedException();
        public static float GetRotation(object node) => throw new PlatformNotSupportedException();
        public static void SetRotationDegrees(object node, float degrees) => throw new PlatformNotSupportedException();
        public static void SetScale(object node, object scale) => throw new PlatformNotSupportedException();
        public static object GetScale(object node) => throw new PlatformNotSupportedException();
        public static object GetGlobalPosition(object node) => throw new PlatformNotSupportedException();
        public static object ToGlobal(object node, object localPoint) => throw new PlatformNotSupportedException();
        public static object ToLocal(object node, object globalPoint) => throw new PlatformNotSupportedException();
        public static void LookAt(object node, object position) => throw new PlatformNotSupportedException();
        public static void MoveLocalX(object node, float delta, bool scaled = false) => throw new PlatformNotSupportedException();
        public static void MoveLocalY(object node, float delta, bool scaled = false) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Node3D 三维节点变换钩子入口。</summary>
    public static class Node3D
    {
        public static void SetPosition(object node, object position) => throw new PlatformNotSupportedException();
        public static object GetPosition(object node) => throw new PlatformNotSupportedException();
        public static object GetGlobalPosition(object node) => throw new PlatformNotSupportedException();
        public static void SetRotation(object node, object radians) => throw new PlatformNotSupportedException();
        public static object GetRotation(object node) => throw new PlatformNotSupportedException();
        public static void SetRotationDegrees(object node, object degrees) => throw new PlatformNotSupportedException();
        public static void SetScale(object node, object scale) => throw new PlatformNotSupportedException();
        public static object GetScale(object node) => throw new PlatformNotSupportedException();
        public static void SetBasis(object node, object basis) => throw new PlatformNotSupportedException();
        public static object GetBasis(object node) => throw new PlatformNotSupportedException();
        public static void LookAt(object node, object target, object? up = null) => throw new PlatformNotSupportedException();
        public static void RotateObjectLocal(object node, object axis, float angle) => throw new PlatformNotSupportedException();
        public static void TranslateObjectLocal(object node, object translation) => throw new PlatformNotSupportedException();
        public static object ToGlobal(object node, object localPoint) => throw new PlatformNotSupportedException();
        public static object ToLocal(object node, object globalPoint) => throw new PlatformNotSupportedException();
        public static double GetDistanceTo(object node, object target) => throw new PlatformNotSupportedException();
    }
}