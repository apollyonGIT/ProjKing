using Battles.Indicators;
using Battles.Players;
using Foundations;
using UnityEngine;

namespace Battles
{
    public class BattleSceneInput : MonoBehaviour
    {

        //==================================================================================================

        public void OnMoveLeft()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.acti_move_left();

            //mgr.cell.actionLine.add_action_line("acti_move_left");
        }


        public void OnMoveRight()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.acti_move_right();
        }


        public void OnCast()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.cast();
        }
    }
}

