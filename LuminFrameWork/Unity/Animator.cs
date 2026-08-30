namespace Unity
{
    /// <summary>Unity Animator / Animation / 状态机的钩子入口。</summary>
    public static class Animator
    {
        public static void SetFloat(object animator, string name, float value)
            => throw new PlatformNotSupportedException();
        public static float GetFloat(object animator, string name)
            => throw new PlatformNotSupportedException();
        public static void SetInteger(object animator, string name, int value)
            => throw new PlatformNotSupportedException();
        public static int GetInteger(object animator, string name)
            => throw new PlatformNotSupportedException();
        public static void SetBool(object animator, string name, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetBool(object animator, string name)
            => throw new PlatformNotSupportedException();
        public static void SetTrigger(object animator, string name)
            => throw new PlatformNotSupportedException();
        public static void ResetTrigger(object animator, string name)
            => throw new PlatformNotSupportedException();
        public static bool IsParameterControlledByCurve(object animator, string name)
            => throw new PlatformNotSupportedException();
        public static void Play(object animator, string stateName, int layer = -1, float normalizedTime = float.NegativeInfinity)
            => throw new PlatformNotSupportedException();
        public static void Play(object animator, int stateHash, int layer = -1, float normalizedTime = float.NegativeInfinity)
            => throw new PlatformNotSupportedException();
        public static void CrossFade(object animator, string stateName, float normalizedTransitionDuration, int layer = -1)
            => throw new PlatformNotSupportedException();
        public static void CrossFade(object animator, int stateHash, float normalizedTransitionDuration, int layer = -1)
            => throw new PlatformNotSupportedException();
        public static int GetCurrentStateHash(object animator, int layer = 0)
            => throw new PlatformNotSupportedException();
        public static object GetCurrentAnimatorStateInfo(object animator, int layer = 0)
            => throw new PlatformNotSupportedException();
        public static object GetCurrentAnimatorClipInfo(object animator, int layer = 0)
            => throw new PlatformNotSupportedException();
        public static float GetAnimationSpeed(object animator)
            => throw new PlatformNotSupportedException();
        public static void SetAnimationSpeed(object animator, float value)
            => throw new PlatformNotSupportedException();
        public static object GetBodyPosition(object animator)
            => throw new PlatformNotSupportedException();
        public static void SetBodyPosition(object animator, object position)
            => throw new PlatformNotSupportedException();
        public static void SetLayerWeight(object animator, int layer, float weight)
            => throw new PlatformNotSupportedException();
        public static float GetLayerWeight(object animator, int layer)
            => throw new PlatformNotSupportedException();
        public static int GetLayerCount(object animator)
            => throw new PlatformNotSupportedException();
        public static float GetTime(object animator)
            => throw new PlatformNotSupportedException();
        public static bool GetIsPlaying(object animator)
            => throw new PlatformNotSupportedException();
        public static bool HasState(object animator, int layer, int stateHash)
            => throw new PlatformNotSupportedException();
        public static void Update(object animator, float deltaTime)
            => throw new PlatformNotSupportedException();
        public static void StartPlayback(object animator)
            => throw new PlatformNotSupportedException();
        public static void StopPlayback(object animator)
            => throw new PlatformNotSupportedException();
    }
}