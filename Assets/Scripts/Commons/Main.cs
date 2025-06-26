using Foundations.SceneLoads;
using UnityEngine;

namespace Commons
{
    public class Main : MonoBehaviour
    {
        public Config config = null;
        public string next_scene_name;

        //==================================================================================================

        private void Awake()
        {
            Config.current = config;

            var go = new GameObject("[Game]");
            DontDestroyOnLoad(go);

            Game_Mgr.on_init_game();

            SceneLoad_Utility.load_scene_async(next_scene_name);
        }
    }
}

