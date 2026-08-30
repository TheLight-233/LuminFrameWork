namespace Unity
{
    /// <summary>Unity Resources 资源加载的钩子入口。</summary>
    public static class Resources
    {
        public static T Load<T>(string path) where T : class
            => throw new PlatformNotSupportedException();
        public static object Load(string path, string typeName)
            => throw new PlatformNotSupportedException();
        public static T[] LoadAll<T>(string path) where T : class
            => throw new PlatformNotSupportedException();
        public static object[] LoadAll(string path, string typeName)
            => throw new PlatformNotSupportedException();
        public static object LoadAsyncObject(string path, string typeName)
            => throw new PlatformNotSupportedException();
        public static void UnloadAsset(object asset)
            => throw new PlatformNotSupportedException();
        public static void UnloadUnusedAssets()
            => throw new PlatformNotSupportedException();
        public static object FindObjectOfType(string typeName)
            => throw new PlatformNotSupportedException();
        public static object[] FindObjectsOfType(string typeName)
            => throw new PlatformNotSupportedException();
        public static int GetAssetCount()
            => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Addressables 风格资源（占位）的钩子入口。</summary>
    public static class Asset
    {
        public static object Load(object address)
            => throw new PlatformNotSupportedException();
        public static object LoadAsync(object address)
            => throw new PlatformNotSupportedException();
        public static void Release(object asset)
            => throw new PlatformNotSupportedException();
        public static void ReleaseInstance(object instance)
            => throw new PlatformNotSupportedException();
        public static object Instantiate(object asset)
            => throw new PlatformNotSupportedException();
        public static object InstantiateAsync(object asset)
            => throw new PlatformNotSupportedException();
    }
}