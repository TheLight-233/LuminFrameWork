namespace UE
{
    /// <summary>UE UUserWidget / 封装控件钩子入口。</summary>
    public static class Widget
    {
        public static object CreateWidget(object owningObject, object widgetClass) => throw new PlatformNotSupportedException();
        public static object CreateWidgetInstance(object owningObject, object userWidgetClass, string widgetName) => throw new PlatformNotSupportedException();
        public static void AddToViewport(object widget, int zOrder = 0) => throw new PlatformNotSupportedException();
        public static void AddToPlayerScreen(object widget, bool layer, object? tab = null) => throw new PlatformNotSupportedException();
        public static void RemoveFromParent(object widget) => throw new PlatformNotSupportedException();
        public static void RemoveFromViewport(object widget) => throw new PlatformNotSupportedException();
        public static void SetVisibility(object widget, int visibility) => throw new PlatformNotSupportedException();
        public static object GetVisibility(object widget) => throw new PlatformNotSupportedException();
        public static object GetWidgetFromName(object widget, string name) => throw new PlatformNotSupportedException();
        public static void SetPositionInViewport(object widget, object position, bool removeDPIScale = true) => throw new PlatformNotSupportedException();
        public static void SetDesiredSizeInViewport(object widget, object desiredSize) => throw new PlatformNotSupportedException();
        public static object GetWidgetSlot(object widget) => throw new PlatformNotSupportedException();
        public static bool GetIsInViewport(object widget) => throw new PlatformNotSupportedException();
        public static void SetOwningPlayer(object widget, object controller) => throw new PlatformNotSupportedException();
        public static object GetOwningPlayer(object widget) => throw new PlatformNotSupportedException();
        public static object GetOwningPlayerPawn(object widget) => throw new PlatformNotSupportedException();
        public static void SetFocus(object widget) => throw new PlatformNotSupportedException();
        public static void SetColorAndOpacity(object widget, object color, bool transparent = true) => throw new PlatformNotSupportedException();
        public static void SetOpacity(object widget, object opacity) => throw new PlatformNotSupportedException();
        public static void SetRenderScale(object widget, object scale) => throw new PlatformNotSupportedException();
        public static void SetRenderAngle(object widget, float angle) => throw new PlatformNotSupportedException();
        public static void SetRenderOpacity(object widget, float opacity) => throw new PlatformNotSupportedException();
        public static void SetToolTipText(object widget, object text) => throw new PlatformNotSupportedException();
        public static void SetIsFocusable(object widget, bool value) => throw new PlatformNotSupportedException();
        public static object GetGameInstance(object widget) => throw new PlatformNotSupportedException();
    }
}