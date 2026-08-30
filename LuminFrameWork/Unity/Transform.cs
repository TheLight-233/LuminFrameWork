namespace Unity
{
    /// <summary>Unity Transform 的钩子入口。</summary>
    public static class Transform
    {
        public static object GetPosition(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetPosition(object transform, object position)
            => throw new PlatformNotSupportedException();
        public static object GetLocalPosition(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetLocalPosition(object transform, object position)
            => throw new PlatformNotSupportedException();
        public static object GetRotation(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetRotation(object transform, object rotation)
            => throw new PlatformNotSupportedException();
        public static object GetLocalRotation(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetLocalRotation(object transform, object rotation)
            => throw new PlatformNotSupportedException();
        public static object GetEulerAngles(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetEulerAngles(object transform, object eulerAngles)
            => throw new PlatformNotSupportedException();
        public static object GetLocalEulerAngles(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetLocalEulerAngles(object transform, object eulerAngles)
            => throw new PlatformNotSupportedException();
        public static object GetLocalScale(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetLocalScale(object transform, object scale)
            => throw new PlatformNotSupportedException();
        public static object GetLossyScale(object transform)
            => throw new PlatformNotSupportedException();

        public static object GetParent(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetParent(object transform, object parent)
            => throw new PlatformNotSupportedException();
        public static void SetParent(object transform, object parent, bool worldPositionStays)
            => throw new PlatformNotSupportedException();
        public static int GetChildCount(object transform)
            => throw new PlatformNotSupportedException();
        public static object GetChild(object transform, int index)
            => throw new PlatformNotSupportedException();
        public static object Find(object transform, string name)
            => throw new PlatformNotSupportedException();
        public static object FindChild(object transform, string name)
            => throw new PlatformNotSupportedException();
        public static object GetRoot(object transform)
            => throw new PlatformNotSupportedException();
        public static bool IsChildOf(object transform, object parent)
            => throw new PlatformNotSupportedException();
        public static void DetachChildren(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetAsFirstSibling(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetAsLastSibling(object transform)
            => throw new PlatformNotSupportedException();
        public static void SetSiblingIndex(object transform, int index)
            => throw new PlatformNotSupportedException();
        public static int GetSiblingIndex(object transform)
            => throw new PlatformNotSupportedException();

        public static void LookAt(object transform, object target)
            => throw new PlatformNotSupportedException();
        public static void LookAt(object transform, object target, object worldUp)
            => throw new PlatformNotSupportedException();
        public static void Rotate(object transform, object eulerAngles)
            => throw new PlatformNotSupportedException();
        public static void Rotate(object transform, float xAngle, float yAngle, float zAngle)
            => throw new PlatformNotSupportedException();
        public static void RotateAround(object transform, object point, object axis, float angle)
            => throw new PlatformNotSupportedException();
        public static void Translate(object transform, object translation)
            => throw new PlatformNotSupportedException();
        public static void Translate(object transform, float x, float y, float z)
            => throw new PlatformNotSupportedException();

        public static object GetLocalToWorldMatrix(object transform)
            => throw new PlatformNotSupportedException();
        public static object GetWorldToLocalMatrix(object transform)
            => throw new PlatformNotSupportedException();
        public static object TransformPoint(object transform, object position)
            => throw new PlatformNotSupportedException();
        public static object TransformDirection(object transform, object direction)
            => throw new PlatformNotSupportedException();
        public static object InverseTransformPoint(object transform, object position)
            => throw new PlatformNotSupportedException();
        public static object InverseTransformDirection(object transform, object direction)
            => throw new PlatformNotSupportedException();
    }
}