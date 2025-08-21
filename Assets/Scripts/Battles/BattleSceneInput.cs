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

            mgr.move_left();
        }


        public void OnMoveRight()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);

            mgr.move_right();
        }


        public void OnDoubleAC()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.double_ac();
        }


        public void OnAttack()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.attack();
        }


        public void OnCast()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cast();
        }
    }
}

