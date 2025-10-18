using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Monsters.BT
{
    public class BT_bat : Monster_BT
    {
        enum EN_state
        {
            idle,
            chase,
            attack
        }

        public override string state_str => m_state.ToString();
        EN_state m_state;

        //==================================================================================================

        public override void init(Monster cell)
        {
            m_state = EN_state.idle;
        }


        public override void notify_on_turn(Monster cell)
        {
            base.notify_on_turn(cell);
        }


        //==================================================================================================

        #region idle
        public void start_idle(Monster cell)
        {
            //cell.actionLine.add_action_line("acti_move_right");

            Debug.Log("start_idle");
        }


        public void do_idle(Monster cell)
        {
            Debug.Log("do_idle");
            m_state = EN_state.chase;
        }
        #endregion


        #region chase
        public void start_chase(Monster cell)
        {
            //cell.actionLine.add_action_line("acti_move_right");

            Debug.Log("start_chase");
        }


        public void do_chase(Monster cell)
        {
            Debug.Log("do_chase");
            m_state = EN_state.idle;
        }
        #endregion
    }
}

