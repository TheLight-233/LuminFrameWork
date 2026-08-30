using System.Collections;

namespace Unity
{
    /// <summary>Unity MonoBehaviour 生命周期/协程相关的钩子入口。</summary>
    public static class MonoBehaviour
    {
        public static bool GetEnabled(object behaviour)
            => throw new PlatformNotSupportedException();
        public static void SetEnabled(object behaviour, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetIsActiveAndEnabled(object behaviour)
            => throw new PlatformNotSupportedException();

        public static object StartCoroutine(object behaviour, object coroutine)
            => throw new PlatformNotSupportedException();
        public static object StartCoroutine(object behaviour, string methodName)
            => throw new PlatformNotSupportedException();
        public static void StopCoroutine(object behaviour, object coroutine)
            => throw new PlatformNotSupportedException();
        public static void StopCoroutine(object behaviour, string methodName)
            => throw new PlatformNotSupportedException();
        public static void StopAllCoroutines(object behaviour)
            => throw new PlatformNotSupportedException();

        public static object Invoke(object behaviour, string methodName, float time)
            => throw new PlatformNotSupportedException();
        public static void InvokeRepeating(object behaviour, string methodName, float time, float repeatRate)
            => throw new PlatformNotSupportedException();
        public static void CancelInvoke(object behaviour)
            => throw new PlatformNotSupportedException();
        public static void CancelInvoke(object behaviour, string methodName)
            => throw new PlatformNotSupportedException();
        public static bool IsInvoking(object behaviour, string methodName)
            => throw new PlatformNotSupportedException();

        public static IEnumerator WaitForSeconds(float seconds)
            => throw new PlatformNotSupportedException();
        public static IEnumerator WaitForEndOfFrame()
            => throw new PlatformNotSupportedException();
        public static IEnumerator WaitForFixedUpdate()
            => throw new PlatformNotSupportedException();
        public static object CreateCoroutineYield(float seconds)
            => throw new PlatformNotSupportedException();
    }
}