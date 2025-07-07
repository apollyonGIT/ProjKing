using Battles.Players;
using Foundations;
using UnityEngine;

namespace Battles
{
    public class BattleInput : MonoBehaviour
    {

        //==================================================================================================

        public void OnMoveBack()
        {
            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);

            mgr.move_back();
        }


        public void OnMoveForward()
        {
            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);

            mgr.move_forward();
        }


        public void OnTurnAround()
        {
            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);

            mgr.turn_around();
        }


        public void OnWait()
        {
            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
        }
    }
}

