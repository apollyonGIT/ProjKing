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
            mgr.cell.actionLine.add_action_line("acti_move_left");
        }


        public void OnMoveRight()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.add_action_line("acti_move_right");
        }


        public void OnDoubleAC()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.add_action_line("acti_double_ac");
        }


        public void OnAttack()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.add_action_line("acti_attack");
        }


        public void OnCast()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.cast();
        }


        public void OnDeleteAC()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cell.actionLine.delete_ac();
        }
    }
}

