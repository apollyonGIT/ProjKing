using Foundations;
using UnityEngine;

namespace Battles.Cameras
{
    public class CameraPD : Producer
    {
        public Vector2 pos_offset;

        public override IMgr imgr => null;

        //==================================================================================================

        public override void call()
        {

        }


        public override void init(int priority)
        {
            Vector2 pos = new(BattleContext.instance.plots_mid_pos_x, 0);
            pos += pos_offset;

            BattleSceneRoot.instance.mainCamera.transform.localPosition = pos;
        }
    }
}

