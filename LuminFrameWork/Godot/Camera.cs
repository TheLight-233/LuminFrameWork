namespace Godot
{
    /// <summary>Godot Camera2D 二维摄像机钩子入口。</summary>
    public static class Camera2D
    {
        public static void SetPosition(object camera, object position) => throw new PlatformNotSupportedException();
        public static object GetPosition(object camera) => throw new PlatformNotSupportedException();
        public static void SetZoom(object camera, object zoom) => throw new PlatformNotSupportedException();
        public static object GetZoom(object camera) => throw new PlatformNotSupportedException();
        public static void SetRotation(object camera, float radians) => throw new PlatformNotSupportedException();
        public static void MakeCurrent(object camera) => throw new PlatformNotSupportedException();
        public static bool GetEnabled(object camera) => throw new PlatformNotSupportedException();
        public static void SetEnabled(object camera, bool value) => throw new PlatformNotSupportedException();
        public static void SetAnchorMode(object camera, int value) => throw new PlatformNotSupportedException();
        public static void SetIgnoreRotation(object camera, bool value) => throw new PlatformNotSupportedException();
        public static object GetScreenCenter(object camera) => throw new PlatformNotSupportedException();
        public static object GetScreenTopLeft(object camera) => throw new PlatformNotSupportedException();
        public static object GetScreenRight(object camera) => throw new PlatformNotSupportedException();
        public static object GetScreenBottom(object camera) => throw new PlatformNotSupportedException();
        public static void SetLimit(object camera, int margin, int value) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Camera3D 三维摄像机钩子入口。</summary>
    public static class Camera3D
    {
        public static void SetFov(object camera, float value) => throw new PlatformNotSupportedException();
        public static float GetFov(object camera) => throw new PlatformNotSupportedException();
        public static void SetFovVertical(object camera, bool value) => throw new PlatformNotSupportedException();
        public static void SetNear(object camera, float value) => throw new PlatformNotSupportedException();
        public static void SetFar(object camera, float value) => throw new PlatformNotSupportedException();
        public static void SetKeepAspect(object camera, int value) => throw new PlatformNotSupportedException();
        public static void MakeCurrent(object camera) => throw new PlatformNotSupportedException();
        public static bool IsCurrent(object camera) => throw new PlatformNotSupportedException();
        public static void ClearCurrent(object camera, bool enableNext = true) => throw new PlatformNotSupportedException();
        public static object GetCameraRotation(object camera) => throw new PlatformNotSupportedException();
        public static object GetCameraTransform(object camera) => throw new PlatformNotSupportedException();
        public static object ProjectRayOrigin(object camera, object screenPoint) => throw new PlatformNotSupportedException();
        public static object ProjectRayNormal(object camera, object screenPoint) => throw new PlatformNotSupportedException();
        public static object UnprojectPosition(object camera, object position) => throw new PlatformNotSupportedException();
        public static object GetWorldVisible(object camera, int screenSizeX, int screenSizeY) => throw new PlatformNotSupportedException();
        public static object GetViewportAspect(object camera) => throw new PlatformNotSupportedException();
    }
}