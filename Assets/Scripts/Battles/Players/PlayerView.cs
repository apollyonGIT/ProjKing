using System;
using System.Linq;
using Foundations.MVVM;
using UnityEngine;
using static Battles.Indicators.ActionLineController;

namespace Battles.Players
{
    public class PlayerView : MonoBehaviour, IPlayerView, IActionLineAttacher
    {
        Player owner;

        #region IAction_Line_View
        Action<string[]> m_action_line_change;
        Action<string[]> IActionLineAttacher.action_line_change { get => m_action_line_change; set => m_action_line_change = value; }
        #endregion

        //==================================================================================================

        void IModelView<Player>.attach(Player owner)
        {
            this.owner = owner;

            calc_transform();
        }


        void IModelView<Player>.detach(Player owner)
        {
            this.owner = null;
        }


        void IPlayerView.notify_on_tick1()
        {
            calc_transform();
        }


        void calc_transform()
        {
            transform.localPosition = owner.view_pos;
            transform.localScale = new(owner.flipX, 1, 1);
        }


        void IPlayerView.notify_on_action_line_change()
        {
            m_action_line_change?.Invoke(owner.action_lines.ToArray());
        }
    }
}

