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

            if (mgr.cell.dir == Vector2.right)
                mgr.move_back();
            else
                mgr.move_forward();
        }


        public void OnMoveRight()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);

            if (mgr.cell.dir == Vector2.right)
                mgr.move_forward();
            else
                mgr.move_back();
        }


        public void OnTurnAround()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.turn_around();
        }


        public void OnDefense()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.defense();
        }


        public void OnCast()
        {
            if (BattleContext.instance.is_ban_player_input) return;

            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            mgr.cast();
        }
    }
}

