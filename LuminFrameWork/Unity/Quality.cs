namespace Unity
{
    /// <summary>Unity Quality 质量设置钩子入口。</summary>
    public static class Quality
    {
        public static string[] GetNames() => throw new PlatformNotSupportedException();
        public static int GetLevel() => throw new PlatformNotSupportedException();
        public static void SetLevel(int index, bool applyExpensiveChanges = true) => throw new PlatformNotSupportedException();
        public static int GetPadding() => throw new PlatformNotSupportedException();
        public static int GetShadowDistance() => throw new PlatformNotSupportedException();
        public static int GetShadowCascades() => throw new PlatformNotSupportedException();
        public static int GetAntiAliasing() => throw new PlatformNotSupportedException();
        public static void SetAntiAliasing(int value) => throw new PlatformNotSupportedException();
        public static int GetGlobalTextureMipmapLimit() => throw new PlatformNotSupportedException();
        public static void SetGlobalTextureMipmapLimit(int value) => throw new PlatformNotSupportedException();
        public static int GetVRefreshCount() => throw new PlatformNotSupportedException();
        public static void SetVRefreshCount(int value) => throw new PlatformNotSupportedException();
        public static bool GetAsyncUploadTimeSlice() => throw new PlatformNotSupportedException();
        public static int GetPixelLightCount() => throw new PlatformNotSupportedException();
        public static void SetPixelLightCount(int value) => throw new PlatformNotSupportedException();
        public static float GetRenderScale() => throw new PlatformNotSupportedException();
        public static void SetRenderScale(float value) => throw new PlatformNotSupportedException();
        public static int GetMaxLodLevel() => throw new PlatformNotSupportedException();
        public static int GetParticlesRaycastBudget() => throw new PlatformNotSupportedException();
        public static bool GetSoftVegetation() => throw new PlatformNotSupportedException();
        public static bool GetShadows() => throw new PlatformNotSupportedException();
        public static void SetShadows(bool value) => throw new PlatformNotSupportedException();
    }
}