namespace Unity
{
    /// <summary>Unity 场景管理（SceneManager / Scene）的钩子入口。</summary>
    public static class Scene
    {
        public static int GetSceneCount()
            => throw new PlatformNotSupportedException();
        public static object GetActiveScene()
            => throw new PlatformNotSupportedException();
        public static object GetSceneAt(int index)
            => throw new PlatformNotSupportedException();
        public static object GetSceneByName(string name)
            => throw new PlatformNotSupportedException();
        public static object GetSceneByPath(string path)
            => throw new PlatformNotSupportedException();
        public static string GetSceneName(object scene)
            => throw new PlatformNotSupportedException();
        public static int GetSceneBuildIndex(object scene)
            => throw new PlatformNotSupportedException();
        public static bool GetSceneIsLoaded(object scene)
            => throw new PlatformNotSupportedException();
        public static bool GetSceneIsDirty(object scene)
            => throw new PlatformNotSupportedException();
        public static object[] GetRootGameObjects(object scene)
            => throw new PlatformNotSupportedException();
        public static object GetSceneGOByIndex(object scene, int index)
            => throw new PlatformNotSupportedException();
    }

    /// <summary>Unity 场景加载/卸载的钩子入口。</summary>
    public static class SceneManager
    {
        public static void LoadScene(string sceneName)
            => throw new PlatformNotSupportedException();
        public static void LoadScene(int sceneBuildIndex)
            => throw new PlatformNotSupportedException();
        public static object LoadSceneAsync(string sceneName)
            => throw new PlatformNotSupportedException();
        public static object LoadSceneAsync(int sceneBuildIndex)
            => throw new PlatformNotSupportedException();
        public static void UnloadScene(string sceneName)
            => throw new PlatformNotSupportedException();
        public static object UnloadSceneAsync(string sceneName)
            => throw new PlatformNotSupportedException();
        public static object UnloadSceneAsync(object target)
            => throw new PlatformNotSupportedException();
        public static bool SetActiveScene(object scene)
            => throw new PlatformNotSupportedException();
        public static object CreateScene(string sceneName)
            => throw new PlatformNotSupportedException();
        public static object CreateScene(string sceneName, bool isDefaultStage)
            => throw new PlatformNotSupportedException();
        public static async System.Threading.Tasks.Task MoveGameObjectToScene(object gameObject, object scene)
            => throw new PlatformNotSupportedException();
        public static int GetSceneCountInBuildSettings()
            => throw new PlatformNotSupportedException();
        public static void MergeScenes(object source, object destination)
            => throw new PlatformNotSupportedException();
    }
}