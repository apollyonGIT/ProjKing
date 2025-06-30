using Commons;
using Foundations;
using Foundations.SceneLoads;

namespace Init
{
    public class InitSceneRoot : SceneRoot<InitSceneRoot>
    {
        public string next_scene_name;

        //==================================================================================================

        protected override void on_init()
        {
            base.on_init();
        }


        protected override void on_fini()
        {
            base.on_fini();
        }


        public void btn_start_new_game()
        {
            Valve.on_start_new_game();

            SceneLoad_Utility.load_scene_with_loading(next_scene_name);
        }


        public void btn_exit()
        {
            Valve.on_exit_game();

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}

