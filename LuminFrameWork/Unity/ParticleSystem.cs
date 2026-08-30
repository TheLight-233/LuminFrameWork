namespace Unity
{
    /// <summary>Unity ParticleSystem 粒子的钩子入口。</summary>
    public static class Particle
    {
        public static void Play(object particleSystem, bool withChildren = true)
            => throw new PlatformNotSupportedException();
        public static void Pause(object particleSystem, bool withChildren = true)
            => throw new PlatformNotSupportedException();
        public static void Stop(object particleSystem, bool withChildren = true)
            => throw new PlatformNotSupportedException();
        public static void Clear(object particleSystem, bool withChildren = true)
            => throw new PlatformNotSupportedException();
        public static bool GetIsPlaying(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static bool GetIsPaused(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static bool GetIsStopped(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static void Emit(object particleSystem, int count)
            => throw new PlatformNotSupportedException();
        public static void Emit(object particleSystem, object particle)
            => throw new PlatformNotSupportedException();
        public static void SetTime(object particleSystem, float time)
            => throw new PlatformNotSupportedException();
        public static float GetTime(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static void SetLoop(object particleSystem, bool value)
            => throw new PlatformNotSupportedException();
        public static bool GetLoop(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static void SetPlayOnAwake(object particleSystem, bool value)
            => throw new PlatformNotSupportedException();
        public static void SetDuration(object particleSystem, float value)
            => throw new PlatformNotSupportedException();
        public static float GetDuration(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static void Simulate(object particleSystem, float time, bool withChildren = true)
            => throw new PlatformNotSupportedException();
        public static void SetMainColor(object particleSystem, object color)
            => throw new PlatformNotSupportedException();
        public static object GetMainColor(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static void SetMaxParticles(object particleSystem, int value)
            => throw new PlatformNotSupportedException();
        public static int GetMaxParticles(object particleSystem)
            => throw new PlatformNotSupportedException();
        public static object GetParticleSystem()
            => throw new PlatformNotSupportedException();
    }
}