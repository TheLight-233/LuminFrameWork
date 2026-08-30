namespace Godot
{
    /// <summary>Godot Control 控件基类钩子入口。</summary>
    public static class Control
    {
        public static void SetPosition(object control, object position) => throw new PlatformNotSupportedException();
        public static object GetPosition(object control) => throw new PlatformNotSupportedException();
        public static void SetSize(object control, object size) => throw new PlatformNotSupportedException();
        public static object GetSize(object control) => throw new PlatformNotSupportedException();
        public static object GetGlobalPosition(object control) => throw new PlatformNotSupportedException();
        public static void SetRotation(object control, float radians) => throw new PlatformNotSupportedException();
        public static void SetScale(object control, object scale) => throw new PlatformNotSupportedException();
        public static void SetVisible(object control, bool visible) => throw new PlatformNotSupportedException();
        public static bool GetVisible(object control) => throw new PlatformNotSupportedException();
        public static void SetModulate(object control, object color) => throw new PlatformNotSupportedException();
        public static object GetModulate(object control) => throw new PlatformNotSupportedException();
        public static void SetSelfModulate(object control, object color) => throw new PlatformNotSupportedException();
        public static object GetRectSize(object control) => throw new PlatformNotSupportedException();
        public static object GetRectMin(object control) => throw new PlatformNotSupportedException();
        public static object GetCustomMinimumSize(object control) => throw new PlatformNotSupportedException();
        public static void SetAnchor(object control, int side, float value) => throw new PlatformNotSupportedException();
        public static void SetOffset(object control, int side, float value) => throw new PlatformNotSupportedException();
        public static void SetGrowDirectionHorizontal(object control, int value) => throw new PlatformNotSupportedException();
        public static void SetGrowDirectionVertical(object control, int value) => throw new PlatformNotSupportedException();
        public static void SetMouseFilter(object control, int value) => throw new PlatformNotSupportedException();
        public static void GrabFocus(object control) => throw new PlatformNotSupportedException();
        public static void ReleaseFocus(object control) => throw new PlatformNotSupportedException();
        public static bool HasFocus(object control) => throw new PlatformNotSupportedException();
        public static void SetFocusMode(object control, int value) => throw new PlatformNotSupportedException();
        public static void SetDisabled(object control, bool value) => throw new PlatformNotSupportedException();
        public static void SetTooltipText(object control, string text) => throw new PlatformNotSupportedException();
        public static void QueueSort(object control) => throw new PlatformNotSupportedException();
        public static void AcceptEvent(object control) => throw new PlatformNotSupportedException();
        public static void Show(object control) => throw new PlatformNotSupportedException();
        public static void Hide(object control) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Label 文本钩子入口。</summary>
    public static class Label
    {
        public static string GetText(object label) => throw new PlatformNotSupportedException();
        public static void SetText(object label, string text) => throw new PlatformNotSupportedException();
        public static void SetTextDirection(object label, int value) => throw new PlatformNotSupportedException();
        public static void SetHorizontalAlignment(object label, int value) => throw new PlatformNotSupportedException();
        public static void SetVerticalAlignment(object label, int value) => throw new PlatformNotSupportedException();
        public static void SetFontSize(object label, int value) => throw new PlatformNotSupportedException();
        public static void SetFontColor(object label, object color) => throw new PlatformNotSupportedException();
        public static void SetAutoWrapMode(object label, int value) => throw new PlatformNotSupportedException();
        public static object GetMinFontSize(object label) => throw new PlatformNotSupportedException();
        public static object GetTextSize(object label) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Button 按钮钩子入口。</summary>
    public static class Button
    {
        public static string GetText(object button) => throw new PlatformNotSupportedException();
        public static void SetText(object button, string text) => throw new PlatformNotSupportedException();
        public static bool GetToggleMode(object button) => throw new PlatformNotSupportedException();
        public static void SetToggleMode(object button, bool value) => throw new PlatformNotSupportedException();
        public static bool GetButtonPressed(object button) => throw new PlatformNotSupportedException();
        public static void SetButtonPressed(object button, bool value) => throw new PlatformNotSupportedException();
        public static void SetButtonMask(object button, object value) => throw new PlatformNotSupportedException();
        public static void SetIcon(object button, object icon) => throw new PlatformNotSupportedException();
        public static void SetFlat(object button, bool value) => throw new PlatformNotSupportedException();
        public static object GetButtonGroup(object button) => throw new PlatformNotSupportedException();
        public static void AddThemeColorOverride(object button, string name, object color) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot LineEdit 输入框钩子入口。</summary>
    public static class LineEdit
    {
        public static string GetText(object edit) => throw new PlatformNotSupportedException();
        public static void SetText(object edit, string text) => throw new PlatformNotSupportedException();
        public static string GetPlaceholderText(object edit) => throw new PlatformNotSupportedException();
        public static void SetPlaceholderText(object edit, string text) => throw new PlatformNotSupportedException();
        public static void SetMaxLength(object edit, int value) => throw new PlatformNotSupportedException();
        public static void SetEditable(object edit, bool value) => throw new PlatformNotSupportedException();
        public static bool GetEditable(object edit) => throw new PlatformNotSupportedException();
        public static void SelectAll(object edit) => throw new PlatformNotSupportedException();
        public static bool GetHasFocus(object edit) => throw new PlatformNotSupportedException();
        public static void CallDeferred(object edit, string method) => throw new PlatformNotSupportedException();
        public static int GetCaretColumn(object edit) => throw new PlatformNotSupportedException();
        public static void SetCaretColumn(object edit, int value) => throw new PlatformNotSupportedException();
        public static void SetEchoMasks(object edit, int value) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Sprite2D / TextureRect 显示精灵钩子入口。</summary>
    public static class Sprite2D
    {
        public static void SetTexture(object sprite, object texture) => throw new PlatformNotSupportedException();
        public static object GetTexture(object sprite) => throw new PlatformNotSupportedException();
        public static void SetFlipH(object sprite, bool value) => throw new PlatformNotSupportedException();
        public static bool GetFlipH(object sprite) => throw new PlatformNotSupportedException();
        public static void SetFlipV(object sprite, bool value) => throw new PlatformNotSupportedException();
        public static bool GetFlipV(object sprite) => throw new PlatformNotSupportedException();
        public static void SetFrame(object sprite, int value) => throw new PlatformNotSupportedException();
        public static int GetFrame(object sprite) => throw new PlatformNotSupportedException();
        public static void SetFrameCoords(object sprite, object coords) => throw new PlatformNotSupportedException();
        public static void SetCentered(object sprite, bool value) => throw new PlatformNotSupportedException();
        public static void SetModulate(object sprite, object color) => throw new PlatformNotSupportedException();
        public static void SetRegionEnabled(object sprite, bool value) => throw new PlatformNotSupportedException();
        public static object GetRect(object sprite) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot TileMap / 地图基础钩子入口。</summary>
    public static class Tile
    {
        public static void SetCell(object tileMap, object coords, int sourceId, object? atlasCoords = null, int alternativeTile = 0) => throw new PlatformNotSupportedException();
        public static object GetCellContents(object tileMap, object coords) => throw new PlatformNotSupportedException();
        public static object GetCellAtlasCoords(object tileMap, object coords) => throw new PlatformNotSupportedException();
        public static object GetCellSourceId(object tileMap, object coords) => throw new PlatformNotSupportedException();
        public static void SetTileSet(object tileMap, object tileSet) => throw new PlatformNotSupportedException();
        public static object GetTileSet(object tileMap) => throw new PlatformNotSupportedException();
        public static void ClearLayer(object tileMap, int layer) => throw new PlatformNotSupportedException();
        public static object GetCellPattern(object tileMap, object coords) => throw new PlatformNotSupportedException();
        public static void SetCellPattern(object tileMap, object coords, object pattern) => throw new PlatformNotSupportedException();
        public static object GetPatternSize(object pattern) => throw new PlatformNotSupportedException();
    }
}