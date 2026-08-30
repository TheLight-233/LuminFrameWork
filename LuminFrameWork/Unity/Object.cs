namespace Unity
{
    /// <summary>Unity Object / 组件基类的钩子入口。</summary>
    public static class Object
    {
        public static T FindObjectOfType<T>() where T : class
            => throw new PlatformNotSupportedException();
        public static object FindObjectOfType(string typeName)
            => throw new PlatformNotSupportedException();
        public static T[] FindObjectsOfType<T>() where T : class
            => throw new PlatformNotSupportedException();
        public static object[] FindObjectsOfType(string typeName)
            => throw new PlatformNotSupportedException();
        public static object FindObject(string name)
            => throw new PlatformNotSupportedException();
        public static object[] FindObjectsByTag(string tag)
            => throw new PlatformNotSupportedException();
        public static object FindObjectById(int instanceId)
            => throw new PlatformNotSupportedException();

        public static object Instantiate(object original)
            => throw new PlatformNotSupportedException();
        public static object Instantiate(object original, object position, object rotation)
            => throw new PlatformNotSupportedException();
        public static object Instantiate<T>(object original) where T : class
            => throw new PlatformNotSupportedException();

        public static void Destroy(object obj)
            => throw new PlatformNotSupportedException();
        public static void Destroy(object obj, float delay)
            => throw new PlatformNotSupportedException();
        public static void DestroyImmediate(object obj)
            => throw new PlatformNotSupportedException();
        public static void DestroyObject(object obj, float delay)
            => throw new PlatformNotSupportedException();
        public static void DontDestroyOnLoad(object target)
            => throw new PlatformNotSupportedException();

        public static string GetName(object obj)
            => throw new PlatformNotSupportedException();
        public static void SetName(object obj, string name)
            => throw new PlatformNotSupportedException();
        public static bool GetActive(object obj)
            => throw new PlatformNotSupportedException();
        public static void SetActive(object obj, bool value)
            => throw new PlatformNotSupportedException();
        public static int GetInstanceId(object obj)
            => throw new PlatformNotSupportedException();
    }
}