using System.Linq;
using Foundations;
using Foundations.Tickers;
using UnityEngine;

namespace Battles.Players
{
    public class PlayerMgr : IMgr
    {
        string IMgr.name => m_mgr_name;
        readonly string m_mgr_name;

        int IMgr.priority => m_mgr_priority;
        readonly int m_mgr_priority;

        public Player cell;

        //==================================================================================================

        public PlayerMgr(string name, int priority, params object[] args)
        {
            m_mgr_name = name;
            m_mgr_priority = priority;

            (this as IMgr).init(args);
        }


        void IMgr.init(params object[] args)
        {
            Mission.instance.attach_mgr(m_mgr_name, this);

            var ticker = Foundations.Tickers.Ticker.instance;
            ticker.add_tick(m_mgr_priority, m_mgr_name, tick);
            ticker.add_tick1(m_mgr_priority, m_mgr_name, tick1);
        }


        void IMgr.fini()
        {
            Mission.instance.detach_mgr(m_mgr_name);

            var ticker = Foundations.Tickers.Ticker.instance;
            ticker.remove_tick(m_mgr_name);
            ticker.remove_tick1(m_mgr_name);
        }


        void tick()
        {
            cell.tick();
        }


        void tick1()
        {
            cell.tick1();
        }


        public void move_forward()
        {
            cell.add_action_line("acti_move_forward");
        }


        public void move_back()
        {
            cell.add_action_line("acti_move_back");
        }


        public void turn_around()
        {
            cell.add_action_line("acti_turn_around");
        }


        public void defense()
        {
            cell.add_action_line("acti_defense");
        }


        public void cast()
        {
            var action_lines = cell.action_lines;
            var count = action_lines.Count;
            var i = 0;

            while (i < count)
            {
                Request_Helper.delay_do($"player_action_line_cast_{i}", i * 30, do_cast);
                i++;

                #region 子函数 do_cast
                void do_cast(Request req)
                {
                    typeof(Movers.IMover).GetMethod(action_lines.First())?.Invoke(cell, null);
                    cell.remove_action_line();
                }
                #endregion
            }
        }
    }
}