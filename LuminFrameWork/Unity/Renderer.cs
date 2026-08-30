namespace Unity
{
    /// <summary>Unity Renderer / Material / SpriteRenderer 的钩子入口。</summary>
    public static class Renderer
    {
        public static bool GetEnabled(object renderer)
            => throw new PlatformNotSupportedException();
        public static void SetEnabled(object renderer, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetVisible(object renderer)
            => throw new PlatformNotSupportedException();
        public static object GetBounds(object renderer)
            => throw new PlatformNotSupportedException();
        public static object GetMaterial(object renderer)
            => throw new PlatformNotSupportedException();
        public static object GetSharedMaterial(object renderer)
            => throw new PlatformNotSupportedException();
        public static void SetSharedMaterial(object renderer, object material)
            => throw new PlatformNotSupportedException();
        public static object[] GetMaterials(object renderer)
            => throw new PlatformNotSupportedException();

        public static void SetColor(object renderer, object color)
            => throw new PlatformNotSupportedException();
        public static object GetColor(object renderer)
            => throw new PlatformNotSupportedException();
        public static int GetSortingOrder(object renderer)
            => throw new PlatformNotSupportedException();
        public static void SetSortingOrder(object renderer, int value)
            => throw new PlatformNotSupportedException();
        public static string GetSortingLayer(object renderer)
            => throw new PlatformNotSupportedException();
        public static int GetMaterialCount(object renderer)
            => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Material 属性和材质的钩子入口。</summary>
    public static class Material
    {
        public static object GetColor(object material, string propertyName)
            => throw new PlatformNotSupportedException();
        public static void SetColor(object material, string propertyName, object color)
            => throw new PlatformNotSupportedException();
        public static float GetFloat(object material, string propertyName)
            => throw new PlatformNotSupportedException();
        public static void SetFloat(object material, string propertyName, float value)
            => throw new PlatformNotSupportedException();
        public static int GetInteger(object material, string propertyName)
            => throw new PlatformNotSupportedException();
        public static void SetInteger(object material, string propertyName, int value)
            => throw new PlatformNotSupportedException();
        public static void SetTexture(object material, string propertyName, object texture)
            => throw new PlatformNotSupportedException();
        public static object GetTexture(object material, string propertyName)
            => throw new PlatformNotSupportedException();
        public static void SetVector(object material, string propertyName, object vector)
            => throw new PlatformNotSupportedException();
        public static object GetVector(object material, string propertyName)
            => throw new PlatformNotSupportedException();
        public static bool HasProperty(object material, string propertyName)
            => throw new PlatformNotSupportedException();
        public static void SetShader(object material, object shader)
            => throw new PlatformNotSupportedException();
        public static void SetAlpha(object material, float value)
            => throw new PlatformNotSupportedException();
        public static void EnableKeyword(object material, string keyword)
            => throw new PlatformNotSupportedException();
        public static void DisableKeyword(object material, string keyword)
            => throw new PlatformNotSupportedException();
    }
}