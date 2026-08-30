namespace Unity
{
    /// <summary>Unity JsonUtility JSON 序列化钩子入口。</summary>
    public static class Json
    {
        public static string ToJson(object obj) => throw new PlatformNotSupportedException();
        public static string ToJson(object obj, bool prettyPrint) => throw new PlatformNotSupportedException();
        public static T FromJson<T>(string json) where T : class => throw new PlatformNotSupportedException();
        public static object FromJson(string json, System.Type type) => throw new PlatformNotSupportedException();
        public static void FromJsonOverwrite(string json, object objectToOverwrite) => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity WWW / 网络请求钩子入口。</summary>
    public static class Http
    {
        public static object Get(string url) => throw new PlatformNotSupportedException();
        public static object GetAsync(string url) => throw new PlatformNotSupportedException();
        public static object Post(string url, string postData) => throw new PlatformNotSupportedException();
        public static object PostAsync(string url, string postData) => throw new PlatformNotSupportedException();
        public static object SendWebRequest(string url, string method, string data, string contentType) => throw new PlatformNotSupportedException();
        public static string GetResult(object webRequest) => throw new PlatformNotSupportedException();
        public static byte[] GetBytes(object webRequest) => throw new PlatformNotSupportedException();
        public static long GetResponseCode(object webRequest) => throw new PlatformNotSupportedException();
        public static bool GetIsDone(object webRequest) => throw new PlatformNotSupportedException();
        public static object GetRequestError(object webRequest) => throw new PlatformNotSupportedException();
        public static void Abort(object webRequest) => throw new PlatformNotSupportedException();
        public static void Dispose(object webRequest) => throw new PlatformNotSupportedException();
        public static void SetHeader(object webRequest, string name, string value) => throw new PlatformNotSupportedException();
        public static string GetHeader(object webRequest, string name) => throw new PlatformNotSupportedException();
    }
}