﻿using Foundations.MVVM;
using UnityEngine;

namespace Battles.Players
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        Player owner;

        //==================================================================================================

        void IModelView<Player>.attach(Player owner)
        {
            this.owner = owner;

            transform.localPosition = owner.view_pos;
            transform.localScale = new(owner.flipX, 1, 1);
        }


        void IModelView<Player>.detach(Player owner)
        {
            this.owner = null;
        }


        void IPlayerView.notify_on_tick1()
        {
            transform.localPosition = owner.view_pos;
            transform.localScale = new(owner.flipX, 1, 1);
        }
    }
}

