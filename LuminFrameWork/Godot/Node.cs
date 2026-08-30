namespace Godot
{
    /// <summary>Godot Node 节点树钩子入口。</summary>
    public static class Node
    {
        public static string GetName(object node) => throw new PlatformNotSupportedException();
        public static void SetName(object node, string name) => throw new PlatformNotSupportedException();
        public static object GetParent(object node) => throw new PlatformNotSupportedException();
        public static object GetTree(object node) => throw new PlatformNotSupportedException();
        public static string GetPath(object node) => throw new PlatformNotSupportedException();
        public static void AddChild(object node, object child) => throw new PlatformNotSupportedException();
        public static void AddChild(object node, object child, bool forceReadableName) => throw new PlatformNotSupportedException();
        public static void AddSibling(object node, object sibling) => throw new PlatformNotSupportedException();
        public static void RemoveChild(object node, object child) => throw new PlatformNotSupportedException();
        public static object GetChild(object node, int index, bool includeInternal = false) => throw new PlatformNotSupportedException();
        public static object GetNode(object node, string path) => throw new PlatformNotSupportedException();
        public static bool HasNode(object node, string path) => throw new PlatformNotSupportedException();
        public static object GetNodeOrNull(object node, string path) => throw new PlatformNotSupportedException();
        public static object[] GetChildren(object node) => throw new PlatformNotSupportedException();
        public static object[] GetChildrenIncludingInternal(object node) => throw new PlatformNotSupportedException();
        public static int GetChildCount(object node) => throw new PlatformNotSupportedException();
        public static int GetChildIndexInParent(object node) => throw new PlatformNotSupportedException();
        public static void QueueFree(object node) => throw new PlatformNotSupportedException();
        public static void Free(object node) => throw new PlatformNotSupportedException();
        public static void Reparent(object node, object newParent) => throw new PlatformNotSupportedException();
        public static void MoveChild(object node, object child, int index) => throw new PlatformNotSupportedException();
        public static object[] GetEndedChildren(object node) => throw new PlatformNotSupportedException();
        public static void SetProcess(object node, bool enable) => throw new PlatformNotSupportedException();
        public static bool GetProcess(object node) => throw new PlatformNotSupportedException();
        public static void SetPhysicsProcess(object node, bool enable) => throw new PlatformNotSupportedException();
        public static bool GetPhysicsProcess(object node) => throw new PlatformNotSupportedException();
        public static void SetProcessMode(object node, int mode) => throw new PlatformNotSupportedException();
        public static object GetProcessMode(object node) => throw new PlatformNotSupportedException();
        public static void SetVisible(object node, bool visible) => throw new PlatformNotSupportedException();
        public static bool GetVisible(object node) => throw new PlatformNotSupportedException();
        public static void SetGroup(object node, int group) => throw new PlatformNotSupportedException();
        public static object[] GetGroups(object node) => throw new PlatformNotSupportedException();
        public static void AddToGroup(object node, string group) => throw new PlatformNotSupportedException();
        public static void RemoveFromGroup(object node, string group) => throw new PlatformNotSupportedException();
        public static bool IsInGroup(object node, string group) => throw new PlatformNotSupportedException();
        public static bool IsInsideTree(object node) => throw new PlatformNotSupportedException();
        public static bool IsNodeReady(object node) => throw new PlatformNotSupportedException();
        public static object GetOwner(object node) => throw new PlatformNotSupportedException();
        public static void SetOwner(object node, object owner) => throw new PlatformNotSupportedException();
        public static object FindChild(object node, string pattern, bool recursive = true, bool owned = true) => throw new PlatformNotSupportedException();
        public static object[] FindChildren(object node, string pattern, string type = "", bool recursive = false) => throw new PlatformNotSupportedException();
        public static object GetFirstNodeInGroup(object node, string group) => throw new PlatformNotSupportedException();
        public static void PrintTree(object node, object? tab = null) => throw new PlatformNotSupportedException();
    }
}