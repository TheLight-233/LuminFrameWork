namespace Godot
{
    /// <summary>Godot Audio 音频播放钩子入口。</summary>
    public static class Audio
    {
        public static void Play(object player, float fromPosition = 0f) => throw new PlatformNotSupportedException();
        public static void Stop(object player) => throw new PlatformNotSupportedException();
        public static void Pause(object player) => throw new PlatformNotSupportedException();
        public static void SetStream(object player, object stream) => throw new PlatformNotSupportedException();
        public static object GetStream(object player) => throw new PlatformNotSupportedException();
        public static void SetVolumeDb(object player, float value) => throw new PlatformNotSupportedException();
        public static float GetVolumeDb(object player) => throw new PlatformNotSupportedException();
        public static void SetVolumeLinear(object player, float value) => throw new PlatformNotSupportedException();
        public static float GetVolumeLinear(object player) => throw new PlatformNotSupportedException();
        public static void SetPitchScale(object player, float value) => throw new PlatformNotSupportedException();
        public static float GetPitchScale(object player) => throw new PlatformNotSupportedException();
        public static void SetPlaying(object player, bool value) => throw new PlatformNotSupportedException();
        public static bool GetPlaying(object player) => throw new PlatformNotSupportedException();
        public static void SetAutoplay(object player, bool value) => throw new PlatformNotSupportedException();
        public static void SetBus(object player, string bus) => throw new PlatformNotSupportedException();
        public static string GetBus(object player) => throw new PlatformNotSupportedException();
        public static float GetPlaybackPosition(object player) => throw new PlatformNotSupportedException();
        public static void SetStreamLoop(object player, bool value) => throw new PlatformNotSupportedException();
        public static bool GetStreamLoop(object player) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot AudioServer 音频服务器钩子入口。</summary>
    public static class AudioServer
    {
        public static void SetBusVolumeDb(int busIndex, float volumeDb) => throw new PlatformNotSupportedException();
        public static float GetBusVolumeDb(int busIndex) => throw new PlatformNotSupportedException();
        public static void SetBusMute(int busIndex, bool value) => throw new PlatformNotSupportedException();
        public static bool GetBusMute(int busIndex) => throw new PlatformNotSupportedException();
        public static void SetBusSolo(int busIndex, bool value) => throw new PlatformNotSupportedException();
        public static int GetBusIndex(string name) => throw new PlatformNotSupportedException();
        public static string GetBusName(int busIndex) => throw new PlatformNotSupportedException();
        public static int GetBusCount() => throw new PlatformNotSupportedException();
        public static void AddListener(object listener) => throw new PlatformNotSupportedException();
    }
}