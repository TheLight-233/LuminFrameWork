namespace Unity
{
    /// <summary>Unity UGUI 通用图形/文本的钩子入口。</summary>
    public static class UGUI
    {
        public static void SetText(object text, string value)
            => throw new PlatformNotSupportedException();
        public static string GetText(object text)
            => throw new PlatformNotSupportedException();
        public static void SetFontSize(object text, int size)
            => throw new PlatformNotSupportedException();
        public static int GetFontSize(object text)
            => throw new PlatformNotSupportedException();
        public static void SetColor(object graphic, object color)
            => throw new PlatformNotSupportedException();
        public static object GetColor(object graphic)
            => throw new PlatformNotSupportedException();
        public static void SetRaycastTarget(object graphic, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetRaycastTarget(object graphic)
            => throw new PlatformNotSupportedException();
        public static void SetEnabled(object graphic, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetEnabled(object graphic)
            => throw new PlatformNotSupportedException();
        public static void CrossFadeAlpha(object graphic, float alpha, float duration, bool ignoreTimeScale)
            => throw new PlatformNotSupportedException();
        public static void CrossFadeColor(object graphic, object color, float duration, bool ignoreTimeScale)
            => throw new PlatformNotSupportedException();
        public static void Rebuild(object graphic)
            => throw new PlatformNotSupportedException();
    }
}