using System.Collections.Generic;
using System.Linq;
using Foundations.Tickers;
using UnityEngine;

namespace Battles.Indicators
{
    public interface IActionLine
    {
        Vector2 pos { get; set; }
        Vector2 dir { get; set; }

        LinkedList<string> action_lines { get; set; }

        //==================================================================================================

        void acti_move_forward()
        {
            var x = pos.x;

            x += 1 * dir.x;
            x = Mathf.Clamp(x, 0, BattleContext.instance.plots_count - 1);
            pos = new(x, pos.y);
        }


        void acti_move_back()
        {
            var x = pos.x;

            x -= 1 * dir.x;
            x = Mathf.Clamp(x, 0, BattleContext.instance.plots_count - 1);
            pos = new(x, pos.y);
        }


        void acti_turn_around()
        {
            dir = new(-dir.x, dir.y);
        }


        void acti_defense()
        {

        }


        void cast()
        {
            var count = action_lines.Count;
            var i = 0;

            while (i < count)
            {
                Request_Helper.delay_do($"player_action_line_cast_{i}", i * 30, do_cast);
                i++;

                #region 子函数 do_cast
                void do_cast(Request req)
                {
                    typeof(IActionLine).GetMethod(action_lines.First())?.Invoke(this, null);
                    remove_action_line(action_lines.First());
                }
                #endregion
            }
        }


        //==================================================================================================


        public void add_action_line(string action_line)
        {
            //规则：行动格最多3个
            if (action_lines.Count == 3) return;

            action_lines.AddLast(action_line);
            refresh_action_line();
        }


        public void remove_action_line(string action_line)
        {
            action_lines.Remove(action_line);
            refresh_action_line();
        }


        void refresh_action_line();
    }
}

