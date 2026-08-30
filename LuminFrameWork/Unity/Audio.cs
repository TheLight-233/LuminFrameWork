namespace Unity
{
    /// <summary>Unity 音频 / AudioSource / AudioListener 的钩子入口。</summary>
    public static class Audio
    {
        public static void Play(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void Play(object audioSource, float delay)
            => throw new PlatformNotSupportedException();
        public static void Stop(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void Pause(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void UnPause(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void SetMute(object audioSource, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetMute(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void SetPlaying(object audioSource, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetPlaying(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void SetVolume(object audioSource, float value)
            => throw new PlatformNotSupportedException();
        public static float GetVolume(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void SetPitch(object audioSource, float value)
            => throw new PlatformNotSupportedException();
        public static float GetPitch(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void SetLoop(object audioSource, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetLoop(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void SetTime(object audioSource, float time)
            => throw new PlatformNotSupportedException();
        public static float GetTime(object audioSource)
            => throw new PlatformNotSupportedException();
        public static void PlayOneShot(object audioSource, object clip)
            => throw new PlatformNotSupportedException();
        public static void PlayOneShot(object audioSource, object clip, float volumeScale)
            => throw new PlatformNotSupportedException();
        public static void SetClip(object audioSource, object clip)
            => throw new PlatformNotSupportedException();
        public static object GetClip(object audioSource)
            => throw new PlatformNotSupportedException();

        public static void AudioListenerPause()
            => throw new PlatformNotSupportedException();
        public static void AudioListenerUnpause()
            => throw new PlatformNotSupportedException();
        public static void SetListenerVolume(float value)
            => throw new PlatformNotSupportedException();
        public static float GetListenerVolume()
            => throw new PlatformNotSupportedException();

        public static object LoadClip(string name)
            => throw new PlatformNotSupportedException();
        public static void DestroyClip(object clip)
            => throw new PlatformNotSupportedException();
    }
}