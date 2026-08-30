namespace Unity
{
    /// <summary>Unity CanvasGroup 的钩子入口。</summary>
    public static class CanvasGroup
    {
        public static float GetAlpha(object group) => throw new PlatformNotSupportedException();
        public static void SetAlpha(object group, float value) => throw new PlatformNotSupportedException();
        public static bool GetInteractable(object group) => throw new PlatformNotSupportedException();
        public static void SetInteractable(object group, bool value) => throw new PlatformNotSupportedException();
        public static bool GetBlocksRaycasts(object group) => throw new PlatformNotSupportedException();
        public static void SetBlocksRaycasts(object group, bool value) => throw new PlatformNotSupportedException();
        public static bool GetIgnoreParentGroups(object group) => throw new PlatformNotSupportedException();
        public static void SetIgnoreParentGroups(object group, bool value) => throw new PlatformNotSupportedException();
        public static void SetVisible(object group, bool value) => throw new PlatformNotSupportedException();
        public static bool IsVisible(object group) => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity Canvas 的钩子入口。</summary>
    public static class Canvas
    {
        public static object GetOverlaySortingOrder(object canvas) => throw new PlatformNotSupportedException();
        public static int GetSortingOrder(object canvas) => throw new PlatformNotSupportedException();
        public static void SetSortingOrder(object canvas, int value) => throw new PlatformNotSupportedException();
        public static string GetSortingLayer(object canvas) => throw new PlatformNotSupportedException();
        public static void SetSortingLayer(object canvas, string value) => throw new PlatformNotSupportedException();
        public static object GetRenderMode(object canvas) => throw new PlatformNotSupportedException();
        public static void SetRenderMode(object canvas, object value) => throw new PlatformNotSupportedException();
        public static float GetScaleFactor(object canvas) => throw new PlatformNotSupportedException();
        public static void SetScaleFactor(object canvas, float value) => throw new PlatformNotSupportedException();
        public static object GetWorldCamera(object canvas) => throw new PlatformNotSupportedException();
        public static void SetWorldCamera(object canvas, object camera) => throw new PlatformNotSupportedException();
        public static void ForceUpdateCanvases(object canvas) => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity EventSystem / 事件系统的钩子入口。</summary>
    public static class EventSystem
    {
        public static object GetCurrent() => throw new PlatformNotSupportedException();
        public static void SetSelectedGameObject(object eventSystem, object selected) => throw new PlatformNotSupportedException();
        public static object GetSelectedGameObject(object eventSystem) => throw new PlatformNotSupportedException();
        public static object GetFirstSelectedGameObject(object eventSystem) => throw new PlatformNotSupportedException();
        public static bool GetEnabled(object eventSystem) => throw new PlatformNotSupportedException();
        public static void SetEnabled(object eventSystem, bool value) => throw new PlatformNotSupportedException();
        public static object RaycastAll(object eventData) => throw new PlatformNotSupportedException();
        public static bool IsPointerOverGameObject(object eventSystem, int pointerId) => throw new PlatformNotSupportedException();
        public static void SetCurrentInputModule(object eventSystem, object module) => throw new PlatformNotSupportedException();
        public static void UpdateModules(object eventSystem) => throw new PlatformNotSupportedException();
    }
}