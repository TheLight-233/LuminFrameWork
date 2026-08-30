namespace Godot
{
    /// <summary>Godot AnimationPlayer 动画播放钩子入口。</summary>
    public static class AnimationPlayer
    {
        public static void Play(object player, string name = "idle", float customBlend = -1f, float customSpeed = 1f, bool fromEnd = false) => throw new PlatformNotSupportedException();
        public static void PlayBackwards(object player, string name = "idle") => throw new PlatformNotSupportedException();
        public static void PlayFront(object player, string name, float customBlend, int backwards = 0, int forward = 0) => throw new PlatformNotSupportedException();
        public static void Pause(object player) => throw new PlatformNotSupportedException();
        public static void Stop(object player, bool keepState = false) => throw new PlatformNotSupportedException();
        public static void Seek(object player, double seconds, bool update = false) => throw new PlatformNotSupportedException();
        public static float GetCurrentAnimationLength(object player) => throw new PlatformNotSupportedException();
        public static object GetAnimation(object player) => throw new PlatformNotSupportedException();
        public static void SetAnimation(object player, object animation) => throw new PlatformNotSupportedException();
        public static string GetCurrentAnimation(object player) => throw new PlatformNotSupportedException();
        public static string GetCurrentAnimationLibrary(object player) => throw new PlatformNotSupportedException();
        public static double GetCurrentAnimationPosition(object player) => throw new PlatformNotSupportedException();
        public static bool GetPlaying(object player) => throw new PlatformNotSupportedException();
        public static void SetPlaying(object player, bool value) => throw new PlatformNotSupportedException();
        public static float GetPlaybackSpeed(object player) => throw new PlatformNotSupportedException();
        public static void SetPlaybackSpeed(object player, float value) => throw new PlatformNotSupportedException();
        public static void SetAnimationProcessMode(object player, int value) => throw new PlatformNotSupportedException();
        public static bool GetAnimationProcess(object player) => throw new PlatformNotSupportedException();
        public static void SetAnimationProcess(object player, bool value) => throw new PlatformNotSupportedException();
        public static void Advance(object player, double time) => throw new PlatformNotSupportedException();
        public static void ConnectSignal(object player, string signal, object callable, object flags) => throw new PlatformNotSupportedException();
        public static void SetPrimaryStream(object player, object stream) => throw new PlatformNotSupportedException();
        public static void SetSecondaryStream(object player, object stream) => throw new PlatformNotSupportedException();
    }

    /// <summary>Godot Animation / 动画资源钩子入口。</summary>
    public static class Animation
    {
        public static void AddTrack(object animation, int type, int atPosition = -1) => throw new PlatformNotSupportedException();
        public static void RemoveTrack(object animation, int trackIndex) => throw new PlatformNotSupportedException();
        public static int GetTrackCount(object animation) => throw new PlatformNotSupportedException();
        public static void TrackInsertKey(object animation, int trackIndex, double time, object key, float transition = 0f) => throw new PlatformNotSupportedException();
        public static int TrackFindKey(object animation, int trackIndex, double time, bool exactMatch = false) => throw new PlatformNotSupportedException();
        public static object TrackGetKeyValue(object animation, int trackIndex, int keyIndex) => throw new PlatformNotSupportedException();
        public static void TrackSetKeyTime(object animation, int trackIndex, int keyIndex, double time) => throw new PlatformNotSupportedException();
        public static double GetLength(object animation, double value) => throw new PlatformNotSupportedException();
        public static void SetLength(object animation, double value) => throw new PlatformNotSupportedException();
        public static void TrackSetLooping(object animation, int trackIndex, int value) => throw new PlatformNotSupportedException();
        public static void TrackSetEnabled(object animation, int trackIndex, bool value) => throw new PlatformNotSupportedException();
        public static object AnimationMerge(object animation, object toAnimation) => throw new PlatformNotSupportedException();
    }
}