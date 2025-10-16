using System.Collections.Generic;
using System.Linq;
using Commons;
using Foundations.Tickers;
using UnityEngine;

namespace Battles.Indicators
{
    public interface IActionLine
    {
        Vector2 pos { get; set; }
        Vector2 dir { get; set; }

        LinkedList<string> action_lines { get; set; }

        bool need_refresh { get; set; }

        //==================================================================================================

        public void add_action_line(string action_line)
        {
            //规则：行动格最多3个
            if (action_lines.Count == 3) return;

            action_lines.AddLast(action_line);
            need_refresh = true;
        }


        public void remove_action_line(LinkedListNode<string> node)
        {
            if (!action_lines.Any()) return;

            action_lines.Remove(node);
            need_refresh = true;
        }


        bool try_merge_action_line()
        {
            if (action_lines.Count == 1) return false;

            var node = action_lines.First;
            var ret = false;

            while (node != null && node.Next != null)
            {
                //if ((node.Value == "acti_move_right" && node.Next.Value == "acti_move_left") || (node.Value == "acti_move_left" && node.Next.Value == "acti_move_right"))
                //{
                //    node.Value = "acti_turn_around";
                //    action_lines.Remove(node.Next);

                //    ret = true;
                //    continue;
                //}

                node = node.Next;
            }

            need_refresh = ret;
            return ret;
        }


        //==================================================================================================

        void cast()
        {
            if (!action_lines.Any()) return;

            //冻结输入
            var ctx = BattleContext.instance;
            ctx.is_ban_player_input = true;

            //合成行动块
            var can_merge = false;
            can_merge = try_merge_action_line();

            var merge_tick = can_merge ? Config_Utility.second_2_tick(0.5f) : 0;

            //执行行动块
            var i = 0;
            while (i < action_lines.Count)
            {
                Request_Helper.delay_do($"acti_cast_{i}", merge_tick + i * Config_Utility.second_2_tick(0.25f), do_cast);
                i++;

                #region 子函数 do_cast
                void do_cast(Request req)
                {
                    typeof(IActionLine).GetMethod(action_lines.First())?.Invoke(this, null);
                    remove_action_line(action_lines.First);
                }
                #endregion
            }

            //解冻输入
            var whole_tick = merge_tick + i * Config_Utility.second_2_tick(0.25f);
            Request_Helper.delay_do($"revocer_input", whole_tick, (_) => { ctx.is_ban_player_input = false; });

        }


        void acti_move_right()
        {
            var x = pos.x;

            x++;
            x = Mathf.Clamp(x, 0, BattleContext.instance.plots_count - 1);
            pos = new(x, pos.y);
        }


        void acti_move_left()
        {
            var x = pos.x;

            x--;
            x = Mathf.Clamp(x, 0, BattleContext.instance.plots_count - 1);
            pos = new(x, pos.y);
        }


        void acti_turn_around()
        {
            dir = new(-dir.x, dir.y);
        }


        void acti_wait()
        { 
        }


        #region 行动块

        #endregion
    }
}

