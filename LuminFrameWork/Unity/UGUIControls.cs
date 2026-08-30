namespace Unity
{
    /// <summary>Unity UGUI 各控件（Button/InputField/Toggle/Slider/Scroll 等）的钩子入口。</summary>
    public static class UGUIControls
    {
        // ---- Button ----
        public static void ButtonAddListener(object button, object callback)
            => throw new PlatformNotSupportedException();
        public static void ButtonRemoveListener(object button, object callback)
            => throw new PlatformNotSupportedException();
        public static void ButtonSetInteractable(object button, bool value)
            => throw new PlatformNotSupportedException();
        public static bool ButtonGetInteractable(object button)
            => throw new PlatformNotSupportedException();
        public static void ButtonOnClick(object button)
            => throw new PlatformNotSupportedException();

        // ---- InputField / TMP ----
        public static void InputFieldSetText(object inputField, string value)
            => throw new PlatformNotSupportedException();
        public static string InputFieldGetText(object inputField)
            => throw new PlatformNotSupportedException();
        public static void InputFieldSetInteractable(object inputField, bool value)
            => throw new PlatformNotSupportedException();
        public static void InputFieldActivateInputField(object inputField)
            => throw new PlatformNotSupportedException();
        public static void InputFieldAddValueChangedListener(object inputField, object callback)
            => throw new PlatformNotSupportedException();
        public static void InputFieldAddEndEditListener(object inputField, object callback)
            => throw new PlatformNotSupportedException();

        // ---- Toggle ----
        public static void ToggleSetIsOn(object toggle, bool value)
            => throw new PlatformNotSupportedException();
        public static bool ToggleGetIsOn(object toggle)
            => throw new PlatformNotSupportedException();
        public static void ToggleAddValueChangedListener(object toggle, object callback)
            => throw new PlatformNotSupportedException();

        // ---- Slider ----
        public static void SliderSetValue(object slider, float value)
            => throw new PlatformNotSupportedException();
        public static float SliderGetValue(object slider)
            => throw new PlatformNotSupportedException();
        public static void SliderSetMinValue(object slider, float value)
            => throw new PlatformNotSupportedException();
        public static void SliderSetMaxValue(object slider, float value)
            => throw new PlatformNotSupportedException();
        public static void SliderAddValueChangedListener(object slider, object callback)
            => throw new PlatformNotSupportedException();

        // ---- ScrollRect ----
        public static void ScrollRectSetNormalizedPosition(object scrollRect, object position, int axis)
            => throw new PlatformNotSupportedException();
        public static object ScrollRectGetNormalizedPosition(object scrollRect, int axis)
            => throw new PlatformNotSupportedException();
        public static void ScrollRectSetHorizontal(object scrollRect, bool value)
            => throw new PlatformNotSupportedException();
        public static void ScrollRectSetVertical(object scrollRect, bool value)
            => throw new PlatformNotSupportedException();
        public static void ScrollRectScrollToTop(object scrollRect)
            => throw new PlatformNotSupportedException();
        public static void ScrollRectScrollToBottom(object scrollRect)
            => throw new PlatformNotSupportedException();

        // ---- Dropdown ----
        public static void DropdownSetValue(object dropdown, int value)
            => throw new PlatformNotSupportedException();
        public static int DropdownGetValue(object dropdown)
            => throw new PlatformNotSupportedException();
        public static void DropdownShow(object dropdown)
            => throw new PlatformNotSupportedException();
        public static void DropdownHide(object dropdown)
            => throw new PlatformNotSupportedException();
        public static void DropdownAddValueChangedListener(object dropdown, object callback)
            => throw new PlatformNotSupportedException();

        // ---- Canvas / RectTransform ----
        public static void CanvasSetSortingOrder(object canvas, int value)
            => throw new PlatformNotSupportedException();
        public static int CanvasGetSortingOrder(object canvas)
            => throw new PlatformNotSupportedException();
        public static void RectTransformSetSizeDelta(object rectTransform, object size)
            => throw new PlatformNotSupportedException();
        public static object RectTransformGetSizeDelta(object rectTransform)
            => throw new PlatformNotSupportedException();
        public static void RectTransformSetAnchoredPosition(object rectTransform, object position)
            => throw new PlatformNotSupportedException();
        public static object RectTransformGetAnchoredPosition(object rectTransform)
            => throw new PlatformNotSupportedException();
        public static void RectTransformSetAnchorMin(object rectTransform, object anchor)
            => throw new PlatformNotSupportedException();
        public static void RectTransformSetAnchorMax(object rectTransform, object anchor)
            => throw new PlatformNotSupportedException();
        public static void RectTransformSetPivot(object rectTransform, object pivot)
            => throw new PlatformNotSupportedException();
        public static object RectTransformGetRect(object rectTransform)
            => throw new PlatformNotSupportedException();
    }
}