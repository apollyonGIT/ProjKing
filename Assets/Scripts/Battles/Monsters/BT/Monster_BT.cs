using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Monsters.BT
{
    public class Monster_BT
    {
        public virtual string state_str { get; }
        public string old_state_str;

        //==================================================================================================

        public virtual void init(Monster cell)
        {
        }


        public virtual void notify_on_turn(Monster cell)
        {
            if (old_state_str == state_str)
            {
                GetType().GetMethod($"do_{state_str}")?.Invoke(this, new object[] { cell });
            }
            else
            {
                old_state_str = state_str;
                GetType().GetMethod($"start_{state_str}")?.Invoke(this, new object[] { cell });
            }
            
        }
    }
}

