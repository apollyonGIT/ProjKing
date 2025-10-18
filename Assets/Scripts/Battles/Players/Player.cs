using System.Collections.Generic;
using Battle.Indicators;
using Commons;
using Foundations.MVVM;
using UnityEngine;

namespace Battle.Players
{
    public interface IPlayerView : IModelView<Player>
    {
        void notify_on_tick1();
    }


    public class Player : Model<Player, IPlayerView>, IActionLine
    {
        public Vector2 pos;
        public Vector2 view_pos => Config.current.pos_coef * pos;

        public Vector2 dir = Vector2.right;
        public int flipX => dir.x > 0 ? 1 : -1;

        #region IActionLine
        Vector2 IActionLine.pos { get => pos; set => pos = value; }
        Vector2 IActionLine.dir { get => dir; set => dir = value; }

        LinkedList<string> IActionLine.action_lines { get => m_action_lines; set => m_action_lines = value; }
        LinkedList<string> m_action_lines = new();

        bool IActionLine.need_refresh { get => m_need_refresh; set => m_need_refresh = value; }
        bool m_need_refresh;

        public IActionLine actionLine => this;
        #endregion

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
    }
}





