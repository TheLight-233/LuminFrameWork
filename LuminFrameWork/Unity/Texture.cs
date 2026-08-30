namespace Unity
{
    /// <summary>Unity Texture / Texture2D 纹理钩子入口。</summary>
    public static class Texture
    {
        public static int GetWidth(object texture) => throw new PlatformNotSupportedException();
        public static int GetHeight(object texture) => throw new PlatformNotSupportedException();
        public static object GetWrapMode(object texture) => throw new PlatformNotSupportedException();
        public static void SetWrapMode(object texture, object mode) => throw new PlatformNotSupportedException();
        public static object GetFilterMode(object texture) => throw new PlatformNotSupportedException();
        public static void SetFilterMode(object texture, object mode) => throw new PlatformNotSupportedException();
        public static float GetAnisoLevel(object texture) => throw new PlatformNotSupportedException();
        public static void SetAnisoLevel(object texture, float value) => throw new PlatformNotSupportedException();
        public static string GetTextureName(object texture) => throw new PlatformNotSupportedException();
        public static void SetMipMapBias(object texture, float value) => throw new PlatformNotSupportedException();

        public static void SetPixel(object texture, int x, int y, object color) => throw new PlatformNotSupportedException();
        public static object GetPixel(object texture, int x, int y) => throw new PlatformNotSupportedException();
        public static object GetPixelBilinear(object texture, float u, float v) => throw new PlatformNotSupportedException();
        public static void SetPixels(object texture, object[] colors) => throw new PlatformNotSupportedException();
        public static object[] GetPixels(object texture) => throw new PlatformNotSupportedException();
        public static void Apply(object texture, bool updateMipmaps = true) => throw new PlatformNotSupportedException();
        public static void Resize(object texture, int width, int height) => throw new PlatformNotSupportedException();
        public static string EncodeToPNG(object texture) => throw new PlatformNotSupportedException();
        public static string EncodeToJPG(object texture, int quality) => throw new PlatformNotSupportedException();
        public static object Create(int width, int height) => throw new PlatformNotSupportedException();
        public static object Create(int width, int height, object format) => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Shader 着色器钩子入口。</summary>
    public static class Shader
    {
        public static object Find(string name) => throw new PlatformNotSupportedException();
        public static int PropertyToID(string name) => throw new PlatformNotSupportedException();
        public static string PropertyName(int propertyID) => throw new PlatformNotSupportedException();
        public static void EnableKeyword(string keyword) => throw new PlatformNotSupportedException();
        public static void DisableKeyword(string keyword) => throw new PlatformNotSupportedException();
        public static bool IsKeywordEnabled(string keyword) => throw new PlatformNotSupportedException();
        public static int GetPropertyCount(object shader) => throw new PlatformNotSupportedException();
        public static string GetPropertyName(object shader, int index) => throw new PlatformNotSupportedException();
        public static object GetPropertyType(object shader, int index) => throw new PlatformNotSupportedException();
        public static int GetMaxTextureSize() => throw new PlatformNotSupportedException();
        public static void SetGlobalFloat(string name, float value) => throw new PlatformNotSupportedException();
        public static void SetGlobalColor(string name, object color) => throw new PlatformNotSupportedException();
        public static void SetGlobalVector(string name, object vector) => throw new PlatformNotSupportedException();
        public static void SetGlobalTexture(string name, object texture) => throw new PlatformNotSupportedException();
        public static void SetGlobalMatrix(string name, object matrix) => throw new PlatformNotSupportedException();
    }
}