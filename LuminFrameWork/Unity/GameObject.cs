namespace Unity
{
    /// <summary>Unity GameObject 的钩子入口。</summary>
    public static class GameObject
    {
        public static object CreatePrimitive(string type)
            => throw new PlatformNotSupportedException();
        public static object Find(string name)
            => throw new PlatformNotSupportedException();
        public static object FindWithTag(string tag)
            => throw new PlatformNotSupportedException();
        public static object[] FindGameObjectsWithTag(string tag)
            => throw new PlatformNotSupportedException();

        public static T AddComponent<T>(object gameObject) where T : class
            => throw new PlatformNotSupportedException();
        public static object AddComponent(object gameObject, string typeName)
            => throw new PlatformNotSupportedException();

        public static T GetComponent<T>(object gameObject) where T : class
            => throw new PlatformNotSupportedException();
        public static object GetComponent(object gameObject, string typeName)
            => throw new PlatformNotSupportedException();
        public static T[] GetComponents<T>(object gameObject) where T : class
            => throw new PlatformNotSupportedException();
        public static object[] GetComponents(object gameObject, string typeName)
            => throw new PlatformNotSupportedException();
        public static T GetComponentInChildren<T>(object gameObject, bool includeInactive = false) where T : class
            => throw new PlatformNotSupportedException();
        public static T[] GetComponentsInChildren<T>(object gameObject, bool includeInactive = false) where T : class
            => throw new PlatformNotSupportedException();
        public static T GetComponentInParent<T>(object gameObject) where T : class
            => throw new PlatformNotSupportedException();

        public static void SetActive(object gameObject, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetActiveSelf(object gameObject)
            => throw new PlatformNotSupportedException();
        public static bool GetActiveInHierarchy(object gameObject)
            => throw new PlatformNotSupportedException();

        public static object GetTransform(object gameObject)
            => throw new PlatformNotSupportedException();
        public static object GetParent(object gameObject)
            => throw new PlatformNotSupportedException();
        public static void SetParent(object gameObject, object parent)
            => throw new PlatformNotSupportedException();
        public static object GetScene(object gameObject)
            => throw new PlatformNotSupportedException();

        public static string GetTag(object gameObject)
            => throw new PlatformNotSupportedException();
        public static void SetTag(object gameObject, string tag)
            => throw new PlatformNotSupportedException();
        public static int GetLayer(object gameObject)
            => throw new PlatformNotSupportedException();
        public static void SetLayer(object gameObject, int layer)
            => throw new PlatformNotSupportedException();
        public static bool CompareTag(object gameObject, string tag)
            => throw new PlatformNotSupportedException();

        public static void SendMessage(object gameObject, string methodName, object? value = null, int options = 0)
            => throw new PlatformNotSupportedException();
        public static void BroadcastMessage(object gameObject, string methodName, object? value = null, int options = 0)
            => throw new PlatformNotSupportedException();
        public static void SendMessageUpwards(object gameObject, string methodName, object? value = null, int options = 0)
            => throw new PlatformNotSupportedException();

        public static object[] GetComponentsOfType(object gameObject)
            => throw new PlatformNotSupportedException();
        public static bool TryGetComponent(object gameObject, string typeName, out object component)
            => throw new PlatformNotSupportedException();
    }
}