namespace Unity
{
    /// <summary>Unity PlayerPrefs 存档的钩子入口。</summary>
    public static class PlayerPrefs
    {
        public static void SetInt(string key, int value) => throw new PlatformNotSupportedException();
        public static int GetInt(string key, int defaultValue = 0) => throw new PlatformNotSupportedException();
        public static void SetFloat(string key, float value) => throw new PlatformNotSupportedException();
        public static float GetFloat(string key, float defaultValue = 0f) => throw new PlatformNotSupportedException();
        public static void SetString(string key, string value) => throw new PlatformNotSupportedException();
        public static string GetString(string key, string? defaultValue = null) => throw new PlatformNotSupportedException();
        public static void DeleteKey(string key) => throw new PlatformNotSupportedException();
        public static void DeleteAll() => throw new PlatformNotSupportedException();
        public static bool HasKey(string key) => throw new PlatformNotSupportedException();
        public static void Save() => throw new PlatformNotSupportedException();
    }
}