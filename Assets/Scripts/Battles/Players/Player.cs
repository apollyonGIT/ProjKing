using System.Collections.Generic;
using Commons;
using Foundations.MVVM;
using UnityEngine;

namespace Battles.Players
{
    public interface IPlayerView : IModelView<Player>
    {
        void notify_on_tick1();
        void notify_on_action_line_change();
    }


    public class Player : Model<Player, IPlayerView>
    {
        public Vector2 pos;
        public Vector2 view_pos => Config.current.pos_coef * pos;

        public Vector2 dir = Vector2.right;
        public int flipX => dir.x > 0 ? 1 : -1;

        LinkedList<string> m_action_lines = new();
        public LinkedList<string> action_lines => m_action_lines;

        //==================================================================================================

        public void tick()
        {

        }


        public void tick1()
        {
            foreach (var view in views)
            {
                view.notify_on_tick1();
            }
        }


        public void add_action_line(string action_line)
        {
            //规则：行动格最多3个
            if (m_action_lines.Count == 3) return;

            m_action_lines.AddLast(action_line);

            foreach (var view in views)
            {
                view.notify_on_action_line_change();
            }
        }
    }
}





