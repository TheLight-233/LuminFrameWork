namespace Unity
{
    /// <summary>Unity Component 的钩子入口。</summary>
    public static class Component
    {
        public static object GetGameObject(object component)
            => throw new PlatformNotSupportedException();
        public static object GetTransform(object component)
            => throw new PlatformNotSupportedException();
        public static string GetName(object component)
            => throw new PlatformNotSupportedException();
        public static string GetTag(object component)
            => throw new PlatformNotSupportedException();

        public static bool GetEnabled(object component)
            => throw new PlatformNotSupportedException();
        public static void SetEnabled(object component, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetIsActiveAndEnabled(object component)
            => throw new PlatformNotSupportedException();

        public static T GetComponent<T>(object component) where T : class
            => throw new PlatformNotSupportedException();
        public static object GetComponent(object component, string typeName)
            => throw new PlatformNotSupportedException();
        public static T[] GetComponents<T>(object component) where T : class
            => throw new PlatformNotSupportedException();
        public static object[] GetComponents(object component, string typeName)
            => throw new PlatformNotSupportedException();
        public static T GetComponentInChildren<T>(object component, bool includeInactive = false) where T : class
            => throw new PlatformNotSupportedException();
        public static T GetComponentInParent<T>(object component) where T : class
            => throw new PlatformNotSupportedException();
        public static T AddComponent<T>(object component) where T : class
            => throw new PlatformNotSupportedException();

        public static void SendMessage(object component, string methodName, object? value = null, int options = 0)
            => throw new PlatformNotSupportedException();
        public static void BroadcastMessage(object component, string methodName, object? value = null, int options = 0)
            => throw new PlatformNotSupportedException();
        public static void SendMessageUpwards(object component, string methodName, object? value = null, int options = 0)
            => throw new PlatformNotSupportedException();

        public static bool CompareTag(object component, string tag)
            => throw new PlatformNotSupportedException();
        public static int GetInstanceId(object component)
            => throw new PlatformNotSupportedException();
    }
}