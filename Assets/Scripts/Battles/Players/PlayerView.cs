using Foundations.MVVM;
using UnityEngine;
using Battles.Indicators;

namespace Battles.Players
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        public ActionLineController actionLineController;

        Player owner;

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


        void IPlayerView.notify_on_refresh_action_line(string[] action_line_array)
        {
            actionLineController.do_refresh(action_line_array);
        }
    }
}

