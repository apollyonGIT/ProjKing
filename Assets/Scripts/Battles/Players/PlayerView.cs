using Foundations.MVVM;
using UnityEngine;
using System;

namespace Battle.Players
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        Player owner;

        Action<object> IModelView.tick1 { get => m_tick1_ac; set => m_tick1_ac = value; }
        Action<object> m_tick1_ac;

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

            m_tick1_ac?.Invoke(owner);
        }


        void calc_transform()
        {
            transform.localPosition = owner.view_pos;
            transform.localScale = new(owner.flipX, 1, 1);
        }
    }
}

