using Battle.Indicators;
using Battle.Monsters.BT;
using Commons;
using Foundations.MVVM;
using Foundations.Tickers;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Battle.Monsters
{
    public interface IMonsterView : IModelView<Monster>
    {
        void notify_on_tick1();
    }


    public class Monster : Model<Monster, IMonsterView>, IActionLine
    {
        public AutoCodes.monster _desc;
        public string GUID;

        public Vector2 pos;
        public Vector2 view_pos => Config.current.pos_coef * pos;

        public Vector2 dir = Vector2.right;
        public int flipX => dir.x > 0 ? 1 : -1;

        public Monster_BT bt;

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

        public Monster(uint uid, Vector2 pos, Vector2 dir)
        {
            AutoCodes.monsters.TryGetValue($"{uid}", out _desc);

            GUID = Guid.NewGuid().ToString();

            this.pos = pos;
            this.dir = dir;

            //actionLine.add_action_line("acti_move_left");
            //actionLine.add_action_line("acti_move_right");
            //Request_Helper.delay_do("111", Config_Utility.second_2_tick(1f), (_) => { actionLine.cast(); });

            var type = Assembly.Load("Battle").GetType("Battle.Monsters.BT.BT_bat");
            bt = (Monster_BT)Activator.CreateInstance(type);
        }


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


        public void do_turn()
        {
            bt.@do(this);
        }
    }
}





