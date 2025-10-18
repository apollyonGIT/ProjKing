using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Monsters.BT
{
    public class BT_bat : Monster_BT
    {
        public override void @do(Monster cell)
        {
            base.@do(cell);

            cell.actionLine.add_action_line("acti_move_right");

        }
    }
}

